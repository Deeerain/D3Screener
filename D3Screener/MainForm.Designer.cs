namespace D3Screener
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusBar = new StatusStrip();
            tabControl1 = new TabControl();
            mainTabPage = new TabPage();
            settingsTabPage = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // statusBar
            // 
            statusBar.Location = new Point(0, 428);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(331, 22);
            statusBar.TabIndex = 0;
            statusBar.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(mainTabPage);
            tabControl1.Controls.Add(settingsTabPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(331, 428);
            tabControl1.TabIndex = 1;
            // 
            // mainTabPage
            // 
            mainTabPage.Location = new Point(4, 24);
            mainTabPage.Name = "mainTabPage";
            mainTabPage.Padding = new Padding(3);
            mainTabPage.Size = new Size(323, 400);
            mainTabPage.TabIndex = 0;
            mainTabPage.Text = "Главная";
            mainTabPage.UseVisualStyleBackColor = true;
            // 
            // settingsTabPage
            // 
            settingsTabPage.Location = new Point(4, 24);
            settingsTabPage.Name = "settingsTabPage";
            settingsTabPage.Padding = new Padding(3);
            settingsTabPage.Size = new Size(323, 400);
            settingsTabPage.TabIndex = 1;
            settingsTabPage.Text = "Настройки";
            settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 450);
            Controls.Add(tabControl1);
            Controls.Add(statusBar);
            Name = "MainForm";
            Text = "D3Screener";
            TopMost = true;
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusBar;
        private TabControl tabControl1;
        private TabPage mainTabPage;
        private TabPage settingsTabPage;
    }
}