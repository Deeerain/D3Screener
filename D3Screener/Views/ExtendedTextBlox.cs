using System.ComponentModel;

namespace D3Screener.Views
{
    public partial class ExtendedTextBlox : UserControl
    {
        [Browsable(true)]
        public new string Text
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        [Browsable(true)]
        public event EventHandler OtherButtonClick
        {
            add => otherButton.Click += value;
            remove => otherButton.Click -= value;
        }

        [Browsable(true)]
        public new event EventHandler TextChanged
        {
            add => textBox.TextChanged += value;
            remove => textBox.TextChanged -= value;
        }

        public ExtendedTextBlox()
        {
            InitializeComponent();
        }
    }
}
