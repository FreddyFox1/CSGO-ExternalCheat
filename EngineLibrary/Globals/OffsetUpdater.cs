using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Globals
{
    /// <summary>
    /// Автоматическое обновление оффсетов с Hazedumper
    /// Automatical update offsets from Hazedumper
    /// </summary>
    public class OffsetUpdater : IUpdater
    {
        public static string WebData;
        public OffsetUpdater()
        {
            DownloadOffsets();
        }

        public void DownloadOffsets()
        {
            WebClient web = new WebClient();
            WebData = web.DownloadString("https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.cs");
        }

        public void ParseLine()
        {
            throw new NotImplementedException();
        }

        public void UpdateOffset(string offsetName, ref int varName)
        {
            throw new NotImplementedException();
        }
    }
}
