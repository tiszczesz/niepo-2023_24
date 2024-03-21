namespace Swieta2024
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
            button1 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(29, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "potrawa 1", "potrawa 2" });
            listBox1.Location = new Point(140, 16);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(176, 424);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.AppWorkspace;
            label1.Location = new Point(347, 22);
            label1.Name = "label1";
            label1.Size = new Size(201, 323);
            label1.TabIndex = 2;
            label1.Text = "opis wybranej potrawy";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "lista składników" });
            listBox2.Location = new Point(595, 22);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 214);
            listBox2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Label label1;
        private ListBox listBox2;
    }
}
