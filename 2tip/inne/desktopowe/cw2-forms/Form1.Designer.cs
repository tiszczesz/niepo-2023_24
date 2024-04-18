namespace cw2_forms
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            panel1 = new Panel();
            btnGo = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbLines = new Label();
            lbChars = new Label();
            lbLetter = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(103, 22);
            newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "pliki tekstowe|*.txt|wszystkie|*.*";
            openFileDialog1.Title = "Otwórz plik";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(200, 24);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(600, 426);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(lbLetter);
            panel1.Controls.Add(lbChars);
            panel1.Controls.Add(lbLines);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnGo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 426);
            panel1.TabIndex = 2;
            // 
            // btnGo
            // 
            btnGo.Enabled = false;
            btnGo.Location = new Point(3, 15);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(191, 39);
            btnGo.TabIndex = 0;
            btnGo.Text = "Wykonaj statystyki";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 68);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "ilość lini:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 122);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "ilość liter:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 3;
            label3.Text = "ilość znaków:";
            // 
            // lbLines
            // 
            lbLines.AutoSize = true;
            lbLines.Location = new Point(106, 68);
            lbLines.Name = "lbLines";
            lbLines.Size = new Size(13, 15);
            lbLines.TabIndex = 4;
            lbLines.Text = "0";
            // 
            // lbChars
            // 
            lbChars.AutoSize = true;
            lbChars.Location = new Point(106, 93);
            lbChars.Name = "lbChars";
            lbChars.Size = new Size(13, 15);
            lbChars.TabIndex = 5;
            lbChars.Text = "0";
            // 
            // lbLetter
            // 
            lbLetter.AutoSize = true;
            lbLetter.Location = new Point(106, 122);
            lbLetter.Name = "lbLetter";
            lbLetter.Size = new Size(13, 15);
            lbLetter.TabIndex = 6;
            lbLetter.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private Panel panel1;
        private Button btnGo;
        private Label label1;
        private Label lbLetter;
        private Label lbChars;
        private Label lbLines;
        private Label label3;
        private Label label2;
    }
}
