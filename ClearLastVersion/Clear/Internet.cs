using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clear
{
    /// <summary>
    /// class common internet broser
    /// </summary>
    class Internet
    {
        /// <summary>
        /// field chrome
        /// </summary>
        private Chrome chrome = new Chrome();
        /// <summary>
        /// filed opera
        /// </summary>
        private Opera opera = new Opera();
        /// <summary>
        /// field explorer
        /// </summary>
        private InternetExplorer explorer = new InternetExplorer();
        /// <summary>
        /// filed mozilla
        /// </summary>
        private MozillaFirefox mozilla = new MozillaFirefox();
        /// <summary>
        /// field for save info
        /// </summary>
        List<string> info = new List<string>();

        /// <summary>
        /// methof for call all methods for collect cache
        /// </summary>
        /// <param name="flag">flag delete</param>
        public void Cache(bool flag)
        {
            this.info.Add(this.chrome.CallCache(flag));
            this.info.Add(this.opera.CallCache(flag));
            this.info.Add(this.explorer.CallCache(flag));
            this.info.Add(this.mozilla.CallCache(flag));
        }

        /// <summary>
        /// methof for call all methods for collect histori
        /// </summary>
        /// <param name="flag">flag delete</param>
        public void History(bool flag)
        {
            this.info.Add(this.chrome.CallHistory(flag));
            this.info.Add(this.opera.CallHistory(flag));
            this.info.Add(this.explorer.CallHistory(flag));
            this.info.Add(this.mozilla.CallHistory(flag));
        }

        /// <summary>
        /// methof for call all methods for collect Cookies
        /// </summary>
        /// <param name="flag">flag delete</param>
        public void Cookies(bool flag)
        {
            this.info.Add(this.chrome.CallCookies(flag));
            this.info.Add(this.opera.CallCookies(flag));
            this.info.Add(this.explorer.CallCookies(flag));
            this.info.Add(this.mozilla.CallCookies(flag));
        }

        /// <summary>
        /// methof get info
        /// </summary>
        /// <returns></returns>
        public List<string> GetList()
        {
            return this.info;
        }

        /// <summary>
        /// method for reset
        /// </summary>
        public void Reset()
        {
            this.info.Clear();
            this.mozilla.Reset();
            this.explorer.Reset();
            this.chrome.Reset();
            this.opera.Reset();
        }

        /// <summary>
        /// property get Chrome
        /// </summary>
        public Chrome GetChrome
        {
            get
            {
                return this.chrome;
            }
        }

        /// <summary>
        /// propery Get Opera
        /// </summary>
        public Opera GetOpera
        {
            get
            {
                return this.opera;
            }
        }

        /// <summary>
        /// property get Mozilla
        /// </summary>
        public MozillaFirefox GetMozilla
        {
            get
            {
                return this.mozilla;
            }
        }

        /// <summary>
        /// property get Explorer
        /// </summary>
        public InternetExplorer GetExplorer
        {
            get
            {
                return this.explorer;
            }
        }


    }
}
