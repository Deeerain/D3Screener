using D3Screener.Properties;

namespace D3Screener.Views
{
    public partial class SettingsView : UserControl
    {
        public SettingsView()
        {
            InitializeComponent();
            propertyGrid1.SelectedObject = CustomSettings.Default;
            propertyGrid1.PropertyValueChanged += PropertyGrid1_PropertyValueChanged;
        }

        private void PropertyGrid1_PropertyValueChanged(object? s, PropertyValueChangedEventArgs e)
        {
            CustomSettings.Default.Save();
        }
    }
}
