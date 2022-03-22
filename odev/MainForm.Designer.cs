namespace odev
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelKayıtEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelAramaEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.görünümToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1028, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelKayıtEkranıToolStripMenuItem,
            this.personelAramaEkranıToolStripMenuItem});
            this.görünümToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // personelKayıtEkranıToolStripMenuItem
            // 
            this.personelKayıtEkranıToolStripMenuItem.Name = "personelKayıtEkranıToolStripMenuItem";
            this.personelKayıtEkranıToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.personelKayıtEkranıToolStripMenuItem.Text = "Personel Kayıt Ekranı";
            this.personelKayıtEkranıToolStripMenuItem.Click += new System.EventHandler(this.personelKayıtEkranıToolStripMenuItem_Click);
            // 
            // personelAramaEkranıToolStripMenuItem
            // 
            this.personelAramaEkranıToolStripMenuItem.Name = "personelAramaEkranıToolStripMenuItem";
            this.personelAramaEkranıToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.personelAramaEkranıToolStripMenuItem.Text = "Personel Arama Ekranı";
            this.personelAramaEkranıToolStripMenuItem.Click += new System.EventHandler(this.personelAramaEkranıToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 813);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelKayıtEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelAramaEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
    }
}