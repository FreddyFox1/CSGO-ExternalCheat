using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoreEngine
{
    public class bunnyhope
    {
        public static void BunnyHope(BaseVars baseVars)
        {
            #region Calculation
            int FJump = baseVars.GameClient + DefaultOffsets.aJump;
            int aPlayer = baseVars.GameClient + DefaultOffsets.aLocalPlayer;
            int LocalPlayer = baseVars.VAM.ReadInt32((IntPtr)aPlayer);
            int aFlag = LocalPlayer + DefaultOffsets.oFlags;
            #endregion

            while (User32.GetAsyncKeyState(32) > 0)
            {
                int _Flag = baseVars.VAM.ReadInt32((IntPtr)aFlag);
                if (_Flag == 257)
                {
                    baseVars.VAM.WriteInt32((IntPtr)FJump, 5);
                    Thread.Sleep(10);
                    baseVars.VAM.WriteInt32((IntPtr)FJump, 4);
                }
            }
            Thread.Sleep(10);
        }
    }
}
}



