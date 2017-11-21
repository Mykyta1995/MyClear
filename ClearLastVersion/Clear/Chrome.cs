using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Clear
{
    /// <summary>
    /// class for analizing and clear browser Chrome
    /// </summary>
    class Chrome : Delete
    {
        /// <summary>
        /// field root folder for search information
        /// </summary>
        string root = @"\Google\Chrome\User Data";
        /// <summary>
        /// field list file and folder cache
        /// </summary>
        readonly List<string> cache = null;
        /// <summary>
        /// field list file and folder cookies
        /// </summary>
        readonly List<string> cookies = null;
        /// <summary>
        /// field list file and folder history
        /// </summary>
        readonly List<string> history = null;
        /// <summary>
        /// filed for know choise user
        /// </summary>
        bool acess = true;
        /// <summary>
        /// field for total size
        /// </summary>
        long size = 0;
        /// <summary>
        /// field for all file cache
        /// </summary>
        List<string> wayCache = new List<string>();
        /// <summary>
        /// field for all file cookies
        /// </summary>
        List<string> wayCookies = new List<string>();
        /// <summary>
        /// field for all file history
        /// </summary>
        List<string> wayHistory = new List<string>();

        /// <summary>
        /// default constructor
        /// </summary>
        public Chrome()
        {
            this.root = string.Format("{0}{1}", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), this.root);
            this.root = this.SeachFolder(new DirectoryInfo(this.root), "Default");
            this.cache = new List<string> { "Cache", "Media Cache", "GPUCache",
                                          "Storage", "Application Cache", "File System","Service Worker","Local Storage",
                                          "ShaderCache","D456.tmp","Cookies-journal","Extension Cookies-journal","Favicons-journal",
                                          "History-journal","Login Data-journal","Network Action Predictor-journal",
                                          "Origin Bound Certs-journal","QuotaManager-journal","Shortcuts-journal",
                                          "Top Sites-journal","Web Data-journal"};
            this.history = new List<string>{"History", "Visited Links", "Current Tabs",
                                          "Last Tabs","Top Sites","History Provider Cache","Network Action Predictor"};
            this.cookies = new List<string> { "databases", "IndexedDB", "Shockwave Flash" };
        }

        /// <summary>
        /// method for collect information cache and delete files
        /// </summary>
        /// <param name="flag">flag for understand clear or analize</param>
        /// <returns>information</returns>
        public string CallCache(bool flag)
        {
            this.size = 0;
            bool flagFile = false;
            if (this.acess)
            {
                for (var index = 0; index < this.cache.Count; index++)
                {
                    if (this.cache[index].Contains('.') || flagFile)
                    {
                        flagFile = true;
                        this.DeleteFile(string.Format("{0}\\{1}", this.root, this.cache[index]), "chrome", flag, ref this.size, this.wayCache,ref this.acess);
                    }
                    else if (this.cache[index].Contains("ShaderCache"))
                        this.WalkDir(new DirectoryInfo(string.Format("{0}\\{1}", this.root.Remove(this.root.LastIndexOf("\\")), this.cache[index])), "chrome", flag, ref this.size, this.wayCache, ref this.acess);
                    else
                        this.WalkDir(new DirectoryInfo(string.Format("{0}\\{1}", this.root, this.cache[index])), "chrome", flag, ref this.size, this.wayCache, ref this.acess);
                }
            }
            if (!this.acess)
                return string.Format("Chrome - Internet-cache: skipped :  ");
            return string.Format("Chrome - Internet-cache: {0} KB:{1} File(-s)", this.size / 1000, this.wayCache.Count);
        }

        /// <summary>
        /// method for collect information history and delete files
        /// </summary>
        /// <param name="flag">flag for understand clear or analize</param>
        /// <returns>information</returns>
        public string CallHistory(bool flag)
        {
            this.size = 0;
            if (this.acess)
            {
                foreach (var file in this.history)
                {
                    this.DeleteFile(string.Format("{0}\\{1}", this.root, file), "chrome", flag, ref size, this.wayHistory, ref this.acess);
                }
            }
            if (!this.acess)
                return string.Format("Chrome - history-file: skipped :  ");
            return string.Format("Chrome - history-file: {0} KB:{1} File(-s)", this.size / 1000, this.wayHistory.Count);
        }
        /// <summary>
        /// method for collect information cookies and delete files
        /// </summary>
        /// <param name="flag">flag for understand clear or analize</param>
        /// <returns>information</returns>
        public string CallCookies(bool flag)
        {
            this.size = 0;
            if (this.acess)
            {
                foreach (var folder in this.cookies)
                {
                    this.WalkDir(new DirectoryInfo(string.Format("{0}\\{1}", this.root, folder)), "chrome", flag, ref this.size, this.wayCookies, ref this.acess);
                }
            }
            if (!this.acess)
                return string.Format("Chrome - cookies-file: skipped :  ");
            return string.Format("Chrome - cookies-file: {0} KB:{1} File(-s)", this.size / 1000, this.wayCookies.Count);
        }

        /// <summary>
        /// method for reset information
        /// </summary>
        public void Reset()
        {
            this.acess = true;
            this.wayCache.Clear();
            this.wayCookies.Clear();
            this.wayHistory.Clear();
            base.Reset();
        }

        /// <summary>
        /// method for get wayCache
        /// </summary>
        public override List<string> GetWayCache
        {
            get
            {
                return this.wayCache;
            }
        }

        /// <summary>
        /// method for get wayCookies
        /// </summary>
        public override List<string> GetWayCookies
        {
            get
            {
                return this.wayCookies;
            }

        }

        /// <summary>
        /// method fr get wayHistory
        /// </summary>
        public override List<string> GetWayHistory
        {
            get
            {
                return this.wayHistory;
            }
        }

        /// <summary>
        /// method for get bool
        /// </summary>
        /// <returns></returns>
        public override bool GetAcess()
        {
            return this.acess;
        }
    }
}
