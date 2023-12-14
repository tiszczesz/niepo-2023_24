namespace cw6_WF
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbFirstname = new TextBox();
            tbLastname = new TextBox();
            tbAge = new TextBox();
            btnSave = new Button();
            lbResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(409, 50);
            label1.TabIndex = 0;
            label1.Text = "To jest okienko drugie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(75, 95);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 1;
            label2.Text = "Podaj imię:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 143);
            label3.Name = "label3";
            label3.Size = new Size(119, 21);
            label3.TabIndex = 2;
            label3.Text = "Podaj nazwisko:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(73, 191);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 3;
            label4.Text = "Podaj wiek:";
            // 
            // tbFirstname
            // 
            tbFirstname.Location = new Point(176, 97);
            tbFirstname.Name = "tbFirstname";
            tbFirstname.Size = new Size(208, 23);
            tbFirstname.TabIndex = 4;
            // 
            // tbLastname
            // 
            tbLastname.Location = new Point(176, 145);
            tbLastname.Name = "tbLastname";
            tbLastname.Size = new Size(208, 23);
            tbLastname.TabIndex = 5;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(176, 193);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(208, 23);
            tbAge.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(176, 241);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(208, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbResult
            // 
            lbResult.BackColor = SystemColors.GradientInactiveCaption;
            lbResult.BorderStyle = BorderStyle.FixedSingle;
            lbResult.Location = new Point(49, 323);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(335, 87);
            lbResult.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 452);
            Controls.Add(lbResult);
            Controls.Add(btnSave);
            Controls.Add(tbAge);
            Controls.Add(tbLastname);
            Controls.Add(tbFirstname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbFirstname;
        private TextBox tbLastname;
        private TextBox tbAge;
        private Button btnSave;
        private Label lbResult;
    }
}