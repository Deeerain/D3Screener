namespace D3Screener.Views
{
    partial class KeyButtonSelector
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
            gb = new GroupBox();
            comboBox1 = new ComboBox();
            gb.SuspendLayout();
            SuspendLayout();
            // 
            // gb
            // 
            gb.AutoSize = true;
            gb.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gb.Controls.Add(comboBox1);
            gb.Dock = DockStyle.Fill;
            gb.Location = new Point(0, 0);
            gb.Name = "gb";
            gb.Padding = new Padding(5);
            gb.Size = new Size(247, 57);
            gb.TabIndex = 0;
            gb.TabStop = false;
            gb.Text = "groupBox1";
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(5, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(237, 23);
            comboBox1.TabIndex = 0;
            // 
            // KeyButtonSelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gb);
            Name = "KeyButtonSelector";
            Size = new Size(247, 57);
            gb.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb;
        private ComboBox comboBox1;
    }
}
