namespace LiseYonetim.UI
{
    partial class FrmAnaMenu
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
            this.anaMenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idariİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaMenüToolStripMenuItem,
            this.öğretmenİşlemleriToolStripMenuItem,
            this.öğrenciİşlemleriToolStripMenuItem,
            this.idariİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1109, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaMenüToolStripMenuItem
            // 
            this.anaMenüToolStripMenuItem.Name = "anaMenüToolStripMenuItem";
            this.anaMenüToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.anaMenüToolStripMenuItem.Text = "AnaMenü";
            // 
            // öğretmenİşlemleriToolStripMenuItem
            // 
            this.öğretmenİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğretmenListesiToolStripMenuItem});
            this.öğretmenİşlemleriToolStripMenuItem.Name = "öğretmenİşlemleriToolStripMenuItem";
            this.öğretmenİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.öğretmenİşlemleriToolStripMenuItem.Text = "Öğretmen İşlemleri";
            // 
            // öğrenciİşlemleriToolStripMenuItem
            // 
            this.öğrenciİşlemleriToolStripMenuItem.Name = "öğrenciİşlemleriToolStripMenuItem";
            this.öğrenciİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.öğrenciİşlemleriToolStripMenuItem.Text = "Öğrenci İşlemleri";
            // 
            // idariİşlemleriToolStripMenuItem
            // 
            this.idariİşlemleriToolStripMenuItem.Name = "idariİşlemleriToolStripMenuItem";
            this.idariİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.idariİşlemleriToolStripMenuItem.Text = "İdari İşlemler";
            // 
            // öğretmenListesiToolStripMenuItem
            // 
            this.öğretmenListesiToolStripMenuItem.Name = "öğretmenListesiToolStripMenuItem";
            this.öğretmenListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğretmenListesiToolStripMenuItem.Text = "ÖğretmenListesi";
            this.öğretmenListesiToolStripMenuItem.Click += new System.EventHandler(this.öğretmenListesiToolStripMenuItem_Click);
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 465);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAnaMenu";
            this.Text = "AnaMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaMenüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğretmenİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idariİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğretmenListesiToolStripMenuItem;
    }
}