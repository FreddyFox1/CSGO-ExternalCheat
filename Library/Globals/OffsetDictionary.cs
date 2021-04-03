using System;
using System.Collections.Generic;

namespace Engine.Globals
{
    public class OffsetDictionary
    {
        public Dictionary<string, Int32> Offsets;

        /// <summary>
        /// Create Dictionary of offsets.
        /// Update NetVars and Signatures
        /// </summary>
        public OffsetDictionary()
        {
            #region NetVars
            Offsets.Add("m_fFlags", Netvars.m_fFlags);
            #endregion
            #region Signatures
            Offsets.Add("dwForceJump", signatures.dwForceJump);
            Offsets.Add("dwLocalPlayer", signatures.dwLocalPlayer);
            #endregion
            
            //Create base class updater 
            OffsetUpdater updater = new OffsetUpdater();
            //Set offsets
            foreach (var Item in Offsets)
            {
                updater.UpdateOffset(Item.Key, Item.Value);
            }
        }
    }
}
