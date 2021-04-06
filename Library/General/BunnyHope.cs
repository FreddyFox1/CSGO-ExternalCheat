using Engine.Globals;
using System;
using System.Threading;

namespace Engine.General
{
    /// <summary>
    /// Отвечает за безошбочные прыжки по карте, позволяет намного быстрее передвигаться по карте
    /// </summary>
    public static class BunnyHope
    {
        public static void On(BaseVars baseVars)
        {
            int FJump = baseVars.GameClient + signatures.dwForceJump;
            int aPlayer = baseVars.GameClient + signatures.dwLocalPlayer;
            int LocalPlayer = baseVars.VAM.ReadMemory<Int32>(aPlayer);
            int aFlag = LocalPlayer + Netvars.m_fFlags;

            while (true)
            {
                while (WinApi.GetAsyncKeyState(32) > 0)
                {
                    int _Flag = baseVars.VAM.ReadMemory<Int32>(aFlag);
                    if (_Flag == 257)
                    {
                        baseVars.VAM.WriteMemory<Int32>(FJump, 5);
                        Thread.Sleep(10);
                        baseVars.VAM.WriteMemory<Int32>(FJump, 4);
                    }
                }
                Thread.Sleep(10);
            }
        }
    }
}





