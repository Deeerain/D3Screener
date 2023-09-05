using D3Screener.Properties;
using System.Runtime.CompilerServices;

namespace D3Screener
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            screenerView1.StartButtonClick += ScreenerView1_StartButtonClick;
            Load += MainForm_Load;
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            LoadLastValues();
        }

        private void ScreenerView1_StartButtonClick(object? sender, EventArgs e)
        {
            CustomSettings.Default.Save();

            var screener = new Screener(
                screenerView1.StartDelay,
                screenerView1.ScreenDelay,
                screenerView1.ScreenCount,
                screenerView1.SelectedButton);

            screener.Start(Program.MainForm);

            var saver = new ScreenshotSaver(CustomSettings.Default.SaveFolderPath, screener.GetBitmaps());
            saver.Save();

            SaveLastValues();
        }

        private void SaveLastValues()
        {
            CustomSettings.Default.StartWorkDelay = screenerView1.StartDelay;
            CustomSettings.Default.ScreenDelay = screenerView1.ScreenDelay;
            CustomSettings.Default.ScreenCount = screenerView1.ScreenCount;
            CustomSettings.Default.KeyPressButton = screenerView1.SelectedButton;
        }

        private void LoadLastValues()
        {
            screenerView1.DataSource = Enum.GetValues(typeof(Keys));
            screenerView1.StartDelay = CustomSettings.Default.StartWorkDelay;
            screenerView1.ScreenDelay = CustomSettings.Default.ScreenDelay;
            screenerView1.ScreenCount = CustomSettings.Default.ScreenCount;
            screenerView1.SelectedButton = CustomSettings.Default.KeyPressButton;
        }
    }
}