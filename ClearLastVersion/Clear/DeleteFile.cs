using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Principal;
using System.Security.AccessControl;

namespace Clear
{
    /// <summary>
    /// class for DeleteFile
    /// </summary>
    static class MyDeleteFile
    {
        /// <summary>
        /// method for delete file
        /// </summary>
        /// <param name="files">list path files</param>
        public static void DeleteFiles(List<string> files)
        {
            bool flag = false;
            foreach (var file in files)
            {
                try
                {
                    File.SetAttributes(file, FileAttributes.Normal);
                    File.Delete(file);
                }
                catch (Exception e)
                {
                    
                }
            }
        }
    }
}
