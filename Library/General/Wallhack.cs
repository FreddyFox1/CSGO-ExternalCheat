using Engine.Globals;
using System;
using System.Drawing;
using System.Threading;

namespace Engine.General
{
    /// <summary>
    /// Simple wallhack with glow effect 
    /// </summary>
    public class Wallhack
    {
        /// <summary>
        /// Function without change color
        /// </summary>
        /// <param name="baseVars">BaseVars class</param>
        public static void On(BaseVars baseVars)
        {
            Structs.GlowEffects Enemy = new Structs.GlowEffects();
            Structs.GlowEffects Team = new Structs.GlowEffects()
            {
                colorAlpha = 0,
                colorBlue = 0,
                colorGreen = 0,
                colorRed = 0,
                rwo = false,
                rwuo = false
            };

            while (true)
            {
                int address;
                int i = 1;
                do
                {
                    address = baseVars.GameClient + signatures.dwLocalPlayer;
                    int Player = baseVars.VAM.ReadMemory<Int32>(address);
                    address = Player + Netvars.m_iTeamNum;
                    int MyTeam = baseVars.VAM.ReadMemory<Int32>(address);
                    address = baseVars.GameClient + signatures.dwEntityList + (i - 1) * 0x10;
                    int EntityList = baseVars.VAM.ReadMemory<Int32>(address);
                    address = EntityList + Netvars.m_iTeamNum;
                    int HisTeam = baseVars.VAM.ReadMemory<Int32>(address);
                    address = EntityList + signatures.m_bDormant;

                    if (!baseVars.VAM.ReadMemory<bool>(address))
                    {
                        address = EntityList + Netvars.m_iGlowIndex;
                        int GlowIndex = baseVars.VAM.ReadMemory<Int32>(address);

                        if (MyTeam == HisTeam)
                        {
                            address = baseVars.GameClient + signatures.dwGlowObjectManager;
                            int GlowObject = baseVars.VAM.ReadMemory<Int32>(address);
                            int calculation = GlowIndex * 0x38 + 0x4;
                            int current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<float>(current, Team.colorRed);

                            calculation = GlowIndex * 0x38 + 0x8;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<float>(current, Team.colorGreen);

                            calculation = GlowIndex * 0x38 + 0xC;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<float>(current, Team.colorBlue);

                            calculation = GlowIndex * 0x38 + 0x10;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<float>(current, Team.colorAlpha);

                            calculation = GlowIndex * 0x38 + 0x24;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<float>(current, Team.rwo);

                            calculation = GlowIndex * 0x38 + 0x25;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<bool>(current, Team.rwuo);
                        }
                        else
                        {
                            address = baseVars.GameClient + signatures.dwGlowObjectManager;
                            int GlowObject = baseVars.VAM.ReadMemory<Int32>(address);
                            int calculation = GlowIndex * 0x38 + 0x4;
                            int current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<float>(current, Enemy.colorRed);
                            calculation = GlowIndex * 0x38 + 0x8;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<float>(current, Enemy.colorGreen);
                            calculation = GlowIndex * 0x38 + 0xC;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<float>(current, Enemy.colorBlue);
                            calculation = GlowIndex * 0x38 + 0x10;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<float>(current, Enemy.colorAlpha);
                            calculation = GlowIndex * 0x38 + 0x24;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<bool>(current, Enemy.rwo);
                            calculation = GlowIndex * 0x38 + 0x25;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<bool>(current, Enemy.rwuo);
                        }

                    }
                    i++;
                }
                while (i < 65);
                Thread.Sleep(10);
            }
        }

        /// <summary>
        /// Function with custome color
        /// </summary>
        /// <param name="baseVars">BaseVars class</param>
        /// <param name="_Red">Color Red</param>
        /// <param name="_Green">Color Green</param>
        /// <param name="_Blue">Color blue</param>
        /// <param name="_Alpha">Color Alpha</param>
        public static void On(BaseVars baseVars, Color color)
        {
            Structs.GlowEffects Enemy = new Structs.GlowEffects()
            {
                colorRed = color.R,
                colorGreen = color.G,
                colorBlue = color.B,
                colorAlpha = color.A,
                rwo = true,
                rwuo = true
            };

            Structs.GlowEffects Team = new Structs.GlowEffects()
            {
                colorAlpha = 0,
                colorBlue = 0,
                colorGreen = 0,
                colorRed = 0,
                rwo = false,
                rwuo = false
            };
            while (true)
            {
                int address;
                int i = 1;
                do
                {
                    address = baseVars.GameClient + signatures.dwLocalPlayer;
                    int Player = baseVars.VAM.ReadMemory<Int32>(address);
                    address = Player + Netvars.m_iTeamNum;
                    int MyTeam = baseVars.VAM.ReadMemory<Int32>(address);
                    address = baseVars.GameClient + signatures.dwEntityList + (i - 1) * 0x10;
                    int EntityList = baseVars.VAM.ReadMemory<Int32>(address);
                    address = EntityList + Netvars.m_iTeamNum;
                    int HisTeam = baseVars.VAM.ReadMemory<Int32>(address);
                    address = EntityList + signatures.m_bDormant;

                    if (!baseVars.VAM.ReadMemory<bool>(address))
                    {
                        address = EntityList + Netvars.m_iGlowIndex;
                        int GlowIndex = baseVars.VAM.ReadMemory<Int32>(address);

                        if (MyTeam == HisTeam)
                        {
                            address = baseVars.GameClient + signatures.dwGlowObjectManager;
                            int GlowObject = baseVars.VAM.ReadMemory<Int32>(address);
                            int calculation = GlowIndex * 0x38 + 0x4;
                            int current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<float>(current, Team.colorRed);

                            calculation = GlowIndex * 0x38 + 0x8;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<float>(current, Team.colorGreen);

                            calculation = GlowIndex * 0x38 + 0xC;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<float>(current, Team.colorBlue);

                            calculation = GlowIndex * 0x38 + 0x10;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<float>(current, Team.colorAlpha);

                            calculation = GlowIndex * 0x38 + 0x24;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<float>(current, Team.rwo);

                            calculation = GlowIndex * 0x38 + 0x25;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<bool>(current, Team.rwuo);
                        }
                        else
                        {
                            address = baseVars.GameClient + signatures.dwGlowObjectManager;
                            int GlowObject = baseVars.VAM.ReadMemory<Int32>(address);
                            int calculation = GlowIndex * 0x38 + 0x4;
                            int current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<float>(current, Enemy.colorRed);
                            calculation = GlowIndex * 0x38 + 0x8;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<float>(current, Enemy.colorGreen);
                            calculation = GlowIndex * 0x38 + 0xC;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<float>(current, Enemy.colorBlue);
                            calculation = GlowIndex * 0x38 + 0x10;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<float>(current, Enemy.colorAlpha);
                            calculation = GlowIndex * 0x38 + 0x24;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<bool>(current, Enemy.rwo);
                            calculation = GlowIndex * 0x38 + 0x25;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteMemory<bool>(current, Enemy.rwuo);
                        }
                    }
                    i++;
                }
                while (i < 65);
                Thread.Sleep(10);
            }
        }
    }
}

