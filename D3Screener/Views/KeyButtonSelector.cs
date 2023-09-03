namespace D3Screener.Views
{
    public partial class KeyButtonSelector : UserControl
    {
        public string Lable
        {
            get => gb.Text;
            set => gb.Text = value;
        }

        public ComboBox.ObjectCollection Items
        {
            get => comboBox1.Items;
        }

        public object SelectedItem
        {
            get => comboBox1.SelectedItem;
            set => comboBox1.SelectedItem = value;
        }

        public int SelecteIndex
        {
            get => comboBox1.SelectedIndex;
            set => comboBox1.SelectedIndex = value;
        }

        public KeyButtonSelector()
        {
            InitializeComponent();
        }
    }
}
