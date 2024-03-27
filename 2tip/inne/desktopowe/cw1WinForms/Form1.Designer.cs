namespace cw1WinForms
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            personsList = new ListBox();
            btnLoad = new Button();
            btnAddForm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(54, 38);
            label1.Name = "label1";
            label1.Size = new Size(67, 27);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(47, 91);
            button1.Name = "button1";
            button1.Size = new Size(211, 75);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // personsList
            // 
            personsList.FormattingEnabled = true;
            personsList.ItemHeight = 15;
            personsList.Location = new Point(318, 38);
            personsList.Name = "personsList";
            personsList.Size = new Size(293, 319);
            personsList.TabIndex = 2;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(651, 39);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(175, 58);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Pobierz dane";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAddForm
            // 
            btnAddForm.Location = new Point(651, 108);
            btnAddForm.Name = "btnAddForm";
            btnAddForm.Size = new Size(175, 58);
            btnAddForm.TabIndex = 4;
            btnAddForm.Text = "Dodaj nowe";
            btnAddForm.UseVisualStyleBackColor = true;
            btnAddForm.Click += btnAddForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(1065, 545);
            Controls.Add(btnAddForm);
            Controls.Add(btnLoad);
            Controls.Add(personsList);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Moje okienko1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private ListBox personsList;
        private Button btnLoad;
        private Button btnAddForm;
    }
}
