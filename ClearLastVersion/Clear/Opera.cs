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
    class Opera : Delete
    {
        /// <summary>
        /// class for analizing and clear browser Chrome
        /// </summary>
        string root = @"\AppData\Roaming\Opera Software\Opera Stable\";
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
        List<string> wayHistory = new List<string>();
        /// <summary>
        /// field for all file history
        /// </summary>
        List<string> wayCookies = new List<string>();

        /// <summary>
        /// default constructor
        /// </summary>
        public Opera()
        {
            this.root = string.Format("{0}{1}", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), this.root);
            this.cache = new List<string> { "cache", "GPUCache", "ShaderCache", "Jump List Icons",
                                            "Jump List IconsOld", "Cookies-journal.","History-journal.","Login Data-journal.",
                                            "Network Action Predictor-journal.","Origin Bound Certs-journal.","Web Data-journal.","Favicons-journal."};
            this.history = new List<string>{"History", "Visited Links", "Current Tabs", "Last Tabs",
                                            "History Provider Cache","Network Action Predictor"};
            this.cookies = new List<string> { "Cookies" };
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
                for (var index = 0; index < this.cache.Count; index++)
                {

                    if (index == 0)
                        this.WalkDir(new DirectoryInfo(string.Format("{0}{1}", this.root.Replace("Roaming", "Local"), this.cache[index])), "opera", flag, ref this.size, this.wayCache, ref this.acess);
                    else if (this.cache[index].Contains('.'))
                        this.DeleteFile(string.Format("{0}{1}", this.root, this.cache[index].Remove(this.cache[index].LastIndexOf('.'))), "opera", flag, ref this.size, this.wayCache, ref this.acess);
                    else
                        this.WalkDir(new DirectoryInfo(string.Format("{0}{1}", this.root, this.cache[index])), "opera", flag, ref this.size, this.wayCache, ref this.acess);
                }
            }
            if (!this.acess)
                return string.Format("Opera - internet-cache: skipped : ");
            return string.Format("Opera - internet-cache: {0} KB:{1} File(-s)", this.size / 1000, this.wayCache.Count);
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
                    this.DeleteFile(string.Format("{0}{1}", this.root, file), "opera", flag, ref this.size, this.wayHistory, ref this.acess);
                }
            }
            if (!this.acess)
                return string.Format("Opera - history-file: skipped : ");
            return string.Format("Opera - history-file: {0} KB:{1} File(-s)", this.size / 1000, this.wayHistory.Count);
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
                this.DeleteFile(string.Format("{0}{1}", this.root, this.cookies), "opera", flag, ref this.size, this.wayCookies, ref this.acess);
            }
            if (!this.acess)
                return string.Format("Opera - cookies-file: skipped : ");
            return string.Format("Opera - cookies-file: {0} KB:{1} File(-s)", this.size / 1000, this.wayCookies.Count);
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
