using System;

namespace Engine
{
    /// <summary>
    /// Automatical updater for offsets
    /// </summary>
    interface IUpdater
    {
        /// <summary>
        /// Download string with new offsets from github
        /// </summary>
        void DownloadOffsets();

        /// <summary>
        /// Update offsets
        /// </summary>
        /// <param name="offsetName">offset name in Dictionary</param>
        /// <param name="varName">offset ref in Dictionary</param>
        void UpdateOffset(string offsetName, ref Int32 varName);
    }
}
