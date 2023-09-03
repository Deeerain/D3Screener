namespace D3Screener.Views
{
    public partial class ScreenerView : UserControl
    {
        private Screener _screener;

        public ScreenerView()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            _screener = new Screener();

            takeScreenshotButton.Click += ScreshotButton_Click;
        }

        private void ShowScreenshots_Click(object? sender, EventArgs e)
        {
            var form = new Form();
            form.ShowDialog();
        }

        private void ScreshotButton_Click(object? sender, EventArgs e)
        {

            var screenContainer = Screen.PrimaryScreen.Bounds;

            var screenshot = _screener.TakeScreenshot(new Point(0, 0), new Point(screenContainer.Width, screenContainer.Height));
        }
    }
}
