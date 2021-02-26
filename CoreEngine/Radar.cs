using System;
using System.Threading;

namespace CoreEngine
{
    public class Radar
    {
        /// <summary>
        /// Отображает вражеских игроков на радаре в приделах видимости клиента.
        /// Цикл ищет всех игроков с 1 по 12, если на сервере больше 12 игроков необходимо модифицировать класс...
        /// </summary>
        /// <param name="baseVars">Передает экземпляр ключевого класса, для работы с клиентов игры</param>
        public static void onRadarHack(BaseVars baseVars)
        {
            int address, current;
            while (true)
            {
                for (int i = 1; i < 12; i++)
                {
                    address = baseVars.GameClient + signatures.dwEntityList + (i - 1) * 0x10;
                    int EntityList = baseVars.VAM.ReadInt32((IntPtr)address);
                    bool dwCurrentEntity = baseVars.VAM.ReadBoolean((IntPtr)EntityList);
                    if (dwCurrentEntity)
                    {
                        current = EntityList + Netvars.m_bSpotted;
                        baseVars.VAM.WriteBoolean((IntPtr)current, true);
                    }
                }
                Thread.Sleep(250);
            }
        }
    }
}
