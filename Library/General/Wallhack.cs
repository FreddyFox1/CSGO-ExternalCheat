using Engine.Globals;
using System;
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
            while (true)
            {
                Structs.GlowEffects Enemy = new Structs.GlowEffects();
                int address;
                int i = 1;
                do
                {
                    address = baseVars.GameClient + signatures.dwLocalPlayer;
                    int Player = baseVars.VAM.ReadInt32((IntPtr)address);
                    address = Player + Netvars.m_iTeamNum;
                    int MyTeam = baseVars.VAM.ReadInt32((IntPtr)address);
                    address = baseVars.GameClient + signatures.dwEntityList + (i - 1) * 0x10;
                    int EntityList = baseVars.VAM.ReadInt32((IntPtr)address);
                    address = EntityList + Netvars.m_iTeamNum;
                    int HisTeam = baseVars.VAM.ReadInt32((IntPtr)address);
                    address = EntityList + signatures.m_bDormant;

                    if (!baseVars.VAM.ReadBoolean((IntPtr)address))
                    {
                        address = EntityList + Netvars.m_iGlowIndex;
                        int GlowIndex = baseVars.VAM.ReadInt32((IntPtr)address);

                        if (MyTeam != HisTeam)
                        {
                            address = baseVars.GameClient + signatures.dwGlowObjectManager;
                            int GlowObject = baseVars.VAM.ReadInt32((IntPtr)address);
                            int calculation = GlowIndex * 0x38 + 0x4;
                            int current = GlowObject + calculation;
                            baseVars.VAM.WriteFloat((IntPtr)current, Enemy.colorRed);

                            calculation = GlowIndex * 0x38 + 0x8;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteFloat((IntPtr)current, Enemy.colorGreen);

                            calculation = GlowIndex * 0x38 + 0xC;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteFloat((IntPtr)current, Enemy.colorBlue);

                            calculation = GlowIndex * 0x38 + 0x10;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteFloat((IntPtr)current, Enemy.colorAlpha);

                            calculation = GlowIndex * 0x38 + 0x24;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteBoolean((IntPtr)current, Enemy.rwo);

                            calculation = GlowIndex * 0x38 + 0x25;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteBoolean((IntPtr)current, Enemy.rwuo);
                        }
                        i++;
                    }
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
        public static void On(BaseVars baseVars, float _Red, float _Green, float _Blue, float _Alpha)
        {
            while (true)
            {
                Structs.GlowEffects Enemy = new Structs.GlowEffects()
                {
                    colorRed = _Red,
                    colorGreen = _Green,
                    colorBlue = _Blue,
                    colorAlpha = _Alpha,
                    rwo = true,
                    rwuo = true
                };
                int address;
                int i = 1;

                do
                {
                    address = baseVars.GameClient + signatures.dwLocalPlayer;
                    int Player = baseVars.VAM.ReadInt32((IntPtr)address);
                    address = Player + Netvars.m_iTeamNum;
                    int MyTeam = baseVars.VAM.ReadInt32((IntPtr)address);
                    address = baseVars.GameClient + signatures.dwEntityList + (i - 1) * 0x10;
                    int EntityList = baseVars.VAM.ReadInt32((IntPtr)address);
                    address = EntityList + Netvars.m_iTeamNum;
                    int HisTeam = baseVars.VAM.ReadInt32((IntPtr)address);
                    address = EntityList + signatures.m_bDormant;

                    if (!baseVars.VAM.ReadBoolean((IntPtr)address))
                    {
                        address = EntityList + Netvars.m_iGlowIndex;
                        int GlowIndex = baseVars.VAM.ReadInt32((IntPtr)address);

                        if (MyTeam != HisTeam)
                        {
                            address = baseVars.GameClient + signatures.dwGlowObjectManager;
                            int GlowObject = baseVars.VAM.ReadInt32((IntPtr)address);
                            int calculation = GlowIndex * 0x38 + 0x4;
                            int current = GlowObject + calculation;
                            baseVars.VAM.WriteFloat((IntPtr)current, Enemy.colorRed);

                            calculation = GlowIndex * 0x38 + 0x8;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteFloat((IntPtr)current, Enemy.colorGreen);

                            calculation = GlowIndex * 0x38 + 0xC;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteFloat((IntPtr)current, Enemy.colorBlue);

                            calculation = GlowIndex * 0x38 + 0x10;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteFloat((IntPtr)current, Enemy.colorAlpha);

                            calculation = GlowIndex * 0x38 + 0x24;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteBoolean((IntPtr)current, Enemy.rwo);

                            calculation = GlowIndex * 0x38 + 0x25;
                            current = GlowObject + calculation;
                            baseVars.VAM.WriteBoolean((IntPtr)current, Enemy.rwuo);
                        }
                        i++;
                    }
                }
                while (i < 65);
                Thread.Sleep(10);
            }
        }
    }
}

