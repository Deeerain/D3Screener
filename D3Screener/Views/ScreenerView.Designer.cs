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
            ImageList = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            startDelayInput = new TextBox();
            groupBox2 = new GroupBox();
            screenDelayInput = new TextBox();
            keyButtonSelector = new KeyButtonSelector();
            groupBox3 = new GroupBox();
            screenCountInput = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ImageList.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(ImageList, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
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
            flowLayoutPanel1.Location = new Point(137, 324);
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
            // ImageList
            // 
            ImageList.Controls.Add(groupBox1);
            ImageList.Controls.Add(groupBox2);
            ImageList.Controls.Add(keyButtonSelector);
            ImageList.Controls.Add(groupBox3);
            ImageList.Dock = DockStyle.Fill;
            ImageList.FlowDirection = FlowDirection.TopDown;
            ImageList.Location = new Point(3, 3);
            ImageList.Name = "ImageList";
            ImageList.Size = new Size(296, 315);
            ImageList.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(startDelayInput);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 47);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Задержка перед стартом (сек)";
            // 
            // startDelayInput
            // 
            startDelayInput.Dock = DockStyle.Fill;
            startDelayInput.Location = new Point(3, 19);
            startDelayInput.Name = "startDelayInput";
            startDelayInput.Size = new Size(284, 23);
            startDelayInput.TabIndex = 0;
            startDelayInput.Text = "0";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(screenDelayInput);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(3, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(290, 47);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Задержка между скриншотами (мсек)";
            // 
            // screenDelayInput
            // 
            screenDelayInput.Dock = DockStyle.Fill;
            screenDelayInput.Location = new Point(3, 19);
            screenDelayInput.Name = "screenDelayInput";
            screenDelayInput.Size = new Size(284, 23);
            screenDelayInput.TabIndex = 0;
            screenDelayInput.Text = "0";
            // 
            // keyButtonSelector
            // 
            keyButtonSelector.Lable = "Клавиша";
            keyButtonSelector.Location = new Point(3, 109);
            keyButtonSelector.Name = "keyButtonSelector";
            keyButtonSelector.SelectedItem = null;
            keyButtonSelector.Size = new Size(287, 54);
            keyButtonSelector.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(screenCountInput);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Location = new Point(3, 169);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(290, 47);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Количество скриншотов";
            // 
            // screenCountInput
            // 
            screenCountInput.Dock = DockStyle.Fill;
            screenCountInput.Location = new Point(3, 19);
            screenCountInput.Name = "screenCountInput";
            screenCountInput.Size = new Size(284, 23);
            screenCountInput.TabIndex = 0;
            screenCountInput.Text = "0";
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
            ImageList.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button takeScreenshotButton;
        private Button startScreenshoWorker;
        private FlowLayoutPanel ImageList;
        private GroupBox groupBox1;
        private TextBox startDelayInput;
        private GroupBox groupBox2;
        private TextBox screenDelayInput;
        private KeyButtonSelector keyButtonSelector;
        private GroupBox groupBox3;
        private TextBox screenCountInput;
    }
}
