using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Globals
{

    public class Memory : IMemory
    {
        public Memory()
        {

        }

        public void ReadMemory<T>(int Adress)
        {
            throw new NotImplementedException();
        }

        public void WriteMemory<T>(int Adress, object Value)
        {
            throw new NotImplementedException();
        }
    }
}
