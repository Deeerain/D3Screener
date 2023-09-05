namespace D3Screener.Views
{
    public partial class KeyButtonSelector : UserControl
    {
        public KeyButtonSelector()
        {
            InitializeComponent();
            comboBox1.SelectedValueChanged += ComboBox1_SelectedValueChanged;
        }

        private void ComboBox1_SelectedValueChanged(object? sender, EventArgs e)
        {
            SelectedValueChanged?.Invoke(this, e);
        }

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

        public object DataSource
        {
            get => comboBox1.DataSource;
            set => comboBox1.DataSource = value;
        }

        public string DisplayMember
        {
            get => comboBox1.DisplayMember;
            set => comboBox1.DisplayMember = value;
        }

        public event EventHandler? SelectedValueChanged;
    }
}
