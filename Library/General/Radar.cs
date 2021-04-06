using Engine.Globals;
using System;
using System.Threading;

namespace Engine.General
{
    public class Radar
    {
        /// <summary>
        /// Отображает вражеских игроков на радаре в приделах видимости клиента.
        /// Цикл ищет всех игроков с 1 по 12, если на сервере больше 12 игроков необходимо модифицировать класс...
        /// </summary>
        /// <param name="baseVars">Передает экземпляр ключевого класса, для работы с клиентов игры</param>
        public static void On(BaseVars baseVars)
        {
            int address, current;
            while (true)
            {
                for (int i = 1; i < 12; i++)
                {
                    address = baseVars.GameClient + signatures.dwEntityList + (i - 1) * 0x10;
                    int EntityList = baseVars.VAM.ReadMemory<Int32>(address);
                    bool dwCurrentEntity = baseVars.VAM.ReadMemory<bool>(EntityList);
                    if (dwCurrentEntity)
                    {
                        current = EntityList + Netvars.m_bSpotted;
                        baseVars.VAM.WriteMemory<bool>(current, true);
                    }
                }
                Thread.Sleep(250);
            }
        }
    }
}
