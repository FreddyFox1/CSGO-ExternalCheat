using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoreEngine
{
    public class wallhack
    {
        public static void OnWallHack(BaseVars baseVars)
        {
            while (true)
            {
                structs.GlowEffects Enemy = new structs.GlowEffects()
                {
                    _colorRed = 1,
                    _colorGreen = 1,
                    _colorBlue = 0,
                    _colorAlpha = 1,
                    rwo = true,
                    rwuo = true
                };
                structs.GlowEffects Team = new structs.GlowEffects()
                {
                    _colorRed = 0,
                    _colorGreen = 0,
                    _colorBlue = 0,
                    _colorAlpha = 0,
                    rwo = true,
                    rwuo = true
                };
                int address;
                int i = 1;

                do
                {
                    address = baseVars.GameClient + signatures.dwLocalPlayer;
                    int Player = baseVars.VAM.ReadInt32((IntPtr)address);
                    address = Player + netvars.m_iTeamNum;
                    int MyTeam = baseVars.VAM.ReadInt32((IntPtr)address);
                    address = baseVars.GameClient + signatures.dwEntityList + (i - 1) * 0x10;
                    int EntityList = baseVars.VAM.ReadInt32((IntPtr)address);
                    address = EntityList + netvars.m_iTeamNum;
                    int HisTeam = baseVars.VAM.ReadInt32((IntPtr)address);
                    address = EntityList + signatures.m_bDormant;

                    if (!baseVars.VAM.ReadBoolean((IntPtr)address))
                    {
                        address = EntityList + netvars.m_iGlowIndex;
                        int GlowIndex = baseVars.VAM.ReadInt32((IntPtr)address);

                        if (MyTeam == HisTeam)
                        {
                            address = baseVars.GameClient + signatures.dwGlowObjectManager;
                            int GlowObject = baseVars.VAM.ReadInt32((IntPtr)address);
                            int calculation = GlowIndex * 0x38 + 0x4;
                            int current = GlowObject + calculation;
                            baseVars.VAM.WriteFloat((IntPtr)current, Team._colorRed);

                            calculation = GlowIndex * 0x38 + 0x8;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteFloat((IntPtr)current, Team._colorGreen);

                            calculation = GlowIndex * 0x38 + 0xC;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteFloat((IntPtr)current, Team._colorBlue);

                            calculation = GlowIndex * 0x38 + 0x10;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteFloat((IntPtr)current, Team._colorAlpha);

                            calculation = GlowIndex * 0x38 + 0x24;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteBoolean((IntPtr)current, Team.rwo);

                            calculation = GlowIndex * 0x38 + 0x25;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteBoolean((IntPtr)current, Team.rwuo);
                        }
                        else
                        {
                            address = baseVars.GameClient + signatures.dwGlowObjectManager;
                            int GlowObject = baseVars.VAM.ReadInt32((IntPtr)address);
                            int calculation = GlowIndex * 0x38 + 0x4;
                            int current = GlowObject + calculation;
                            baseVars.VAM.WriteFloat((IntPtr)current, Enemy._colorRed);

                            calculation = GlowIndex * 0x38 + 0x8;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteFloat((IntPtr)current, Enemy._colorGreen);

                            calculation = GlowIndex * 0x38 + 0xC;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteFloat((IntPtr)current, Enemy._colorBlue);

                            calculation = GlowIndex * 0x38 + 0x10;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteFloat((IntPtr)current, Enemy._colorAlpha);

                            calculation = GlowIndex * 0x38 + 0x24;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteBoolean((IntPtr)current, Enemy.rwo);

                            calculation = GlowIndex * 0x38 + 0x25;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteBoolean((IntPtr)current, Enemy.rwuo);
                        }
                    }

                    i++;
                } while (i < 65);

                Thread.Sleep(10);
            }
        }
    }
}