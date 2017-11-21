using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Specialized;
using System.Diagnostics;

namespace Clear
{
    /// <summary>
    /// class Main
    /// </summary>
    class Delete
    {
        /// <summary>
        /// field for write exeption
        /// </summary>
        StringCollection log = new StringCollection();

        /// <summary>
        /// filed for write choise user
        /// </summary>
        Dictionary<string, bool> answer = new Dictionary<string, bool>();

        /// <summary>
        /// method for walk folders
        /// </summary>
        /// <param name="root">point start walk</param>
        /// <param name="browser">name process browser if browser not close</param>
        /// <param name="flag">flag for collect information or delete file</param>
        /// <param name="size">size files</param>
        /// <param name="way">list write to path file</param>
        /// <param name="acess">acess</param>
        /// <param name="mask">mask search files</param>
        public void WalkDir(DirectoryInfo root, string browser, bool flag, ref long size, List<string> way, ref bool acess, string mask = "*.*")
        {
            DirectoryInfo[] dirs = null;
            FileInfo[] files = null;
            try
            {
                files = root.GetFiles(mask);
            }
            catch (UnauthorizedAccessException ex)
            {
                this.log.Add(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {

            }
            if (files != null)
            {
                foreach (var file in files)
                {

                    if (flag) this.DeleteFile(file.FullName, browser, flag, ref size, null, ref acess);
                    else if (mask != "*.*")
                    {
                        if (file.Name.Remove(0, file.Name.LastIndexOf('.')).CompareTo(mask.Remove(0, 1)) == 0)
                        {
                            if (this.TestOpenFile(file.FullName))
                            {
                                way.Add(file.FullName);
                                size += file.Length;
                            }
                        }
                    }
                    else
                    {
                        if (browser != "system")
                            this.KillProcess(browser, ref acess);
                        if (this.TestOpenFile(file.FullName))
                        {
                            way.Add(file.FullName);
                            size += file.Length;
                        }
                    }
                }
                dirs = root.GetDirectories();
                foreach (var dir in dirs)
                {
                    WalkDir(dir, browser, flag, ref size, way, ref acess, mask);
                    if (!browser.Contains("system"))
                        this.Test(browser, acess);
                    else if (browser.Contains("system") && flag)
                    {
                        try
                        {
                            Directory.Delete(dir.FullName);
                        }
                        catch (Exception e)
                        {

                        }
                    }

                }
            }
        }

        /// <summary>
        /// method for test file
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private bool TestOpenFile(string file)
        {
            try
            {
                using (File.Open(file,FileMode.Open))
                {
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }


        }

        /// <summary>
        /// method for test if browser write in this.answer
        /// </summary>
        /// <param name="browser">key</param>
        /// <param name="acess">acess</param>
        public void Test(string browser, bool acess)
        {
            if (!this.answer.ContainsKey(browser))
            {
                this.KillProcess(browser, ref acess);
                if (!this.answer.ContainsKey(browser))
                    this.answer.Add(browser, true);
            }
        }

        /// <summary>
        /// methof for search folder
        /// </summary>
        /// <param name="root">start point</param>
        /// <param name="folderName">name serach file</param>
        /// <returns></returns>
        public string SeachFolder(DirectoryInfo root, string folderName)
        {
            string wayDef = null;
            foreach (var folder in root.GetDirectories())
            {
                if (folder.Name.Contains(folderName))
                {
                    wayDef = folder.FullName;
                    if (Directory.GetDirectories(wayDef).Length != 0)
                    {
                        break;
                    }
                }
            }
            return wayDef;
        }

        /// <summary>
        /// method for close process browser
        /// </summary>
        /// <param name="search"></param>
        /// <param name="acess"></param>
        private void KillProcess(string search, ref bool acess)
        {
            try
            {
                foreach (var i in Process.GetProcesses().Where(x => x.ProcessName.Contains(search)))
                {
                    if (!this.answer.ContainsKey(search))
                    {
                        this.answer.Add(search, Mediator.MainMathod(search));
                    }
                    if (!this.answer[search])
                    {
                        acess = false;
                        return;
                    }

                    i.Kill();
                }
            }
            catch (Exception ex)
            {
                KillProcess(search, ref acess);
            }
        }

        /// <summary>
        /// methof for delete file
        /// </summary>
        /// <param name="way">path delete file</param>
        /// <param name="root">point start walk</param>
        /// <param name="browser">name process browser if browser not close</param>
        /// <param name="flag">flag for collect information or delete file</param>
        /// <param name="size">size files</param>
        /// <param name="wayfile">list write to path file</param>
        /// <param name="acess">acess</param>
        public void DeleteFile(string way, string browser, bool flag, ref long size, List<string> wayfile, ref bool acess, bool again = true)
        {
            try
            {
                if (File.Exists(way) && again)
                {
                    if (wayfile != null) wayfile.Add(way);
                    if (flag)
                        File.Delete(way);
                    else
                    {
                        using (var fs=File.Open(way, FileMode.Open))
                        {
                            size += fs.Length;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                if (!this.answer.ContainsKey(browser))
                {
                    this.KillProcess(browser, ref acess);
                    if (!this.answer.ContainsKey(browser)) this.answer.Add(browser, true);
                }
                if (this.answer[browser])
                {
                    this.KillProcess(browser, ref acess);
                    DeleteFile(way, browser, flag, ref size, wayfile, ref acess, false);
                }
            }
        }
        /// <summary>
        /// method reset information
        /// </summary>
        public void Reset()
        {
            this.answer.Clear();
        }

        /// <summary>
        /// property for Get cache
        /// </summary>
        public virtual List<string> GetWayCache
        {
            get
            {
                return new List<string>();
            }
        }

        /// <summary>
        /// property for get cookies
        /// </summary>
        public virtual List<string> GetWayCookies
        {
            get
            {
                return new List<string>();
            }
        }

        /// <summary>
        /// property for get history
        /// </summary>
        public virtual List<string> GetWayHistory
        {
            get
            {
                return new List<string>();
            }
        }

        /// <summary>
        /// property for get system files
        /// </summary>
        public virtual List<string> GetSysytemFile
        {
            get
            {
                return new List<string>();
            }
        }

        /// <summary>
        /// property for get acess
        /// </summary>
        /// <returns></returns>
        public virtual bool GetAcess()
        {
            return true;
        }
    }
}

