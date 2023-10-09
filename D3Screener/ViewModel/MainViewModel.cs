using D3Screener.Infrastructure;
using D3Screener.Infrastructure.Commands;
using D3Screener.Model;
using D3Screener.Views;
using System.Windows.Input;

namespace D3Screener.ViewModel
{
    public class MainViewModel: NotifiedObject
    {
        private WorkSettings _model;
        public ICommand StartWorkCommand { get; set; }

        public MainViewModel()
        {
            _model = new WorkSettings();

            StartWorkCommand = new RelayCommand(StartWork);
        }

        public int StartDelay
        {
            get => _model.StartDelay;
            set => _model.StartDelay = value;
        }

        public int ScreenshotDelay
        {
            get => _model.ScreenshotDelay;
            set => _model.ScreenshotDelay = value;
        }

        public Keys SelectedKey
        {
            get => _model.SelectedKey;
            set => _model.SelectedKey = value;
        }

        public int ScreenCount
        {
            get => _model.ScreenCount;
            set => _model.ScreenCount = value;
        }

        private void StartWork(object? o)
        {
            _model.Save();
            var screener = new Screener(StartDelay, ScreenshotDelay, ScreenCount, SelectedKey);
            screener.Start(App.Current.MainWindow);
            var window = new ImageViewer(screener.GetBitmaps());
            window.ShowDialog();
        }
    }
}
