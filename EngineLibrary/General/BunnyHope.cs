using System;
using System.Threading;

namespace CoreEngine
{

    /// <summary>
    /// Отвечает за безошбочные прыжки по карте, позволяет намного быстрее передвигаться по карте
    /// </summary>
    public class BunnyHope
    {
        public static void onBunnyHope(BaseVars baseVars)
        {
            #region Calculation
            int FJump = baseVars.GameClient + signatures.dwForceJump;
            int aPlayer = baseVars.GameClient + signatures.dwLocalPlayer;
            int LocalPlayer = baseVars.VAM.ReadInt32((IntPtr)aPlayer);
            int aFlag = LocalPlayer + Netvars.m_fFlags;
            #endregion

            while (true)
            {
                while (WinApi.GetAsyncKeyState(32) > 0)
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




