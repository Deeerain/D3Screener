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
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            ImageList.Dock = DockStyle.Fill;
            ImageList.Location = new Point(3, 3);
            ImageList.Name = "ImageList";
            ImageList.Size = new Size(296, 315);
            ImageList.TabIndex = 1;
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button takeScreenshotButton;
        private Button startScreenshoWorker;
        private FlowLayoutPanel ImageList;
    }
}
