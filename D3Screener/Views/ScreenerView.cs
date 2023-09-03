using D3Screener.Properties;

namespace D3Screener.Views
{
    public partial class ScreenerView : UserControl
    {
        private readonly List<Bitmap> _bintamps = new();
        readonly Dictionary<object, string> _keys = new();

        public ScreenerView()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            startDelayInput.Text = CustomSettings.Default.StartDelay.ToString();

            takeScreenshotButton.Click += ScreshotButton_Click;
            var keys = Enum.GetValues(typeof(Keys));

            foreach (var key in keys)
            {
                try
                {
                    switch (key)
                    {
                        case Keys.PageUp:
                            _keys.Add(key, "{PGUP}");
                            break;
                        case Keys.PageDown:
                            _keys.Add(key, "{PGDN}");
                            break;
                        case Keys.Return:
                            _keys.Add(key, "{RETURN}");
                            break;
                        default:
                            _keys.Add(key, key.ToString());
                            break;
                    }
                }
                catch (ArgumentException e)
                {

                }
            }

            foreach (var key in _keys)
            {
                keyButtonSelector.Items.Add(key.Key);
            }

            keyButtonSelector.SelecteIndex = 1;

            startDelayInput.KeyPress += IntegerInputKeyPress;
            screenDelayInput.KeyPress += IntegerInputKeyPress;
            screenCountInput.KeyPress += IntegerInputKeyPress;
            startScreenshoWorker.Click += StartScreenshoWorker_Click;
        }

        public int StartDelay
        {
            get => int.Parse(startDelayInput.Text);
            set => startDelayInput.Text = value.ToString();
        }

        public int ScreenDelay
        {
            get => int.Parse(screenDelayInput.Text);
            set => screenDelayInput.Text = value.ToString();
        }

        public int ScreenCount
        {
            get => int.Parse(screenCountInput.Text);
            set => screenCountInput.Text = value.ToString();
        }

        private void ScreshotButton_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void StartScreenshoWorker_Click(object? sender, EventArgs e)
        {
            Program.MainForm.WindowState = FormWindowState.Minimized;
            Task.Delay(StartDelay).Wait();

            for (int i = 0; i < ScreenCount; i++)
            {
                TakeScreenshot();
                SendKeys.Send(_keys[keyButtonSelector.SelectedItem]);
                Task.Delay(ScreenDelay).Wait();
            }

            Program.MainForm.WindowState = FormWindowState.Normal;
        }

        private void IntegerInputKeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void ShowScreenshots_Click(object? sender, EventArgs e)
        {
            var form = new Form();
            form.ShowDialog();
        }

        private void TakeScreenshot()
        {
            var d = Screen.PrimaryScreen.Bounds;

            Rectangle rect = new(d.X, d.Y, d.Width, d.Height);

            Bitmap bmp = new(rect.Width, rect.Height,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);

            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size,
                CopyPixelOperation.SourceCopy);

            _bintamps.Add(bmp);
        }
    }

    /*
     * Ключ	Код
        BACKSPACE	{BACKSPACE}, {BS}или {BKSP}
        BREAK	{BREAK}
        CAPS LOCK	{CAPSLOCK}
        DEL или DELETE	{DELETE} или {DEL}
        СТРЕЛКА ВНИЗ	{DOWN}
        END	{END}
        ВВОД	{ВВОД} или ~
        ESC	{ESC}
        HELP	{HELP}
        HOME	{HOME}
        INS или INSERT	{INSERT} или {INS}
        СТРЕЛКА ВЛЕВО	{LEFT}
        NUM LOCK	{NUMLOCK}
        PAGE DOWN	{PGDN}
        PAGE UP	{PGUP}
        ЭКРАН ПЕЧАТИ	{PRTSC} (зарезервировано для дальнейшего использования)
        СТРЕЛКА ВПРАВО	{RIGHT}
        БЛОКИРОВКА ПРОКРУТКИ	{SCROLLLOCK}
        TAB	{TAB}
        СТРЕЛКА ВВЕРХ	{UP}
        F1	{F1}
        F2	{F2}
        F3	{F3}
        F4	{F4}
        F5	{F5}
        F6	{F6}
        F7	{F7}
        F8	{F8}
        F9	{F9}
        F10	{F10}
        F11	{F11}
        F12	{F12}
        F13	{F13}
        F14	{F14}
        F15	{F15}
        F16	{F16}
        Добавление клавиатуры	{ADD}
        Вычитание клавиатуры	{SUBTRACT}
        Умножение клавиатуры	{MULTIPLY}
        Разделение клавиатуры	{DIVIDE}
    Ключ	Код
        SHIFT	+
        CTRL	^
        ALT	%
     */
}
