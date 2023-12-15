namespace cw7_WF
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
            panel1 = new Panel();
            btnExit = new Button();
            btnGener = new Button();
            label1 = new Label();
            tbSize = new TextBox();
            tbNumbers = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnGener);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbSize);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 598);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnExit.Location = new Point(28, 540);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(126, 46);
            btnExit.TabIndex = 3;
            btnExit.Text = "Zamknij";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnGener
            // 
            btnGener.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnGener.Location = new Point(28, 73);
            btnGener.Name = "btnGener";
            btnGener.Size = new Size(126, 46);
            btnGener.TabIndex = 2;
            btnGener.Text = "Generuj";
            btnGener.UseVisualStyleBackColor = true;
            btnGener.Click += btnGener_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 1;
            label1.Text = "Rozmiar tablicy:";
            // 
            // tbSize
            // 
            tbSize.Font = new Font("Segoe UI", 12F);
            tbSize.Location = new Point(28, 38);
            tbSize.Name = "tbSize";
            tbSize.Size = new Size(126, 29);
            tbSize.TabIndex = 0;
            // 
            // tbNumbers
            // 
            tbNumbers.Dock = DockStyle.Left;
            tbNumbers.Location = new Point(200, 0);
            tbNumbers.Multiline = true;
            tbNumbers.Name = "tbNumbers";
            tbNumbers.ScrollBars = ScrollBars.Vertical;
            tbNumbers.Size = new Size(128, 598);
            tbNumbers.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 598);
            Controls.Add(tbNumbers);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Główne okienko";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox tbNumbers;
        private TextBox tbSize;
        private Button btnExit;
        private Button btnGener;
        private Label label1;
    }
}
