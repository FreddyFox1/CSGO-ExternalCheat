using Engine.Globals;
using System;
using System.Threading;

namespace Engine.General
{
    /// <summary>
    /// Отключаем эффект от ослепляющей гранаты
    /// </summary>
    public class NoFlash
    {
        public static void OnNoFlash(BaseVars baseVars)
        {
            float Antivirus = 0;
            while (true)
            {
                int? PModel = baseVars.VAM.ReadInt32((IntPtr)baseVars.GameClient + signatures.dwLocalPlayer);
                if (PModel != null)
                {
                    var PModelValueF = PModel + Netvars.m_flFlashMaxAlpha;
                    if (PModelValueF != null)
                    {
                        baseVars.VAM.WriteFloat((IntPtr)PModelValueF, Antivirus);
                    }
                }
                Thread.Sleep(300);
            }
        }
    }
}
