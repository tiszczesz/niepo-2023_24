namespace WinForms_cw2
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
            btnInsertColor = new Button();
            btnClearList = new Button();
            btnAddColor = new Button();
            cbColors = new ComboBox();
            label2 = new Label();
            listColors = new ListBox();
            label1 = new Label();
            btnDelete = new Button();
            colorPanel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnInsertColor);
            panel1.Controls.Add(btnClearList);
            panel1.Controls.Add(btnAddColor);
            panel1.Controls.Add(cbColors);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(listColors);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 450);
            panel1.TabIndex = 0;
            // 
            // btnInsertColor
            // 
            btnInsertColor.Enabled = false;
            btnInsertColor.Location = new Point(397, 92);
            btnInsertColor.Name = "btnInsertColor";
            btnInsertColor.Size = new Size(149, 23);
            btnInsertColor.TabIndex = 6;
            btnInsertColor.Text = "Wstaw kolor";
            btnInsertColor.UseVisualStyleBackColor = true;
            btnInsertColor.Click += btnInsertColor_Click;
            // 
            // btnClearList
            // 
            btnClearList.Location = new Point(397, 129);
            btnClearList.Name = "btnClearList";
            btnClearList.Size = new Size(149, 23);
            btnClearList.TabIndex = 5;
            btnClearList.Text = "Wyczyść listę kolorów";
            btnClearList.UseVisualStyleBackColor = true;
            btnClearList.Click += btnClearList_Click;
            // 
            // btnAddColor
            // 
            btnAddColor.Location = new Point(397, 55);
            btnAddColor.Name = "btnAddColor";
            btnAddColor.Size = new Size(149, 23);
            btnAddColor.TabIndex = 4;
            btnAddColor.Text = "Dodaj kolor";
            btnAddColor.UseVisualStyleBackColor = true;
            btnAddColor.Click += btnAddColor_Click;
            // 
            // cbColors
            // 
            cbColors.DropDownStyle = ComboBoxStyle.DropDownList;
            cbColors.FormattingEnabled = true;
            cbColors.Items.AddRange(new object[] { "red", "green", "blue", "yellow", "purple", "white", "grey", "pink" });
            cbColors.Location = new Point(270, 56);
            cbColors.Name = "cbColors";
            cbColors.Size = new Size(121, 23);
            cbColors.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 58);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Wybierz kolor";
            // 
            // listColors
            // 
            listColors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listColors.FormattingEnabled = true;
            listColors.ItemHeight = 15;
            listColors.Location = new Point(12, 58);
            listColors.Name = "listColors";
            listColors.Size = new Size(161, 379);
            listColors.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(68, 23);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 0;
            label1.Text = "Zbiór kolorów";
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(397, 166);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Usuń kolor";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // colorPanel
            // 
            colorPanel.BackColor = Color.White;
            colorPanel.Dock = DockStyle.Fill;
            colorPanel.Location = new Point(581, 0);
            colorPanel.Name = "colorPanel";
            colorPanel.Size = new Size(219, 450);
            colorPanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(colorPanel);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Okno główne";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox listColors;
        private Label label1;
        private ComboBox cbColors;
        private Label label2;
        private Button btnAddColor;
        private Button btnClearList;
        private Button btnInsertColor;
        private Button btnDelete;
        private Panel colorPanel;
    }
}
