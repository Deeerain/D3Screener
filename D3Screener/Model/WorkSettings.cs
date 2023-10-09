using D3Screener.Infrastructure;
using D3Screener.Properties;
using System.Collections.ObjectModel;

namespace D3Screener.Model
{
    public class WorkSettings: NotifiedObject
    {
        private int _startDelay;
        private int _screenshotDelay;
        private Keys _selectedKey;
        private int _screenCount;

        public ObservableCollection<Keys> Keys { get; set; }

        public WorkSettings()
        {
            Keys = new ObservableCollection<Keys>();

            foreach (var key in Enum.GetValues(typeof(Keys)))
                Keys.Add((Keys)key);
        }

        public int StartDelay
        {
            get => CustomSettings.Default.StartWorkDelay;
            set 
            {
                CustomSettings.Default.StartWorkDelay = value;
                SetProperty(ref _startDelay, value);
            }
        }

        public int ScreenshotDelay
        {
            get => CustomSettings.Default.ScreenDelay;
            set
            {
                CustomSettings.Default.ScreenDelay = value;
                SetProperty(ref _screenshotDelay, value);
            }
        }

        public Keys SelectedKey
        {
            get => CustomSettings.Default.KeyPressButton;
            set
            {
                CustomSettings.Default.KeyPressButton = value;
                SetProperty(ref _selectedKey, value);
            }
        }

        public int ScreenCount
        {
            get => CustomSettings.Default.ScreenCount;
            set
            {
                CustomSettings.Default.ScreenCount = value;
                SetProperty(ref _screenCount, value);
            }
        }

        public void Save() 
        {
            CustomSettings.Default.Save();
        }
    }
}
