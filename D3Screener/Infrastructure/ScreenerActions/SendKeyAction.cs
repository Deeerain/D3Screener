using System.Runtime.InteropServices;

namespace D3Screener.Infrastructure.ScreenerActions
{
    internal class SendKeyAction : IScreenerAction
    {
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;

        private Keys _key;

        public SendKeyAction(Keys key)
        {
            _key = key;
        }

        public void Execute()
        {
            var hwnd = GetForegroundWindow();

            SendMessage(hwnd, WM_KEYDOWN, (int)_key, 1);
            SendMessage(hwnd, WM_KEYUP, (int)_key, 1);
        }

        [DllImport("user32.dll")]
        internal static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    }
}
