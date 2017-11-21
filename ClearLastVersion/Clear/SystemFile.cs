using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clear
{
    /// <summary>
    /// class common systems files
    /// </summary>
    class SystemFile
    {
        /// <summary>
        /// field RecentDocuments
        /// </summary>
        private RecentDocuments recentDocuments = new RecentDocuments();
        /// <summary>
        /// filed Temp
        /// </summary>
        private Temp temp = new Temp();
        /// <summary>
        /// field MemoryDumps
        /// </summary>
        private MemoryDumps memoryDumps = new MemoryDumps();
        /// <summary>
        /// field logFile
        /// </summary>
        private LogFiles logFile = new LogFiles();
        /// <summary>
        /// filed ErrorReporting
        /// </summary>
        private ErrorReporting errorRepopring = new ErrorReporting();
        /// <summary>
        /// field PrefetchFiles
        /// </summary>
        private PrefetchFiles prefetchFiles = new PrefetchFiles();
        /// <summary>
        /// fileld Recycle
        /// </summary>
        private Recycle recucle=new Recycle();
        //field list information
        List<string> info = new List<string>();

        /// <summary>
        /// methof for get Recent Documents
        /// </summary>
        /// <param name="flag">flag delete</param>
        public void CallClearRecentDoc(bool flag)
        {
           this.info.Add(recentDocuments.CallClear(flag));
        }

        /// <summary>
        /// methof for get Temp Files
        /// </summary>
        /// <param name="flag">flag delete</param>
        public void CallClearTempFiles(bool flag)
        {
            this.info.Add(temp.CallClear(flag));
        }

        /// <summary>
        /// methof for get Memody Dump 
        /// </summary>
        /// <param name="flag">flag delete</param>
        public void CallClearMemodyDumps(bool flag)
        {
            this.info.Add(memoryDumps.CallClear(flag));
        }

        /// <summary>
        /// methof for get Log Files 
        /// </summary>
        /// <param name="flag">flag delete</param>
        public void CallClearLogFiles(bool flag)
        {
            this.info.Add(logFile.CallClear(flag));
        }

        /// <summary>
        /// methof for get Error Reporting
        /// </summary>
        /// <param name="flag">flag delete</param>
        public void CallClearErrorReporting(bool flag)
        {
            this.info.Add(errorRepopring.CallClear(flag));
        }

        /// <summary>
        /// methof for get Prefetch Files
        /// </summary>
        /// <param name="flag">flag delete</param>
        public void CallClearPrefetchFiles(bool flag)
        {
            this.info.Add(prefetchFiles.CallClear(flag));
        }

        /// <summary>
        /// methof for get Recycle Files
        /// </summary>
        /// <param name="flag">flag delete</param>
        public void CallClearRecycle(bool flag)
        {
            this.info.Add(recucle.CallClear(flag));
        }

        /// <summary>
        /// method for reset
        /// </summary>
        public void Reset()
        {
            this.info.Clear();
            this.recentDocuments.Reset();
            this.temp.Reset();
            this.logFile.Reset();
            this.errorRepopring.Reset();
            this.prefetchFiles.Reset();
            this.recucle.Reset();
        }

        /// <summary>
        /// methof for get information
        /// </summary>
        /// <returns>information</returns>
        public List<string> GetInfo()
        {
            return this.info;
        }

        /// <summary>
        /// property Recent Documents
        /// </summary>
        public RecentDocuments GetRecentDocuments
        {
            get
            {
                return this.recentDocuments;
            }
        }

        /// <summary>
        /// property Temp
        /// </summary>
        public Temp GetTemp
        {
            get
            {
                return this.temp;
            }
        }

        /// <summary>
        /// property Memory Dumps
        /// </summary>
        public MemoryDumps GetMemoryDumps
        {
            get
            {
                return this.memoryDumps;
            }
        }

        /// <summary>
        /// property Log Files
        /// </summary>
        public LogFiles GetLogFiles
        {
            get
            {
                return this.logFile;
            }
        }

        /// <summary>
        /// property Error Reporting
        /// </summary>
        public ErrorReporting GetErrorReporting
        {
            get
            {
                return this.errorRepopring;
            }
        }

        /// <summary>
        /// property Prefetch Files
        /// </summary>
        public PrefetchFiles GetPrefetchFiles
        {
            get
            {
                return this.prefetchFiles;
            }
        }

        /// <summary>
        /// property Recycle
        /// </summary>
        public Recycle GetRecycle
        {
            get
            {
                return this.recucle;
            }
        }
       
    }
}
