using System.Windows;

namespace D3Screener
{
    public class App: System.Windows.Application
    {
        readonly MainWindow _mainWindow;

        public App(MainWindow mainWindow) 
        {
            this._mainWindow = mainWindow;


            var colorStyles = new ResourceDictionary()
            {
                Source = new Uri("/Styles/Colors.xaml", UriKind.Relative)
            };
            var buttonStyles = new ResourceDictionary()
            {
                Source = new Uri("/Styles/Buttons.xaml", UriKind.Relative)
            };

            var otherStyles = new ResourceDictionary()
            {
                Source = new Uri("/Styles/OtherControls.xaml", UriKind.Relative)
            };

            var styles = new ResourceDictionary();
            styles.MergedDictionaries.Add(colorStyles);
            styles.MergedDictionaries.Add(buttonStyles);
            styles.MergedDictionaries.Add(otherStyles);


            Resources = styles;
            _mainWindow.Show();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
        }
    }
}
