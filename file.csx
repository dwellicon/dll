using System;
using System.Runtime.InteropServices;

namespace RedTeamPayload
{
    public class Launcher
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

        public static void Main()
        {
            MessageBox(IntPtr.Zero, "Hello, world!", "My Message Box", 0);
        }
    }
}
