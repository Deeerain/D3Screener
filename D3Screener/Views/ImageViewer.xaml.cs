using D3Screener.ViewModel;
using System.Windows;

namespace D3Screener.Views
{
    /// <summary>
    /// Логика взаимодействия для ImageViewer.xaml
    /// </summary>
    public partial class ImageViewer : Window
    {
        public ImageViewer(Bitmap[] bitmas)
        {
            InitializeComponent();
            var imageViewerModelView = new ImageViewerModelView();

            foreach(var bitmap in bitmas)
            {
                imageViewerModelView.Images.Add(bitmap);
            }
            DataContext = imageViewerModelView;
        }
    }
}
