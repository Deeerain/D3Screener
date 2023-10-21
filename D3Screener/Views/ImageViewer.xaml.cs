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
        public string FolderPath { get; set; }

        private ImageViewerModelView _imageModelView;

        public ImageViewer()
        {
            InitializeComponent();

            _imageModelView = new ImageViewerModelView();
            DataContext = _imageModelView;

            Loaded += ImageViewer_Loaded;

        }

        private void ImageViewer_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var image in Directory.GetFiles(FolderPath))
            {
                _imageModelView.Images.Add(new Uri(image));
            }
        }
    }
}
