using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicatedFiles.Global
{
    public static class Helper
    {
        /// <summary>
        /// Opens or shows a file
        /// </summary>
        /// <param name="filepath">The filepath</param>
        /// <param name="open">true if the file should open, otherwise false</param>
        public static void OpenExecute(string filepath, bool open)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = open ? filepath : "explorer.exe", 
                Arguments = open ? "" : $"/select,{filepath}"
            };

            Process.Start(startInfo);
        }
    }
}
