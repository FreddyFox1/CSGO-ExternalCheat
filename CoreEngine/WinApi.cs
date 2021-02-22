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
    }
}
