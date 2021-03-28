using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CoreEngine
{
    public class WinApi
    {
        //Проверка нажатие клавиши
        [DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetAsyncKeyState(int vKey);

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        ////Для Overlay
        //[DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        //public static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        //[DllImport("user32.dll")]
        //public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        //[DllImport("user32.dll", SetLastError = true)]
        //public static extern int GetWindowLong(IntPtr window, int index);
        //public static IntPtr handle = FindWindowByCaption(IntPtr.Zero, BaseVar.gameProcess);

        //[DllImport("user32.dll")]
        //public static extern IntPtr GetForegroundWindow();

        //[DllImport("user32.dll", SetLastError = true)]
        //public static extern bool GetWindowRect(IntPtr hwnd, out str.RECT lpRect);

        //События мыши
        [DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        //Нажатие на левую кнопку мыши
        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        //Поднятие левой кнопки мыши
        public const int MOUSEEVENTF_LEFTUP = 0x0004;

        [StructLayout(LayoutKind.Sequential)]
        public struct MouseInput
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct HardwareInput
        {
            public uint uMsg;
            public ushort wParamL;
            public ushort wParamH;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct InputUnion
        {
            [FieldOffset(0)] public MouseInput mi;
            [FieldOffset(0)] public HardwareInput hi;
        }
        [Flags]
        public enum InputType
        {
            Mouse = 0,
            Keyboard = 1,
            Hardware = 2
        }
        [Flags]
        public enum MouseEventF
        {
            Absolute = 0x8000,
            HWheel = 0x01000,
            Move = 0x0001,
            MoveNoCoalesce = 0x2000,
            LeftDown = 0x0002,
            LeftUp = 0x0004,
            RightDown = 0x0008,
            RightUp = 0x0010,
            MiddleDown = 0x0020,
            MiddleUp = 0x0040,
            VirtualDesk = 0x4000,
            Wheel = 0x0800,
            XDown = 0x0080,
            XUp = 0x0100
        }
        public struct Input
        {
            public int type;
            public InputUnion u;
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint SendInput(uint nInputs, Input[] pInputs, int cbSize);
        [DllImport("user32.dll")]
        public static extern IntPtr GetMessageExtraInfo();


    }
}
