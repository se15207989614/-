namespace CMSCWinFormsApp1
{
    partial class Form1
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
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            workerToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            jobToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(504, 223);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(473, 38);
            label1.TabIndex = 1;
            label1.Text = "Customer Maintenance System";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { workerToolStripMenuItem, customerToolStripMenuItem, jobToolStripMenuItem, reportsToolStripMenuItem, exitToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1924, 25);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // workerToolStripMenuItem
            // 
            workerToolStripMenuItem.Name = "workerToolStripMenuItem";
            workerToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.W;
            workerToolStripMenuItem.Size = new Size(64, 21);
            workerToolStripMenuItem.Text = "&Worker";
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            customerToolStripMenuItem.Size = new Size(76, 21);
            customerToolStripMenuItem.Text = "&Customer";
            // 
            // jobToolStripMenuItem
            // 
            jobToolStripMenuItem.Name = "jobToolStripMenuItem";
            jobToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.J;
            jobToolStripMenuItem.Size = new Size(84, 21);
            jobToolStripMenuItem.Text = "&Job Details";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(20, 21);
            toolStripMenuItem1.Text = "&";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.R;
            reportsToolStripMenuItem.Size = new Size(66, 21);
            reportsToolStripMenuItem.Text = "&Reports";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.X;
            exitToolStripMenuItem.Size = new Size(40, 21);
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1006);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(8, 7, 8, 7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem workerToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem jobToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}