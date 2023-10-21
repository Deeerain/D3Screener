using System.Drawing.Imaging;

namespace D3Screener.Infrastructure.ScreenerActions
{
    public class ScreenshotAction : IScreenerAction
    {
        private IScreenshotSaver _screenshotSaver;
        private string _path;
        private string _name;
        private ImageFormat _format;

        public ScreenshotAction(IScreenshotSaver screenshotSaver, string path, string name, ImageFormat format)
        {
            _screenshotSaver = screenshotSaver;
            _path = path;
            _name = name;
            _format = format;
        }

        public void Execute()
        {
            var bounds = Screen.GetBounds(Point.Empty);

            var btmp = new Bitmap(bounds.Width, bounds.Height);
            var g = Graphics.FromImage(btmp);
            g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
            _screenshotSaver.Save(btmp, _path, _name, _format);
        }
    }
}
