using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEngine
{
    /// <summary>
    /// Automatical updater for offsets
    /// </summary>
    interface IUpdater
    {
        /// <summary>
        /// Download string with new offesets from github
        /// </summary>
        void DownloadOffsets();

        /// <summary>
        /// Parsing WebData
        /// </summary>
        void ParseLine();

        /// <summary>
        /// Update offsets on refs
        /// </summary>
        /// <param name="offsetName">offset name in Dictionary</param>
        /// <param name="varName">offset ref in Dictionary</param>
        void UpdateOffset(string offsetName, ref int varName);
    }
}
