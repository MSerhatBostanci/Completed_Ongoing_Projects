namespace AdoNet_Odev
{
    partial class Form1
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
            this.grpInsertRegion = new System.Windows.Forms.GroupBox();
            this.grpInsertShippers = new System.Windows.Forms.GroupBox();
            this.btnInsertRegion = new System.Windows.Forms.Button();
            this.lblRegionDescription = new System.Windows.Forms.Label();
            this.txtRegionDescription = new System.Windows.Forms.TextBox();
            this.btnInsertShippers = new System.Windows.Forms.Button();
            this.txtRegionRowsAffected = new System.Windows.Forms.TextBox();
            this.lblRegionEtkilenenKolonlar = new System.Windows.Forms.Label();
            this.txtShippersRowsAffected = new System.Windows.Forms.TextBox();
            this.lblShipperRowsAffected = new System.Windows.Forms.Label();
            this.lblShippersPhone = new System.Windows.Forms.Label();
            this.txtShippersCompanyName = new System.Windows.Forms.TextBox();
            this.lblShippersCompanyName = new System.Windows.Forms.Label();
            this.mtxtShipperPhone = new System.Windows.Forms.MaskedTextBox();
            this.grpInsertRegion.SuspendLayout();
            this.grpInsertShippers.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInsertRegion
            // 
            this.grpInsertRegion.Controls.Add(this.txtRegionRowsAffected);
            this.grpInsertRegion.Controls.Add(this.lblRegionEtkilenenKolonlar);
            this.grpInsertRegion.Controls.Add(this.txtRegionDescription);
            this.grpInsertRegion.Controls.Add(this.lblRegionDescription);
            this.grpInsertRegion.Controls.Add(this.btnInsertRegion);
            this.grpInsertRegion.Location = new System.Drawing.Point(23, 12);
            this.grpInsertRegion.Name = "grpInsertRegion";
            this.grpInsertRegion.Size = new System.Drawing.Size(203, 407);
            this.grpInsertRegion.TabIndex = 0;
            this.grpInsertRegion.TabStop = false;
            this.grpInsertRegion.Text = "Insert Region";
            // 
            // grpInsertShippers
            // 
            this.grpInsertShippers.Controls.Add(this.mtxtShipperPhone);
            this.grpInsertShippers.Controls.Add(this.lblShippersPhone);
            this.grpInsertShippers.Controls.Add(this.txtShippersCompanyName);
            this.grpInsertShippers.Controls.Add(this.lblShippersCompanyName);
            this.grpInsertShippers.Controls.Add(this.txtShippersRowsAffected);
            this.grpInsertShippers.Controls.Add(this.lblShipperRowsAffected);
            this.grpInsertShippers.Controls.Add(this.btnInsertShippers);
            this.grpInsertShippers.Location = new System.Drawing.Point(261, 12);
            this.grpInsertShippers.Name = "grpInsertShippers";
            this.grpInsertShippers.Size = new System.Drawing.Size(203, 407);
            this.grpInsertShippers.TabIndex = 1;
            this.grpInsertShippers.TabStop = false;
            this.grpInsertShippers.Text = "Insert Shippers";
            // 
            // btnInsertRegion
            // 
            this.btnInsertRegion.Location = new System.Drawing.Point(9, 202);
            this.btnInsertRegion.Name = "btnInsertRegion";
            this.btnInsertRegion.Size = new System.Drawing.Size(182, 36);
            this.btnInsertRegion.TabIndex = 0;
            this.btnInsertRegion.Text = "Insert Region";
            this.btnInsertRegion.UseVisualStyleBackColor = true;
            this.btnInsertRegion.Click += new System.EventHandler(this.btnInsertRegion_Click);
            // 
            // lblRegionDescription
            // 
            this.lblRegionDescription.AutoSize = true;
            this.lblRegionDescription.Location = new System.Drawing.Point(6, 79);
            this.lblRegionDescription.Name = "lblRegionDescription";
            this.lblRegionDescription.Size = new System.Drawing.Size(97, 13);
            this.lblRegionDescription.TabIndex = 1;
            this.lblRegionDescription.Text = "Region Description";
            // 
            // txtRegionDescription
            // 
            this.txtRegionDescription.Location = new System.Drawing.Point(9, 95);
            this.txtRegionDescription.Name = "txtRegionDescription";
            this.txtRegionDescription.Size = new System.Drawing.Size(182, 20);
            this.txtRegionDescription.TabIndex = 2;
            // 
            // btnInsertShippers
            // 
            this.btnInsertShippers.Location = new System.Drawing.Point(13, 202);
            this.btnInsertShippers.Name = "btnInsertShippers";
            this.btnInsertShippers.Size = new System.Drawing.Size(182, 36);
            this.btnInsertShippers.TabIndex = 13;
            this.btnInsertShippers.Text = "Insert Shipper";
            this.btnInsertShippers.UseVisualStyleBackColor = true;
            this.btnInsertShippers.Click += new System.EventHandler(this.btnInsertShippers_Click);
            // 
            // txtRegionRowsAffected
            // 
            this.txtRegionRowsAffected.Location = new System.Drawing.Point(6, 334);
            this.txtRegionRowsAffected.Name = "txtRegionRowsAffected";
            this.txtRegionRowsAffected.Size = new System.Drawing.Size(182, 20);
            this.txtRegionRowsAffected.TabIndex = 8;
            // 
            // lblRegionEtkilenenKolonlar
            // 
            this.lblRegionEtkilenenKolonlar.AutoSize = true;
            this.lblRegionEtkilenenKolonlar.Location = new System.Drawing.Point(6, 318);
            this.lblRegionEtkilenenKolonlar.Name = "lblRegionEtkilenenKolonlar";
            this.lblRegionEtkilenenKolonlar.Size = new System.Drawing.Size(77, 13);
            this.lblRegionEtkilenenKolonlar.TabIndex = 7;
            this.lblRegionEtkilenenKolonlar.Text = "Rows Affected";
            // 
            // txtShippersRowsAffected
            // 
            this.txtShippersRowsAffected.Location = new System.Drawing.Point(13, 334);
            this.txtShippersRowsAffected.Name = "txtShippersRowsAffected";
            this.txtShippersRowsAffected.Size = new System.Drawing.Size(182, 20);
            this.txtShippersRowsAffected.TabIndex = 15;
            // 
            // lblShipperRowsAffected
            // 
            this.lblShipperRowsAffected.AutoSize = true;
            this.lblShipperRowsAffected.Location = new System.Drawing.Point(10, 318);
            this.lblShipperRowsAffected.Name = "lblShipperRowsAffected";
            this.lblShipperRowsAffected.Size = new System.Drawing.Size(77, 13);
            this.lblShipperRowsAffected.TabIndex = 14;
            this.lblShipperRowsAffected.Text = "Rows Affected";
            // 
            // lblShippersPhone
            // 
            this.lblShippersPhone.AutoSize = true;
            this.lblShippersPhone.Location = new System.Drawing.Point(10, 128);
            this.lblShippersPhone.Name = "lblShippersPhone";
            this.lblShippersPhone.Size = new System.Drawing.Size(38, 13);
            this.lblShippersPhone.TabIndex = 18;
            this.lblShippersPhone.Text = "Phone";
            // 
            // txtShippersCompanyName
            // 
            this.txtShippersCompanyName.Location = new System.Drawing.Point(13, 72);
            this.txtShippersCompanyName.Name = "txtShippersCompanyName";
            this.txtShippersCompanyName.Size = new System.Drawing.Size(182, 20);
            this.txtShippersCompanyName.TabIndex = 17;
            // 
            // lblShippersCompanyName
            // 
            this.lblShippersCompanyName.AutoSize = true;
            this.lblShippersCompanyName.Location = new System.Drawing.Point(10, 56);
            this.lblShippersCompanyName.Name = "lblShippersCompanyName";
            this.lblShippersCompanyName.Size = new System.Drawing.Size(82, 13);
            this.lblShippersCompanyName.TabIndex = 16;
            this.lblShippersCompanyName.Text = "Company Name";
            // 
            // mtxtShipperPhone
            // 
            this.mtxtShipperPhone.Location = new System.Drawing.Point(13, 144);
            this.mtxtShipperPhone.Mask = "(999) 000-0000";
            this.mtxtShipperPhone.Name = "mtxtShipperPhone";
            this.mtxtShipperPhone.Size = new System.Drawing.Size(182, 20);
            this.mtxtShipperPhone.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 431);
            this.Controls.Add(this.grpInsertShippers);
            this.Controls.Add(this.grpInsertRegion);
            this.Name = "Form1";
            this.Text = "Insert Region and Shippers";
            this.grpInsertRegion.ResumeLayout(false);
            this.grpInsertRegion.PerformLayout();
            this.grpInsertShippers.ResumeLayout(false);
            this.grpInsertShippers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInsertRegion;
        private System.Windows.Forms.GroupBox grpInsertShippers;
        private System.Windows.Forms.TextBox txtRegionRowsAffected;
        private System.Windows.Forms.Label lblRegionEtkilenenKolonlar;
        private System.Windows.Forms.TextBox txtRegionDescription;
        private System.Windows.Forms.Label lblRegionDescription;
        private System.Windows.Forms.Button btnInsertRegion;
        private System.Windows.Forms.Label lblShippersPhone;
        private System.Windows.Forms.TextBox txtShippersCompanyName;
        private System.Windows.Forms.Label lblShippersCompanyName;
        private System.Windows.Forms.TextBox txtShippersRowsAffected;
        private System.Windows.Forms.Label lblShipperRowsAffected;
        private System.Windows.Forms.Button btnInsertShippers;
        private System.Windows.Forms.MaskedTextBox mtxtShipperPhone;
    }
}

