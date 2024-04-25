namespace cw3
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
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(269, 40);
            label1.Name = "label1";
            label1.Size = new Size(120, 50);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(269, 119);
            label2.Name = "label2";
            label2.Size = new Size(120, 50);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(269, 201);
            label3.Name = "label3";
            label3.Size = new Size(120, 50);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // button1
            // 
            button1.Location = new Point(20, 28);
            button1.Name = "button1";
            button1.Size = new Size(178, 102);
            button1.TabIndex = 3;
            button1.Text = "Noew okno";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            KeyUp += Form1_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
