using System;
using System.Threading;

namespace Engine.Globals
{
    public static class TestReadWriteMemory
    {
        public static void onBunnyHope(BaseVars baseVars)
        {
            Memory RAM = new Memory(baseVars.GameProcess);
            OffsetDictionary dic = new OffsetDictionary();

            int FJump = baseVars.GameClient + signatures.dwForceJump;
            int aPlayer = baseVars.GameClient + signatures.dwLocalPlayer;
            int LocalPlayer = RAM.ReadMemory<Int32>(aPlayer);
            int aFlag = LocalPlayer + Netvars.m_fFlags;

            while (true)
            {
                while (WinApi.GetAsyncKeyState(32) > 0)
                {
                    int _Flag = RAM.ReadMemory<Int32>(aFlag);
                    if (_Flag == 257)
                    {
                        RAM.WriteMemory<Int32>(FJump, 5);
                        Thread.Sleep(10);
                        RAM.WriteMemory<Int32>(FJump, 4);
                    }
                }
                Thread.Sleep(10);
            }
        }
        public static void OnWallHack(BaseVars baseVars)
        {
            Memory mem = new Memory(baseVars.GameProcess);
            while (true)
            {
                Structs.GlowEffects Enemy = new Structs.GlowEffects()
                {
                    colorRed = 1,
                    colorGreen = 1,
                    colorBlue = 0,
                    colorAlpha = 1,
                    rwo = true,
                    rwuo = true
                };
                Structs.GlowEffects Team = new Structs.GlowEffects()
                {
                    colorRed = 0,
                    colorGreen = 0,
                    colorBlue = 0,
                    colorAlpha = 0,
                    rwo = true,
                    rwuo = true
                };
                int address;
                int i = 1;

                do
                {
                    address = baseVars.GameClient + signatures.dwLocalPlayer;
                    int Player = mem.ReadMemory<Int32>(address);
                    address = Player + Netvars.m_iTeamNum;
                    int MyTeam = mem.ReadMemory<Int32>(address);
                    address = baseVars.GameClient + signatures.dwEntityList + (i - 1) * 0x10;
                    int EntityList = mem.ReadMemory<Int32>(address);
                    address = EntityList + Netvars.m_iTeamNum;
                    int HisTeam = mem.ReadMemory<Int32>(address);
                    address = EntityList + signatures.m_bDormant;

                    if (!baseVars.VAM.ReadBoolean((IntPtr)address))
                    {
                        address = EntityList + Netvars.m_iGlowIndex;
                        int GlowIndex = mem.ReadMemory<Int32>(address);

                        if (MyTeam == HisTeam)
                        {
                            address = baseVars.GameClient + signatures.dwGlowObjectManager;
                            int GlowObject = mem.ReadMemory<Int32>(address);
                            int calculation = GlowIndex * 0x38 + 0x4;
                            int current = GlowObject + calculation;
                            baseVars.VAM.WriteFloat((IntPtr)current, Team.colorRed);
                            mem.WriteMemory<float>(current, Team.colorRed);

                            calculation = GlowIndex * 0x38 + 0x8;
                            current = GlowObject + calculation;
                            mem.WriteMemory<float>(current, Team.colorGreen);

                            calculation = GlowIndex * 0x38 + 0xC;
                            current = GlowObject + calculation;
                            mem.WriteMemory<float>(current, Team.colorBlue);

                            calculation = GlowIndex * 0x38 + 0x10;
                            current = GlowObject + calculation;
                            mem.WriteMemory<float>(current, Team.colorAlpha);

                            calculation = GlowIndex * 0x38 + 0x24;
                            current = GlowObject + calculation;
                            mem.WriteMemory<bool>(current, Team.rwo);

                            calculation = GlowIndex * 0x38 + 0x25;
                            current = GlowObject + calculation;
                            mem.WriteMemory<bool>(current, Team.rwuo);
                        }
                        else
                        {
                            address = baseVars.GameClient + signatures.dwGlowObjectManager;
                            int GlowObject = baseVars.VAM.ReadInt32((IntPtr)address);
                            int calculation = GlowIndex * 0x38 + 0x4;
                            int current = GlowObject + calculation;
                            mem.WriteMemory<float>(current, Enemy.colorRed);

                            calculation = GlowIndex * 0x38 + 0x8;
                            current = GlowObject + calculation;
                            mem.WriteMemory<float>(current, Enemy.colorGreen);

                            calculation = GlowIndex * 0x38 + 0xC;
                            current = GlowObject + calculation;
                            mem.WriteMemory<float>(current, Enemy.colorBlue);

                            calculation = GlowIndex * 0x38 + 0x10;
                            current = GlowObject + calculation;
                            mem.WriteMemory<float>(current, Enemy.colorAlpha);

                            calculation = GlowIndex * 0x38 + 0x24;
                            current = GlowObject + calculation;
                            mem.WriteMemory<bool>(current, Enemy.rwo);

                            calculation = GlowIndex * 0x38 + 0x25;
                            current = GlowObject + calculation;
                            mem.WriteMemory<bool>(current, Enemy.rwuo);
                        }
                    }

                    i++;
                } while (i < 65);

                Thread.Sleep(10);
            }
        }
    }
}
