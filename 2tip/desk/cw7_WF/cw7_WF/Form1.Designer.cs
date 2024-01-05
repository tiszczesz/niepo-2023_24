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
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbCount = new Label();
            label2 = new Label();
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
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lbCount);
            panel1.Controls.Add(label2);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(135, 245);
            label7.Name = "label7";
            label7.Size = new Size(19, 21);
            label7.TabIndex = 11;
            label7.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(71, 245);
            label8.Name = "label8";
            label8.Size = new Size(42, 21);
            label8.TabIndex = 10;
            label8.Text = "Min:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(135, 211);
            label5.Name = "label5";
            label5.Size = new Size(19, 21);
            label5.TabIndex = 9;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(68, 211);
            label6.Name = "label6";
            label6.Size = new Size(45, 21);
            label6.TabIndex = 8;
            label6.Text = "Max:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(135, 177);
            label3.Name = "label3";
            label3.Size = new Size(19, 21);
            label3.TabIndex = 7;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(39, 177);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 6;
            label4.Text = "Parzyste:";
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbCount.Location = new Point(135, 143);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(19, 21);
            lbCount.TabIndex = 5;
            lbCount.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(28, 143);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 4;
            label2.Text = "Ilość liczb:";
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
        private Label lbCount;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label6;
    }
}
