using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clear
{
    /// <summary>
    /// class for save info log files
    /// </summary>
    class Temp : Delete
    {
        /// <summary>
        /// field first root
        /// </summary>
        readonly string rootApp = null;
        /// <summary>
        /// filed second root
        /// </summary>
        readonly string rootWindows = null;
        /// <summary>
        /// filed for save size files
        /// </summary>
        long size = 0;
        /// <summary>
        /// filed for save path file
        /// </summary>
        List<string> wayFile = new List<string>();

        /// <summary>
        /// default constructor
        /// </summary>
        public Temp()
        {
            this.rootApp = Path.GetTempPath();
            this.rootWindows = @"C:\Windows\Temp\";
        }

        /// <summary>
        /// method for colled info or delete files
        /// </summary>
        /// <param name="flag">flag delete</param>
        /// <returns>information</returns>
        public string CallClear(bool flag)
        {
            bool acess = true;
            if (!flag)
            {
                this.WalkDir(new DirectoryInfo(this.rootApp), "system", flag, ref this.size, this.wayFile,ref acess);
                this.WalkDir(new DirectoryInfo(this.rootWindows), "system", flag, ref this.size, this.wayFile,ref acess);
            }
            else
            {
                MyDeleteFile.DeleteFiles(this.wayFile);
            }
            return string.Format("Temporary files: {0} KB:{1} File(-s)", this.size / 1000, this.wayFile.Count);
        }

        /// <summary>
        /// method for reset 
        /// </summary>
        public void Reset()
        {
            this.size = 0;
            this.wayFile.Clear();
        }

        /// <summary>
        /// method for get files
        /// </summary>
        public override List<string> GetSysytemFile
        {
            get
            {
                return this.wayFile;
            }
        }

    }
}
