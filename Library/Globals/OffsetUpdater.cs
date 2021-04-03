using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Engine.Globals
{
    /// <summary>
    /// Автоматическое обновление оффсетов с Hazedumper
    /// Automatical update offsets from Hazedumper
    /// </summary>
    public class OffsetUpdater : IUpdater
    {
        public static string WebData = String.Empty;
        public OffsetUpdater()
        {
            DownloadOffsets();
        }

        public void DownloadOffsets()
        {
            WebClient web = new WebClient();
            WebData = web.DownloadString("https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.cs");
        }

        public void UpdateOffset(string offsetName, int varName)
        {
            Regex rgx = new Regex($"public const Int32 {offsetName} = 0x.*;"); // csgo.cs format from HazeDumper
            Match match = rgx.Match(WebData);
            if (match.Success)
            {
                string hexValue = match.Value.Split('=').GetValue(1).ToString().Replace(" ", "").Replace(";", "");
                varName = Convert.ToInt32(hexValue, 16);
            }
            else
            {
                MessageBox.Show($"Error finding the following offset: {offsetName}" +
                    $"{Environment.NewLine}This will likely prevent the cheat from functioning properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

