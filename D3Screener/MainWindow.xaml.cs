using D3Screener.Properties;
using D3Screener.Views;
using System.IO;
using System.Windows;

namespace D3Screener
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Width = 400;
            Height = 500;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Topmost = true;

            Loaded += MainWindow_Loaded;
            startButton.Click += StartButton_Click;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {

            CustomSettings.Default.Save();

            var screener = new Screener(
                int.Parse(startDelayInput.Text),
                int.Parse(screenshotDelayInput.Text),
                int.Parse(screenshotCountInput.Text),
                (Keys)keyInput.SelectedItem);

            screener.Start(App.Current.MainWindow);

            var saveFolderPath = CustomSettings.Default.SaveFolderPath;

            if (saveFolderPath == null)
                saveFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            var saver = new ScreenshotSaver(saveFolderPath, screener.GetBitmaps());
            saver.Save();

            SaveLastValues();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            LoadLastValues();
        }

        private void LoadLastValues()
        {
            keyInput.ItemsSource = Enum.GetValues(typeof(Keys));
            startDelayInput.Text = CustomSettings.Default.StartWorkDelay.ToString();
            screenshotDelayInput.Text = CustomSettings.Default.ScreenDelay.ToString();
            screenshotCountInput.Text = CustomSettings.Default.ScreenCount.ToString();
            keyInput.Text = CustomSettings.Default.KeyPressButton.ToString();
        }
        private void SaveLastValues()
        {
            CustomSettings.Default.StartWorkDelay = int.Parse(startDelayInput.Text);
            CustomSettings.Default.ScreenDelay = int.Parse(screenshotDelayInput.Text);
            CustomSettings.Default.ScreenCount = int.Parse(screenshotCountInput.Text);
            CustomSettings.Default.KeyPressButton = (Keys)keyInput.SelectedItem;
        }

    }
}
