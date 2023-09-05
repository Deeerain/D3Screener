namespace D3Screener.Views
{
    partial class ScreenerView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            takeScreenshotButton = new Button();
            startScreenshoWorker = new Button();
            groupBox1 = new GroupBox();
            startDelayInput = new TextBox();
            groupBox2 = new GroupBox();
            screenDelayInput = new TextBox();
            keyButtonSelector = new KeyButtonSelector();
            groupBox3 = new GroupBox();
            screenCountInput = new TextBox();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(302, 356);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(takeScreenshotButton);
            flowLayoutPanel1.Controls.Add(startScreenshoWorker);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(137, 304);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(162, 29);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // takeScreenshotButton
            // 
            takeScreenshotButton.Location = new Point(3, 3);
            takeScreenshotButton.Name = "takeScreenshotButton";
            takeScreenshotButton.Size = new Size(75, 23);
            takeScreenshotButton.TabIndex = 0;
            takeScreenshotButton.Text = "Скриншот";
            takeScreenshotButton.UseVisualStyleBackColor = true;
            // 
            // startScreenshoWorker
            // 
            startScreenshoWorker.Location = new Point(84, 3);
            startScreenshoWorker.Name = "startScreenshoWorker";
            startScreenshoWorker.Size = new Size(75, 23);
            startScreenshoWorker.TabIndex = 1;
            startScreenshoWorker.Text = "Старт";
            startScreenshoWorker.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(startDelayInput);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 47);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Задержка перед стартом (сек)";
            // 
            // startDelayInput
            // 
            startDelayInput.Dock = DockStyle.Fill;
            startDelayInput.Location = new Point(3, 19);
            startDelayInput.Name = "startDelayInput";
            startDelayInput.Size = new Size(282, 23);
            startDelayInput.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(screenDelayInput);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(4, 51);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(288, 47);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Задержка между скриншотами (мсек)";
            // 
            // screenDelayInput
            // 
            screenDelayInput.Dock = DockStyle.Fill;
            screenDelayInput.Location = new Point(3, 19);
            screenDelayInput.Name = "screenDelayInput";
            screenDelayInput.Size = new Size(282, 23);
            screenDelayInput.TabIndex = 0;
            // 
            // keyButtonSelector
            // 
            keyButtonSelector.DataSource = null;
            keyButtonSelector.DisplayMember = "";
            keyButtonSelector.Dock = DockStyle.Top;
            keyButtonSelector.Lable = "Клавиша";
            keyButtonSelector.Location = new Point(4, 98);
            keyButtonSelector.Name = "keyButtonSelector";
            keyButtonSelector.SelectedItem = null;
            keyButtonSelector.SelecteIndex = -1;
            keyButtonSelector.Size = new Size(288, 54);
            keyButtonSelector.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(screenCountInput);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Location = new Point(4, 152);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(288, 47);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Количество скриншотов";
            // 
            // screenCountInput
            // 
            screenCountInput.Dock = DockStyle.Fill;
            screenCountInput.Location = new Point(3, 19);
            screenCountInput.Name = "screenCountInput";
            screenCountInput.Size = new Size(282, 23);
            screenCountInput.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(keyButtonSelector);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4);
            panel1.Size = new Size(296, 295);
            panel1.TabIndex = 4;
            // 
            // ScreenerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ScreenerView";
            Size = new Size(302, 356);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button takeScreenshotButton;
        private Button startScreenshoWorker;
        private GroupBox groupBox1;
        private TextBox startDelayInput;
        private GroupBox groupBox2;
        private TextBox screenDelayInput;
        private KeyButtonSelector keyButtonSelector;
        private GroupBox groupBox3;
        private TextBox screenCountInput;
        private Panel panel1;
    }
}
