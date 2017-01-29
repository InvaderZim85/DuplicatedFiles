using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DuplicatedFiles.DataObjects;

namespace DuplicatedFiles.Business
{
    public class FileManager
    {
        /// <summary>
        /// Delegate for the info event
        /// </summary>
        /// <param name="max">The max count</param>
        /// <param name="step">The current step</param>
        /// <param name="msg">The message</param>
        public delegate void InfoMessage(int max, int step, string msg);
        /// <summary>
        /// Event to inform about the current state
        /// </summary>
        public event InfoMessage InfoEvent;
        /// <summary>
        /// Fires the info event
        /// </summary>
        /// <param name="max">The max count</param>
        /// <param name="step">The current step</param>
        /// <param name="msg">The message</param>
        private void InfoMessageNotifier(int max, int step, string msg)
        {
            InfoEvent?.Invoke(max, step, msg);
        }
        /// <summary>
        /// Gets all files in the given folder
        /// </summary>
        /// <param name="directoryPath">The path of the folder</param>
        /// <param name="includeSubDirs">true if sub directory should inclouded, otherwise false</param>
        /// <returns>List of files</returns>
        public List<FileModel> GetDuplicatedFileList(string directoryPath, bool includeSubDirs)
        {
            var dirInfo = new DirectoryInfo(directoryPath);

            var files = dirInfo.GetFiles("*.*",
                includeSubDirs ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);


            var tmpList = new List<FileModel>();

            var total = files.Length;
            var count = 0;
            foreach (var file in files)
            {
                if (!IsImage(file.Extension))
                {
                    count++;
                    continue;
                }

                var msg = $"Berechne Hash für \"{file.Name}";
                InfoMessageNotifier(total, count++, msg);
                tmpList.Add(new FileModel(file, GetMd5Hash(file)));
            }

            InfoMessageNotifier(0, 0, "Daten geladen.");

            var duplicatedList = tmpList.GroupBy(g => g.Md5Hash).Where(w => w.Count() > 1).Select(s => s.First()).ToList();

            var result = new List<FileModel>();

            foreach (var entry in duplicatedList)
            {
                result.AddRange(tmpList.Where(w => w.Md5Hash == entry.Md5Hash));
            }

            return result;
        }
        /// <summary>
        /// Gets the md5 hash of a file
        /// </summary>
        /// <param name="file">The file</param>
        /// <returns>The md5 hash</returns>
        private string GetMd5Hash(FileInfo file)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(file.FullName))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream));
                }
            }
        }
        /// <summary>
        /// Checks if the file is an image
        /// </summary>
        /// <param name="extension">The extension of the file</param>
        /// <returns>true if its a file, otherwise false</returns>
        private bool IsImage(string extension)
        {
            var extensions = new[] {".jpg", ".png", ".bmp", ".tiff", ".jpeg"};

            return extensions.Contains(extension.ToLower());
        }
    }
}
