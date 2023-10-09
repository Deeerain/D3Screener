using D3Screener.ViewModel;
using System.IO;
using System.Windows;

namespace D3Screener.Views
{
    /// <summary>
    /// Логика взаимодействия для ImageViewer.xaml
    /// </summary>
    public partial class ImageViewer : Window
    {
        public ImageViewer(string folderPath)
        {
            InitializeComponent();
            var imageViewerModelView = new ImageViewerModelView();

            foreach(var image in Directory.GetFiles(folderPath))
            {
                imageViewerModelView.Images.Add(new Uri(image));
            }
            DataContext = imageViewerModelView;
        }
    }
}
