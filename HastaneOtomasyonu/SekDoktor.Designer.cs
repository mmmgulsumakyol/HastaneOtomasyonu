namespace HastaneOtomasyonu
{
    partial class SekDoktor
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
            this.txtSekDrTc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSekDrID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSekDrAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSekDrSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtSekDr = new System.Windows.Forms.DataGridView();
            this.btnSekDrEkle = new System.Windows.Forms.Button();
            this.btnSekDrYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtSekDr)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSekDrTc
            // 
            this.txtSekDrTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSekDrTc.Location = new System.Drawing.Point(272, 111);
            this.txtSekDrTc.Name = "txtSekDrTc";
            this.txtSekDrTc.Size = new System.Drawing.Size(239, 34);
            this.txtSekDrTc.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(47, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 33);
            this.label1.TabIndex = 50;
            this.label1.Text = "Doktor T.C. No:\r\n";
            // 
            // txtSekDrID
            // 
            this.txtSekDrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSekDrID.Location = new System.Drawing.Point(272, 43);
            this.txtSekDrID.Name = "txtSekDrID";
            this.txtSekDrID.Size = new System.Drawing.Size(239, 34);
            this.txtSekDrID.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(47, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 33);
            this.label2.TabIndex = 52;
            this.label2.Text = "Doktor ID:\r\n";
            // 
            // txtSekDrAd
            // 
            this.txtSekDrAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSekDrAd.Location = new System.Drawing.Point(272, 184);
            this.txtSekDrAd.Name = "txtSekDrAd";
            this.txtSekDrAd.Size = new System.Drawing.Size(239, 34);
            this.txtSekDrAd.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(47, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 33);
            this.label3.TabIndex = 54;
            this.label3.Text = "Doktor Adı:\r\n";
            // 
            // txtSekDrSifre
            // 
            this.txtSekDrSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSekDrSifre.Location = new System.Drawing.Point(272, 244);
            this.txtSekDrSifre.Name = "txtSekDrSifre";
            this.txtSekDrSifre.Size = new System.Drawing.Size(239, 34);
            this.txtSekDrSifre.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(47, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 33);
            this.label4.TabIndex = 56;
            this.label4.Text = "Doktor Şifre:\r\n";
            // 
            // dtSekDr
            // 
            this.dtSekDr.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtSekDr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSekDr.Location = new System.Drawing.Point(21, 284);
            this.dtSekDr.Name = "dtSekDr";
            this.dtSekDr.RowHeadersWidth = 51;
            this.dtSekDr.RowTemplate.Height = 24;
            this.dtSekDr.Size = new System.Drawing.Size(889, 259);
            this.dtSekDr.TabIndex = 58;
            // 
            // btnSekDrEkle
            // 
            this.btnSekDrEkle.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.add;
            this.btnSekDrEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSekDrEkle.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnSekDrEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSekDrEkle.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSekDrEkle.Location = new System.Drawing.Point(580, -25);
            this.btnSekDrEkle.Name = "btnSekDrEkle";
            this.btnSekDrEkle.Size = new System.Drawing.Size(226, 309);
            this.btnSekDrEkle.TabIndex = 59;
            this.btnSekDrEkle.Text = "Ekle";
            this.btnSekDrEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSekDrEkle.UseVisualStyleBackColor = true;
            // 
            // btnSekDrYenile
            // 
            this.btnSekDrYenile.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.update__1_;
            this.btnSekDrYenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSekDrYenile.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnSekDrYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSekDrYenile.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSekDrYenile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSekDrYenile.Location = new System.Drawing.Point(231, 549);
            this.btnSekDrYenile.Name = "btnSekDrYenile";
            this.btnSekDrYenile.Size = new System.Drawing.Size(388, 89);
            this.btnSekDrYenile.TabIndex = 61;
            this.btnSekDrYenile.Text = "Yenile";
            this.btnSekDrYenile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSekDrYenile.UseVisualStyleBackColor = true;
            // 
            // SekDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(948, 649);
            this.Controls.Add(this.btnSekDrYenile);
            this.Controls.Add(this.btnSekDrEkle);
            this.Controls.Add(this.dtSekDr);
            this.Controls.Add(this.txtSekDrSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSekDrAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSekDrID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSekDrTc);
            this.Controls.Add(this.label1);
            this.Name = "SekDoktor";
            this.Text = "Doktorlar";
            ((System.ComponentModel.ISupportInitialize)(this.dtSekDr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSekDrTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSekDrID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSekDrAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSekDrSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtSekDr;
        private System.Windows.Forms.Button btnSekDrEkle;
        private System.Windows.Forms.Button btnSekDrYenile;
    }
}