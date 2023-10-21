using System.Drawing.Imaging;
using System.IO;

namespace D3Screener.Infrastructure
{
    public class DefaultScreenshotSaver : IScreenshotSaver
    {
        public string Save(Bitmap bitmap, string path, string name, ImageFormat format)
        {
            var fullPath = Path.Combine(path, name);

            bitmap.Save(fullPath, format);

            return fullPath;
        }

        public async Task<string> SaveAsync(Bitmap bitmap, string path, string name, ImageFormat format)
        {
            return await Task.Run(() => Save(bitmap, path, name, format));
        }
    }
}
