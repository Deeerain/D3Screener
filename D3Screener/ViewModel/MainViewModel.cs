using D3Screener.Infrastructure;
using D3Screener.Infrastructure.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace D3Screener.ViewModel
{
    public class MainViewModel: NotifiedObject
    {
        private int _startDelay;
        private int _screenshotDelay;
        private Keys _selectedKey;
        private int _screenCount;

        public ObservableCollection<Keys> Keys { get; set; }

        public ICommand StartWorkCommand { get; set; }

        public MainViewModel()
        {
            Keys = new ObservableCollection<Keys>();

            foreach (Keys key in GetKeys())
                Keys.Add(key);

            StartWorkCommand = new RelayCommand(StartWork);
        }

        public int StartDelay
        {
            get => _startDelay;
            set => SetProperty(ref _startDelay, value);
        }

        public int ScreenshotDelay
        {
            get => _screenshotDelay;
            set => SetProperty(ref _screenshotDelay, value);
        }

        public Keys SelectedKey
        {
            get => _selectedKey;
            set => SetProperty(ref _selectedKey, value);
        }

        public int ScreenCount
        {
            get => _screenCount;
            set => SetProperty(ref _screenCount, value);
        }

        private Array GetKeys()
        {
            return Enum.GetValues(typeof(Keys));
        }

        private void StartWork(object? o)
        {
            MessageBox.Show("DSADSADa");
        }
    }
}
