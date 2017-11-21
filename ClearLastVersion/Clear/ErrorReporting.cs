using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clear
{
    /// <summary>
    /// class for called information and delete files
    /// </summary>
    class ErrorReporting : Delete
    {
        /// <summary>
        /// field root 
        /// </summary>
        string root = null;
        /// <summary>
        /// filed for save path file
        /// </summary>
        List<string> wayFile = new List<string>();
        /// <summary>
        /// field for save size files
        /// </summary>
        long size = 0;
        /// <summary>
        /// field mask
        /// </summary>
        readonly List<string> mask = new List<string> { "*.wer", "*.xml", "*.dmp", "*.hdmp" };

        /// <summary>
        /// constructor default
        /// </summary>
        public ErrorReporting()
        {
            this.root = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\Microsoft\Windows\WER\ReportQueue\";
        }

        /// <summary>
        /// methof for called info or delete files
        /// </summary>
        /// <param name="flag">flag for delete</param>
        /// <returns>information </returns>
        public string CallClear(bool flag)
        {
            if (!flag)
            {
                bool acess = true;
                foreach (var mask in this.mask)
                {
                    this.WalkDir(new DirectoryInfo(this.root), "system", flag, ref this.size, this.wayFile, ref acess, mask);
                }
                this.WalkDir(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)), "system", flag, ref this.size, this.wayFile, ref acess, this.mask[0]);
            }
            else
            {
                MyDeleteFile.DeleteFiles(this.wayFile);
            }
            return string.Format("Error Reporting Windows: {0} KB:{1} File(-s)", this.size / 1000, this.wayFile.Count);
        }

        /// <summary>
        /// method reset
        /// </summary>
        public void Reset()
        {
            this.wayFile.Clear();
            this.size = 0;
        }

        /// <summary>
        /// methof for Get Information 
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
