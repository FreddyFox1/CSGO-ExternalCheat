using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Engine.Globals
{
    public class Memory : IMemory
    {
        private static Process m_Process;
        private static IntPtr m_pProcessHandle;
        private static int m_iNumberOfBytesRead = 0;
        private static int m_iNumberOfBytesWritten = 0;
        public Memory(string ProcessName)
        {
            if (Process.GetProcessesByName(ProcessName).Length > 0)
                m_Process = Process.GetProcessesByName(ProcessName)[0];
            else Environment.Exit(1);
            m_pProcessHandle = WinApi.OpenProcess(WinApi.PROCESS_VM_OPERATION | WinApi.PROCESS_VM_READ | WinApi.PROCESS_VM_WRITE, false, m_Process.Id); // Sets Our ProcessHandle
        }

        public T ReadMemory<T>(int Adress) where T : struct
        {
            // Get ByteSize Of DataType
            int ByteSize = Marshal.SizeOf(typeof(T));
            // Create A Buffer With Size Of ByteSize
            byte[] buffer = new byte[ByteSize];
            // Read Value From Memory
            WinApi.ReadProcessMemory((int)m_pProcessHandle, Adress, buffer, buffer.Length, ref m_iNumberOfBytesRead);
            // Transform the ByteArray to The Desired DataType
            return ByteArrayToStructure<T>(buffer);
        }

        public void WriteMemory<T>(int Adress, object Value) where T : struct
        {
            byte[] buffer = StructureToByteArray(Value);
            WinApi.WriteProcessMemory((int)m_pProcessHandle, Adress, buffer, buffer.Length, out m_iNumberOfBytesWritten);
        }

        /// <summary>
        /// Transform Data To ByteArray 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private static byte[] StructureToByteArray(object obj)
        {
            int length = Marshal.SizeOf(obj);
            byte[] arr = new byte[length];
            IntPtr ptr = Marshal.AllocHGlobal(length);
            Marshal.StructureToPtr(obj, ptr, true);
            Marshal.Copy(ptr, arr, 0, length);
            Marshal.FreeHGlobal(ptr);
            return arr;
        }

        private static T ByteArrayToStructure<T>(byte[] bytes) where T : struct
        {
            var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            try
            {
                return (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            }
            finally
            {
                handle.Free();
            }
        }
    }
}

