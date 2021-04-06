using System;
using System.Collections.Generic;

namespace Engine.Globals
{
    public class OffsetDictionary
    {
        private Dictionary<string, Action> Offsets;

        /// <summary>
        /// Create Dictionary of offsets.
        /// Update NetVars and Signatures
        /// </summary>
        public OffsetDictionary()
        {
            //Initialize Dictionary
            Offsets = new Dictionary<string, Action>();
            //Create base class updater 
            OffsetUpdater updater = new OffsetUpdater();

            #region Netvars
            Offsets.Add("m_iTeamNum", () => updater.UpdateOffset("m_iTeamNum", ref Netvars.m_iTeamNum));
            Offsets.Add("m_flFlashMaxAlpha", () => updater.UpdateOffset("m_flFlashMaxAlpha", ref Netvars.m_flFlashMaxAlpha));
            Offsets.Add("m_fFlags", () => updater.UpdateOffset("m_fFlags", ref Netvars.m_fFlags));
            Offsets.Add("m_bSpotted", () => updater.UpdateOffset("m_bSpotted", ref Netvars.m_bSpotted));
            Offsets.Add("m_iGlowIndex", () => updater.UpdateOffset("m_iGlowIndex", ref Netvars.m_iGlowIndex));
            #endregion
            
            #region signatures
            Offsets.Add("dwForceJump", () => updater.UpdateOffset("dwForceJump", ref signatures.dwForceJump));
            Offsets.Add("dwLocalPlayer", () => updater.UpdateOffset("dwLocalPlayer", ref signatures.dwLocalPlayer));
            Offsets.Add("m_bDormant", () => updater.UpdateOffset("m_bDormant", ref signatures.m_bDormant));
            Offsets.Add("dwEntityList", () => updater.UpdateOffset("dwEntityList", ref signatures.dwEntityList));
            Offsets.Add("dwGlowObjectManager", () => updater.UpdateOffset("dwGlowObjectManager", ref signatures.dwGlowObjectManager));
            #endregion
            
            //Set offsets
            foreach (var Item in Offsets)
            {
                Offsets[Item.Key].Invoke();
            }
        }
    }
}
