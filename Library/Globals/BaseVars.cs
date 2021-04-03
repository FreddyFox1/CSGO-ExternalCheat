using System;
using System.Diagnostics;

namespace Engine.Globals
{
    public class BaseVars
    {
        //Process name
        private static string gameProcess;
        //Adress game client
        private static int gameClient;
        // Memory R/W methods lib  
        private static VAMemory vam;
        
        public string GameProcess
        {
            get
            {
                return gameProcess;
            }
        }
        public int GameClient
        {
            get
            {
                return gameClient;
            }
        }
        public VAMemory VAM
        {
            get
            {
                return vam;
            }
        }

        public BaseVars(string _gameProcess)
        {
            gameProcess = _gameProcess;
            gameClient = GetModuleAddress();
            vam = new VAMemory(gameProcess);
        }

        private static int GetModuleAddress()
        {
            try
            {
                Process[] p = Process.GetProcessesByName(gameProcess);
                if (p.Length > 0)
                {
                    foreach (ProcessModule m in p[0].Modules)
                    {
                        //Later need change to panorama_client.dll
                        if (m.ModuleName == "client.dll")
                        {
                            gameClient = (int)m.BaseAddress;
                            return gameClient;
                        }
                    }
                    return 0;
                }
                else
                {
                    Console.WriteLine("Not found.");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
        }


    }
}
