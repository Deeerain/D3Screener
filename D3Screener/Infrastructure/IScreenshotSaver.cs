using System.Drawing.Imaging;

namespace D3Screener.Infrastructure
{
    public interface IScreenshotSaver
    {
        string Save(Bitmap bitmap, string path, string name, ImageFormat format);
        Task<string> SaveAsync(Bitmap bitmap, string path, string name, ImageFormat format);
    }
}