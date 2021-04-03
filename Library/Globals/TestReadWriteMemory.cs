using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Engine.Globals
{
    public static class TestReadWriteMemory
    {
        public static void onBunnyHope(BaseVars baseVars)
        {
            Memory mem = new Memory(baseVars.GameProcess);

            int FJump = baseVars.GameClient + signatures.dwForceJump;
            int aPlayer = baseVars.GameClient + signatures.dwLocalPlayer;
            int LocalPlayer = mem.ReadMemory<Int32>(aPlayer);
            int aFlag = LocalPlayer + Netvars.m_fFlags;


            while (true)
            {
                while (WinApi.GetAsyncKeyState(32) > 0)
                {
                    int _Flag = mem.ReadMemory<Int32>(aFlag);
                    if (_Flag == 257)
                    {
                        mem.WriteMemory<Int32>(FJump, 5);
                        Thread.Sleep(10);
                        mem.WriteMemory<Int32>(FJump, 4);
                    }
                }
                Thread.Sleep(10);
            }
        }
    }
}
