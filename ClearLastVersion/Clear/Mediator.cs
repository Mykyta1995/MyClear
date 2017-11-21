using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clear
{
    /// <summary>
    /// class-delegate
    /// </summary>
    static class Mediator
    {
        /// <summary>
        /// property for call main method 
        /// </summary>
        public static Func<string,bool> MainMathod { set; get; }
        /// <summary>
        /// property for path browser
        /// </summary>
        public static Action<string> GetBroewser { set; get; }
        /// <summary>
        /// property for path answer
        /// </summary>
        public static Action<bool> SetAnswer { set; get; }

        /// <summary>
        /// method for static anser
        /// </summary>
        public static int Answer{set;get;}

    }
}
