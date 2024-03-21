namespace cw1WinForms
{
    partial class FormAdd
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
            tbFirstname = new TextBox();
            tbLastname = new TextBox();
            btnCancel = new Button();
            tbAge = new NumericUpDown();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)tbAge).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 31);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Podaj imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 85);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Podaj nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 139);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Podaj wiek";
            // 
            // tbFirstname
            // 
            tbFirstname.Location = new Point(167, 28);
            tbFirstname.Name = "tbFirstname";
            tbFirstname.Size = new Size(120, 23);
            tbFirstname.TabIndex = 3;
            // 
            // tbLastname
            // 
            tbLastname.Location = new Point(167, 82);
            tbLastname.Name = "tbLastname";
            tbLastname.Size = new Size(120, 23);
            tbLastname.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(185, 185);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 42);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(167, 137);
            tbAge.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(120, 23);
            tbAge.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(46, 185);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 42);
            btnSave.TabIndex = 9;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 265);
            Controls.Add(btnSave);
            Controls.Add(tbAge);
            Controls.Add(btnCancel);
            Controls.Add(tbLastname);
            Controls.Add(tbFirstname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormAdd";
            Text = "Dodaj nowy element";
            ((System.ComponentModel.ISupportInitialize)tbAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbFirstname;
        private TextBox tbLastname;
        private TextBox textBox3;
        private Button button1;
        private Button btnCancel;
        private NumericUpDown tbAge;
        private Button btnSave;
    }
}