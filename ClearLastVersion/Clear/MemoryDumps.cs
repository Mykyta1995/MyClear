using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clear
{
    /// <summary>
    /// class for memory dumps
    /// </summary>
    class MemoryDumps : Delete
    {
        /// <summary>
        /// filed start point
        /// </summary>
        readonly string root = null;
        /// <summary>
        /// methof for save path file
        /// </summary>
        List<string> wayFile = new List<string>();
        /// <summary>
        /// filed for save size files
        /// </summary>
        long size = 0;

        /// <summary>
        /// default constructor
        /// </summary>
        public MemoryDumps()
        {
            this.root = string.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.Windows), "LiveKernelReports");
        }

        /// <summary>
        /// method for colled info or delete files
        /// </summary>
        /// <param name="flag">flag delete</param>
        /// <returns>information</returns>
        public string CallClear(bool flag)
        {
            bool acess=true;
            if (!flag)
            {
                this.WalkDir(new DirectoryInfo(this.root), "system", flag, ref this.size, this.wayFile,ref acess);
            }
            else
            {
                MyDeleteFile.DeleteFiles(this.wayFile);
            }
            return string.Format("Memory Dump: {0} KB:{1} File(-s)", this.size / 1000, this.wayFile.Count);
        }

        /// <summary>
        /// method for reset 
        /// </summary>
        public void Reset()
        {
            this.wayFile.Clear();
            this.size = 0;
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
