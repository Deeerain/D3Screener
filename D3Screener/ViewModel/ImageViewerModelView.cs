using D3Screener.Infrastructure;
using D3Screener.Infrastructure.Commands;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows.Input;

namespace D3Screener.ViewModel
{
    public class ImageViewerModelView : NotifiedObject
    {
        private Uri? _selectedImage;
        private int _selectedImageIndex;

        public ObservableCollection<Uri?> Images { get; set; }

        public ImageViewerModelView()
        {
            Images = new ObservableCollection<Uri?>();
        }

        public Uri? SelectedImage
        {
            get => _selectedImage;
            set => SetProperty(ref _selectedImage, value);
        }

        public int SelectedImageIndex
        {
            get => _selectedImageIndex;
            set => SetProperty(ref _selectedImageIndex, value);
        }

        public ICommand NextImageCommand => new RelayCommand(NextImage, CanNextImage);

        public ICommand PreviousImageCommand => new RelayCommand(PreviousImage, CanPreviousImage);

        public ICommand DeleteImageCommand => new RelayCommand(DeleteImage, CanDeleteImage);

        private int GetImageCount()
        {
            return Images.Count;
        }

        private void NextImage(object? o)
        {
            SelectedImageIndex += 1;
        }

        private void PreviousImage(object? o)
        {
            SelectedImageIndex -= 1;
        }

        private bool CanNextImage(object? o)
        {
            return SelectedImageIndex < GetImageCount() - 1;
        }

        private bool CanPreviousImage(object? o)
        {
            return SelectedImageIndex > 0;
        }

        private void DeleteImage(object? o)
        {
            if (SelectedImage == null)
                return;

            var messageBoxDialogResult = MessageBox.Show("Вы уверены, что хотите удалить изображение", "Удаление", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            try
            {
                if (messageBoxDialogResult == DialogResult.OK)
                {
                    var filename = SelectedImage.LocalPath;
                    Images.Remove(SelectedImage);
                    File.Delete(filename);
                }
            }
            catch (FileNotFoundException) { }
            { 
                MessageBox.Show("Файл не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private bool CanDeleteImage(object? o)
        {
            return SelectedImage != null;
        }
    }
}
