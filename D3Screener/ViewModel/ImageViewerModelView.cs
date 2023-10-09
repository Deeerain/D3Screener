using D3Screener.Infrastructure;
using System.Collections.ObjectModel;

namespace D3Screener.ViewModel
{
    public class ImageViewerModelView: NotifiedObject
    {
        private Bitmap _selectedImage;

        public ObservableCollection<Bitmap> Images { get; set; }

        public Bitmap SelectedImage
        {
            get => _selectedImage;
            set => SetProperty(ref _selectedImage, value);
        }

        public ImageViewerModelView()
        {
            Images = new ObservableCollection<Bitmap>();
        }
    }
}
