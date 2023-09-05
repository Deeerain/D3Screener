using D3Screener.Properties;
using System.Security.Policy;

namespace D3Screener.Views
{
    public partial class ScreenerView : UserControl
    {
        public event EventHandler? InputChanged;

        public event EventHandler? SelectedKeyChanged;

        public event EventHandler? StartButtonClick;

        public ScreenerView()
        {
            InitializeComponent();

            startDelayInput.TextChanged += InputTextChanged;
            screenDelayInput.TextChanged += InputTextChanged;
            screenCountInput.TextChanged += InputTextChanged;

            startDelayInput.KeyPress += OnInputKeyDown;
            screenDelayInput.KeyPress += OnInputKeyDown;
            screenCountInput.KeyPress += OnInputKeyDown;
            screenCountInput.Validating += ScreenCountInput_Validating;

            startScreenshoWorker.Click += StartScreenshoWorker_Click;
        }

        private void ScreenCountInput_Validating(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            var control = sender as TextBox;

            if (control == null)
                return;

            if (int.Parse(control.Text) == 0)
                e.Cancel = true;
        }

        private void OnInputKeyDown(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void StartScreenshoWorker_Click(object? sender, EventArgs e)
        {
            StartButtonClick?.Invoke(sender, e);
        }

        private void InputTextChanged(object? sender, EventArgs e)
        {
            if (sender == null)
                return;

            if (((TextBox)sender).Text == "")
                ((TextBox)sender).Text = 0.ToString();

            InputChanged?.Invoke(sender, e);
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

        public Keys SelectedButton
        {
            get => (Keys)keyButtonSelector.SelectedItem;
            set => keyButtonSelector.SelectedItem = value;
        }

        public ComboBox.ObjectCollection KeyItems
        {
            get => keyButtonSelector.Items;
        }

        public object DataSource
        {
            get => keyButtonSelector.DataSource;
            set => keyButtonSelector.DataSource = value;
        }

        public string DisplayMember
        {
            get => keyButtonSelector.DisplayMember;
            set => keyButtonSelector.DisplayMember = value;
        }
    }
}
