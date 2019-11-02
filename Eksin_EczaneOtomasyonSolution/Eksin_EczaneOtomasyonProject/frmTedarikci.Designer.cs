namespace Eksin_EczaneOtomasyonProject
{
    partial class frmTedarikci
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
            this.btnIlacEkle = new System.Windows.Forms.Button();
            this.btnIlacGuncelle = new System.Windows.Forms.Button();
            this.btnIlacSil = new System.Windows.Forms.Button();
            this.lstCalisanlar = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnIlacEkle
            // 
            this.btnIlacEkle.Location = new System.Drawing.Point(192, 373);
            this.btnIlacEkle.Name = "btnIlacEkle";
            this.btnIlacEkle.Size = new System.Drawing.Size(110, 37);
            this.btnIlacEkle.TabIndex = 54;
            this.btnIlacEkle.Text = "Ekle";
            this.btnIlacEkle.UseVisualStyleBackColor = true;
            // 
            // btnIlacGuncelle
            // 
            this.btnIlacGuncelle.Location = new System.Drawing.Point(345, 373);
            this.btnIlacGuncelle.Name = "btnIlacGuncelle";
            this.btnIlacGuncelle.Size = new System.Drawing.Size(110, 37);
            this.btnIlacGuncelle.TabIndex = 53;
            this.btnIlacGuncelle.Text = "Güncelle";
            this.btnIlacGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnIlacSil
            // 
            this.btnIlacSil.Location = new System.Drawing.Point(498, 373);
            this.btnIlacSil.Name = "btnIlacSil";
            this.btnIlacSil.Size = new System.Drawing.Size(110, 37);
            this.btnIlacSil.TabIndex = 52;
            this.btnIlacSil.Text = "Sil";
            this.btnIlacSil.UseVisualStyleBackColor = true;
            // 
            // lstCalisanlar
            // 
            this.lstCalisanlar.Location = new System.Drawing.Point(12, 41);
            this.lstCalisanlar.Name = "lstCalisanlar";
            this.lstCalisanlar.Size = new System.Drawing.Size(776, 302);
            this.lstCalisanlar.TabIndex = 51;
            this.lstCalisanlar.UseCompatibleStateImageBehavior = false;
            // 
            // frmTedarikci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIlacEkle);
            this.Controls.Add(this.btnIlacGuncelle);
            this.Controls.Add(this.btnIlacSil);
            this.Controls.Add(this.lstCalisanlar);
            this.Name = "frmTedarikci";
            this.Text = "frmTedarikci";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIlacEkle;
        private System.Windows.Forms.Button btnIlacGuncelle;
        private System.Windows.Forms.Button btnIlacSil;
        private System.Windows.Forms.ListView lstCalisanlar;
    }
}