using System.IO;

namespace DuplicatedFiles.DataObjects
{
    public class FileModel
    {
        /// <summary>
        /// Contains the file info
        /// </summary>
        private readonly FileInfo _fileInfo;
        /// <summary>
        /// Gets the fileinfo
        /// </summary>
        public FileInfo FileInfo => _fileInfo;
        /// <summary>
        /// Gets the name of the file
        /// </summary>
        public string FileName => _fileInfo.Name;
        /// <summary>
        /// Gets the path of the file
        /// </summary>
        public string Filepath => _fileInfo.FullName;
        /// <summary>
        /// Gets or sets the md5 hash
        /// </summary>
        public string Md5Hash { get; set; }
        /// <summary>
        /// Creates an empty instance of the class
        /// </summary>
        public FileModel() { }
        /// <summary>
        /// Creates a new instance of the class
        /// </summary>
        /// <param name="fileInfo">The fileinfo</param>
        /// <param name="md5Hash">The md5 hash</param>
        public FileModel(FileInfo fileInfo, string md5Hash)
        {
            _fileInfo = fileInfo;
            Md5Hash = md5Hash;
        }
        /// <summary>
        /// Gets the name of the file
        /// </summary>
        /// <returns>The name of the file</returns>
        public override string ToString()
        {
            return _fileInfo.Name;
        }
    }
}
