using D3Screener.Infrastructure.Utils;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;

namespace D3Screener.Infrastructure
{
    internal class Screener: IDisposable
    {
        private readonly int _startDelay;
        private readonly int _screenDelay;
        private readonly int _screenCount;
        private readonly Keys _key;
        private IScreenshotSaver _screenshotSaver;

        private string _lastTempFolder;

        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;

        private readonly List<Bitmap> _bitmaps = new();

        public Screener(int startDelay, int screenDelay, int screenCount, Keys key, IScreenshotSaver saver)
        {
            _startDelay = startDelay;
            _screenDelay = screenDelay;
            _screenCount = screenCount;
            _key = key;
            _screenshotSaver = saver;
        }

        public string LastTempFolderPath => _lastTempFolder;

        public async Task Start(Window mainWindow)
        {
            var nowTime = DateTime.Now;
            _lastTempFolder = Path.Combine(PathUtils.GetTemplateFolderPathByAssembly(), nowTime.ToFileTime().ToString());

            if (!Directory.Exists(_lastTempFolder))
                Directory.CreateDirectory(_lastTempFolder);

            Task.Delay(_startDelay).Wait();

            for (int i = 0; i < _screenCount; i++)
            {
                var screenshot = TakeScreenShot();

                await _screenshotSaver.SaveAsync(screenshot, _lastTempFolder, 
                    DateTime.Now.ToFileTime().ToString(), ImageFormat.Jpeg) ;

                SendKey(_key);

                Task.Delay(_screenDelay).Wait();

            }
        }

        private Bitmap TakeScreenShot()
        {
            var bounds = Screen.GetBounds(System.Drawing.Point.Empty);

            var btmp = new Bitmap(bounds.Width, bounds.Height);
            var g = Graphics.FromImage(btmp);
            g.CopyFromScreen(System.Drawing.Point.Empty, System.Drawing.Point.Empty, bounds.Size);
            return btmp;
        }

        private void SendKey(Keys key)
        {
            var hwnd = GetForegroundWindow();

            SendMessage(hwnd, WM_KEYDOWN, (int)key, 1);
            SendMessage(hwnd, WM_KEYUP, (int)key, 1);
        }

        [DllImport("user32.dll")]
        internal static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public void Dispose()
        {
            _bitmaps.Clear();
        }
    }
}
