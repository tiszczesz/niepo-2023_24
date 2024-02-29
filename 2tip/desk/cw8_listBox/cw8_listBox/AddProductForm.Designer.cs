namespace cw8_listBox
{
    partial class AddProductForm
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
            tbName = new TextBox();
            tbPrice = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)tbPrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 26);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Nazwa produktu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 59);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "Cena produktu";
            // 
            // tbName
            // 
            tbName.Location = new Point(129, 23);
            tbName.Name = "tbName";
            tbName.Size = new Size(117, 23);
            tbName.TabIndex = 2;
            // 
            // tbPrice
            // 
            tbPrice.DecimalPlaces = 2;
            tbPrice.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            tbPrice.Location = new Point(126, 57);
            tbPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(120, 23);
            tbPrice.TabIndex = 3;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 331);
            Controls.Add(tbPrice);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddProductForm";
            Text = "Dodaj nowy produkt";
            ((System.ComponentModel.ISupportInitialize)tbPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbName;
        private NumericUpDown tbPrice;
    }
}