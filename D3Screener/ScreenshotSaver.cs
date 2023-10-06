using System.Drawing.Imaging;
using System.IO;

namespace D3Screener
{
    internal class ScreenshotSaver
    {
        private string _saveFolderPath;
        private Bitmap[] _bitmaps;

        public ScreenshotSaver(string saveFolderPath, Bitmap[] bitmaps)
        {
            _saveFolderPath = saveFolderPath;
            _bitmaps = bitmaps;
        }

        public void Save()
        {
            var date = DateTime.Now;
            var fullSavePath = Path.Combine(_saveFolderPath, date.ToString("%d%M%y%H%m"));
            var format = ImageFormat.Png;


            if (!Directory.Exists(fullSavePath))
                Directory.CreateDirectory(fullSavePath);
            try
            {
                for (int i = 0; i < _bitmaps.Length; i++)
                {
                    var fileName = $"scr_{i}.{format.ToString().ToLower()}";
                    var savePath = Path.Combine(fullSavePath, fileName);



                    using var f = File.OpenWrite(savePath);
                    _bitmaps[i].Save(f, format);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Directory.Delete(fullSavePath, true);
            }
        }
    }
}
