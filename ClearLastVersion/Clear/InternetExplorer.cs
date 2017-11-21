using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clear
{
    /// <summary>
    /// class for analizing and clear browser Explorer
    /// </summary>
    class InternetExplorer : Delete
    {
        /// <summary>
        /// field root folder for search information
        /// </summary>
        string root = @"\AppData\Local\Microsoft\Internet Explorer\Recovery\";
        /// <summary>
        /// field list file and folder cache
        /// </summary>
        readonly string cache = null;
        /// <summary>
        /// field list file and folder cookies
        /// </summary>
        readonly string cookies = null;
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
        private long size = 0;
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
        public InternetExplorer()
        {
            this.root = string.Format("{0}{1}", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), this.root);
            this.cache = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
            this.cookies = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
            this.history = new List<string> { "Active", "Immersive", "Last Active" };
        }

        /// <summary>
        /// method for collect information cache and delete files
        /// </summary>
        /// <param name="flag">flag for understand clear or analize</param>
        /// <returns>information</returns>
        public string CallCache(bool flag)
        {
            this.size = 0;
            if (this.acess)
            {
                this.WalkDir(new DirectoryInfo(this.cache), "iexplore", flag, ref this.size, this.wayCache, ref this.acess);
            }
            if (!this.acess)
                return string.Format("Internet Explorer - internet-cache: skipped : ");
            return string.Format("Internet Explorer - internet-cache: {0} KB:{1} File(-s)", this.size / 1000, this.wayCache.Count);
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
                foreach (var folder in this.history)
                {
                    this.WalkDir(new DirectoryInfo(string.Format("{0}{1}", this.root, folder)), "iexplore", flag, ref this.size, this.wayHistory, ref this.acess);
                }
                this.WalkDir(new DirectoryInfo(string.Format("{0}\\High\\Last Active", this.root)), "iexplore", flag, ref this.size, this.wayHistory, ref this.acess,"*.dat");
            }
            if (!this.acess)
                return string.Format("Internet Explorer - history-file: skipped : ");
            return string.Format("Internet Explorer - history-file: {0} KB:{1} File(-s)", this.size / 1000, this.wayHistory.Count);
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
                this.WalkDir(new DirectoryInfo(this.cookies), "iexplore", flag, ref this.size, this.wayCookies, ref this.acess);
                this.WalkDir(new DirectoryInfo(string.Format("{0}\\Microsoft\\Internet Explorer\\DOMStore\\", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData))), "iexplore", flag, ref this.size, this.wayCookies, ref this.acess,"*.xml");
                this.WalkDir(new DirectoryInfo(string.Format("{0}Low\\Microsoft\\Internet Explorer\\DOMStore\\", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData))), "iexplore", flag, ref this.size, this.wayCookies, ref this.acess, "*.xml");
            }
            if (!this.acess)
                return string.Format("Internet Explorer - cookies-file: skipped : ");
            return string.Format("Internet Explorer - cookies-file: {0} KB:{1} File(-s)", this.size / 1000, this.wayCookies.Count);
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
