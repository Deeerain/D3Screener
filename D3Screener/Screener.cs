namespace D3Screener
{
    internal class Screener
    {
        public Bitmap TakeScreenshot(Point position, Point size)
        {
            Rectangle rect = new(position.X, position.Y, size.X, size.Y);

            Bitmap bmp = new(rect.Width, rect.Height,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);

            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size,
                CopyPixelOperation.SourceCopy);

            return bmp;
        }
    }
}
