using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Clear
{
    /// <summary>
    /// class for open explorer
    /// </summary>
    static class OpenProcess
    {
        /// <summary>
        /// method for create process
        /// </summary>
        /// <param name="path">path to file</param>
        public static void CreateProcessOpen(string path)
        {
            try
            {
                using(File.Open(path,FileMode.Open))
                {
                    
                }
                string argument = "/select, \"" + path + "\"";
                Process.Start("explorer", argument);
            }
            catch(Exception e)
            {

            }
           
        }
    }
}
