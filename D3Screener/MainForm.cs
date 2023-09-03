using D3Screener.Views;

namespace D3Screener
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Text = Application.ProductName;

            var screenerView = new ScreenerView()
            {
                Dock = DockStyle.Fill,
            };
            var settingsView = new SettingsView()
            {
                Dock = DockStyle.Fill,
            };

            mainTabPage.Controls.Add(screenerView);
            settingsTabPage.Controls.Add(settingsView);
        }
    }
}