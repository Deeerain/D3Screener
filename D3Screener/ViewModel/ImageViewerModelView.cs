using D3Screener.Infrastructure;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace D3Screener.ViewModel
{
    public class ImageViewerModelView: NotifiedObject
    {
        private Uri _selectedImage;

        public ObservableCollection<Uri> Images { get; set; }

        public Uri SelectedImage
        {
            get => _selectedImage;
            set => SetProperty(ref _selectedImage, value);
        }

        public ImageViewerModelView()
        {
            Images = new ObservableCollection<Uri>();
        }
    }
}
