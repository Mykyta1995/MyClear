using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clear
{
    /// <summary>
    /// class for analizing and clear browser Mozilla Firefox
    /// </summary>
    class MozillaFirefox : Delete
    {
        /// <summary>
        /// field root folder for search information
        /// </summary>
        readonly string root = @"\Mozilla\Firefox\Profiles\";
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
        public MozillaFirefox()
        {
            this.root = string.Format("{0}{1}", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), this.root);
            this.root = this.SeachFolder(new DirectoryInfo(this.root), "default");
            this.cache = new List<string> { "cache","cache2", "jumpListCache", "favicons.sqlite", "places.sqlite-wal", "favicons.sqlite-wal", 
                "places.sqlite-shm", "favicons.sqlite-shm","storage\\permanent\\chrome\\idb\\2918063365piupsah.sqlite-wal",
            "storage\\permanent\\chrome\\idb\\2918063365piupsah.sqlite-shm","cookies.sqlite-wal","webappsstore.sqlite-wal","cookies.sqlite-shm","webappsstore.sqlite-shm"};
            this.history = new List<string> { "places.sqlite", "thumbnails" };
            this.cookies = new List<string> { "cookies.sqlite", "storage\\default" };
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
                foreach (var folder in this.cache)
                {
                    if (!folder.Contains('.'))
                        this.WalkDir(new DirectoryInfo(string.Format("{0}\\{1}", this.root, folder)), "firefox", flag, ref size, this.wayCache, ref this.acess);
                    else
                        this.DeleteFile(string.Format("{0}\\{1}", this.root.Replace("Local", "Roaming"), folder), "firefox", flag, ref size, this.wayCache, ref this.acess);
                }
            }
            if (!this.acess)
                return string.Format("Mozilla Firefox - Internet-cache: skipped :  ");
            return string.Format("Mozilla Firefox - Internet-cache: {0} KB:{1} File(-s)", this.size / 1000, this.wayCache.Count);
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
                    if (!file.Contains('.'))
                        this.WalkDir(new DirectoryInfo(string.Format("{0}\\{1}", this.root, file)), "firefox", flag, ref size, this.wayHistory, ref this.acess);
                    else
                        this.DeleteFile(string.Format("{0}\\{1}", this.root.Replace("Local", "Roaming"), file), "firefox", flag, ref size, this.wayHistory, ref this.acess);
                }
            }
            if (!this.acess)
                return string.Format("Mozilla Firefox - history-file: skipped :  ");
            return string.Format("Mozilla Firefox - history-file: {0} KB:{1} File(-s)", this.size / 1000, this.wayHistory.Count);
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
                foreach (var file in this.cookies)
                {
                    if (!file.Contains('.'))
                        this.WalkDir(new DirectoryInfo(string.Format("{0}\\{1}", this.root.Replace("Local", "Roaming"), file)), "firefox", flag, ref size, this.wayCookies,ref this.acess);
                    else
                        this.DeleteFile(string.Format("{0}\\{1}", this.root, file), "firefox", flag, ref size, this.wayCookies,ref this.acess);
                }
            }
            if (!this.acess)
                return string.Format("Mozilla Firefox - cookies-file: skipped :  ");
            return string.Format("Mozilla Firefox - cookies-file: {0} KB:{1} File(-s)", this.size / 1000, this.wayCookies.Count);
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
