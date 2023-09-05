﻿using System.Runtime.InteropServices;

namespace D3Screener
{
    internal class Screener
    {
        private readonly int _startDelay;
        private readonly int _screenDelay;
        private readonly int _screenCount;
        private readonly Keys _key;

        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        private const int WM_CHAR = 0x0102;

        private readonly List<Bitmap> _bitmaps = new();

        public Screener(int startDelay, int screenDelay,int screenCount, Keys key)
        {
            _startDelay = startDelay;
            _screenDelay = screenDelay;
            _screenCount = screenCount;
            _key = key;
        }

        public void Start(Form mainWindow)
        {
            mainWindow.WindowState = FormWindowState.Minimized;
            Task.Delay(_startDelay).Wait();

            for(int i = 0; i < _screenCount; i++)
            {
                TakeScreenShot();

                SendKey(_key);

                Task.Delay(_screenDelay).Wait();

            }

            mainWindow.WindowState = FormWindowState.Normal;
        }

        private void TakeScreenShot()
        {
            var bounds = Screen.GetBounds(Point.Empty);

            var btmp = new Bitmap(bounds.Width, bounds.Height);
            var g = Graphics.FromImage(btmp);
            g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
            _bitmaps.Add(btmp);
        }

        public Bitmap[] GetBitmaps() => _bitmaps.ToArray();

        private void SendKey(Keys key)
        {
            var hwnd = GetForegroundWindow();

            SendMessage(hwnd, WM_KEYDOWN, (int)key, 1);
            SendMessage(hwnd, WM_KEYUP, (int)key, 1);
        }

        [DllImport("user32.dll")]
        internal static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern Int32 SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    }
}
