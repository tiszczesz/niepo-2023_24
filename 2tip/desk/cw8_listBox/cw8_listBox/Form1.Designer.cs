namespace cw8_listBox
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
            panel1 = new Panel();
            btnLoad = new Button();
            lbProducts = new ListBox();
            fakeRepoBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fakeRepoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(btnLoad);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 17);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(172, 50);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Wyświetl produkty";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lbProducts
            // 
            lbProducts.Dock = DockStyle.Fill;
            lbProducts.FormattingEnabled = true;
            lbProducts.ItemHeight = 15;
            lbProducts.Location = new Point(200, 0);
            lbProducts.MultiColumn = true;
            lbProducts.Name = "lbProducts";
            lbProducts.Size = new Size(600, 450);
            lbProducts.TabIndex = 1;
            // 
            // fakeRepoBindingSource
            // 
            fakeRepoBindingSource.DataSource = typeof(Models.FakeRepo);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbProducts);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fakeRepoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLoad;
        private ListBox lbProducts;
        private BindingSource fakeRepoBindingSource;
    }
}
