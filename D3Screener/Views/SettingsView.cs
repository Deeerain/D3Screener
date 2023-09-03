using D3Screener.Properties;

namespace D3Screener.Views
{
    public partial class SettingsView : UserControl
    {
        public SettingsView()
        {
            InitializeComponent();

            Load += SettingsView_Load;
            saveButton.Click += SaveButton_Click;
            extendedTextBlox1.OtherButtonClick += ExtendedTextBlox1_Click;
            Settings.Default.SettingChanging += Default_SettingChanging; ;
        }

        private void Default_SettingChanging(object sender, System.Configuration.SettingChangingEventArgs e)
        {
            ReloadSettings();
        }

        private void ExtendedTextBlox1_Click(object? sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            var dialogResult = folderDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Settings.Default.saveFolderPath = folderDialog.SelectedPath;
            }
        }

        private void SettingsView_Load(object? sender, EventArgs e)
        {
            ReloadSettings();
        }
        private void SaveButton_Click(object? sender, EventArgs e)
        {
            try
            {
                Settings.Default.Save();
                MessageBox.Show("Настройки успешно сохранены");
            }
            catch (Exception expection)
            {
                MessageBox.Show(expection.Message);
            }
        }

        private void ReloadSettings()
        {
            extendedTextBlox1.Text = Settings.Default.saveFolderPath;
        }
    }
}
