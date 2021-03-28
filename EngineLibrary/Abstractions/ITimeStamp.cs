using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEngine.Abstractions
{
    /// <summary>
    /// Offsets checker
    /// </summary>
    interface ITimeStamp
    {
        /// <summary>
        /// Get TimeStamp from hazedumper
        /// </summary>
        void GetTimeStamp();
        
        /// <summary>
        /// Compare Timestamp with config of program
        /// if Timestamp match with config nothing else need update config
        /// </summary>
        void CompareStamp();
        
        /// <summary>
        /// Update timestamp in config
        /// </summary>
        void UpdateConfig();
    }
}
