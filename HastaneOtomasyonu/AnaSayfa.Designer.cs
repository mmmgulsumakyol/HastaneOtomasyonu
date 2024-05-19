namespace HastaneOtomasyonu
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnkayitt = new System.Windows.Forms.Button();
            this.giris_yap = new System.Windows.Forms.Button();
            this.sifre_unuttum = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDktrGiris = new System.Windows.Forms.Button();
            this.txtDktrSifre = new System.Windows.Forms.TextBox();
            this.txtDktrTc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSekGiris = new System.Windows.Forms.Button();
            this.txtSekSifre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(257, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = " KAYIT PANELİ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(93, 249);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 313);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.btnkayitt);
            this.tabPage1.Controls.Add(this.giris_yap);
            this.tabPage1.Controls.Add(this.sifre_unuttum);
            this.tabPage1.Controls.Add(this.txtsifre);
            this.tabPage1.Controls.Add(this.txtc);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hasta Girişi";
            // 
            // btnkayitt
            // 
            this.btnkayitt.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.btnkayitt.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.Ekran_görüntüsü_2024_05_11_112831;
            this.btnkayitt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkayitt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnkayitt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkayitt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkayitt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnkayitt.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnkayitt.Location = new System.Drawing.Point(339, 154);
            this.btnkayitt.Name = "btnkayitt";
            this.btnkayitt.Size = new System.Drawing.Size(265, 48);
            this.btnkayitt.TabIndex = 7;
            this.btnkayitt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkayitt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnkayitt.UseCompatibleTextRendering = true;
            this.btnkayitt.UseVisualStyleBackColor = false;
            this.btnkayitt.Click += new System.EventHandler(this.button1_Click);
            // 
            // giris_yap
            // 
            this.giris_yap.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.giris_yap.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.Ekran_görüntüsü_2024_05_11_113716;
            this.giris_yap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.giris_yap.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.giris_yap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giris_yap.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_yap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.giris_yap.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.giris_yap.Location = new System.Drawing.Point(30, 154);
            this.giris_yap.Name = "giris_yap";
            this.giris_yap.Size = new System.Drawing.Size(287, 48);
            this.giris_yap.TabIndex = 6;
            this.giris_yap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.giris_yap.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.giris_yap.UseCompatibleTextRendering = true;
            this.giris_yap.UseVisualStyleBackColor = false;
            this.giris_yap.Click += new System.EventHandler(this.giris_yap_Click);
            // 
            // sifre_unuttum
            // 
            this.sifre_unuttum.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.sifre_unuttum.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.sifremi_unuttum;
            this.sifre_unuttum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sifre_unuttum.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sifre_unuttum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sifre_unuttum.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_unuttum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sifre_unuttum.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.sifre_unuttum.Location = new System.Drawing.Point(167, 208);
            this.sifre_unuttum.Name = "sifre_unuttum";
            this.sifre_unuttum.Size = new System.Drawing.Size(314, 49);
            this.sifre_unuttum.TabIndex = 5;
            this.sifre_unuttum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sifre_unuttum.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.sifre_unuttum.UseCompatibleTextRendering = true;
            this.sifre_unuttum.UseVisualStyleBackColor = false;
            this.sifre_unuttum.Click += new System.EventHandler(this.sifre_unuttum_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsifre.Location = new System.Drawing.Point(246, 108);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(185, 27);
            this.txtsifre.TabIndex = 3;
            // 
            // txtc
            // 
            this.txtc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc.Location = new System.Drawing.Point(246, 56);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(185, 27);
            this.txtc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(74, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(74, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "TC Kimlik No:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.btnDktrGiris);
            this.tabPage2.Controls.Add(this.txtDktrSifre);
            this.tabPage2.Controls.Add(this.txtDktrTc);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(632, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Doktor Girişi";
            // 
            // btnDktrGiris
            // 
            this.btnDktrGiris.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.btnDktrGiris.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.Ekran_görüntüsü_2024_05_11_113716;
            this.btnDktrGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDktrGiris.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDktrGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDktrGiris.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDktrGiris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDktrGiris.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDktrGiris.Location = new System.Drawing.Point(126, 151);
            this.btnDktrGiris.Name = "btnDktrGiris";
            this.btnDktrGiris.Size = new System.Drawing.Size(355, 48);
            this.btnDktrGiris.TabIndex = 11;
            this.btnDktrGiris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDktrGiris.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDktrGiris.UseCompatibleTextRendering = true;
            this.btnDktrGiris.UseVisualStyleBackColor = false;
            this.btnDktrGiris.Click += new System.EventHandler(this.btnDktrGiris_Click);
            // 
            // txtDktrSifre
            // 
            this.txtDktrSifre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDktrSifre.Location = new System.Drawing.Point(294, 98);
            this.txtDktrSifre.Name = "txtDktrSifre";
            this.txtDktrSifre.Size = new System.Drawing.Size(185, 27);
            this.txtDktrSifre.TabIndex = 10;
            // 
            // txtDktrTc
            // 
            this.txtDktrTc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDktrTc.Location = new System.Drawing.Point(294, 46);
            this.txtDktrTc.Name = "txtDktrTc";
            this.txtDktrTc.Size = new System.Drawing.Size(185, 27);
            this.txtDktrTc.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(122, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(122, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "TC Kimlik No:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage3.Controls.Add(this.btnSekGiris);
            this.tabPage3.Controls.Add(this.txtSekSifre);
            this.tabPage3.Controls.Add(this.txtId);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(632, 276);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sekreter Girişi";
            // 
            // btnSekGiris
            // 
            this.btnSekGiris.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.btnSekGiris.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.Ekran_görüntüsü_2024_05_11_113716;
            this.btnSekGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSekGiris.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSekGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSekGiris.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSekGiris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSekGiris.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSekGiris.Location = new System.Drawing.Point(130, 156);
            this.btnSekGiris.Name = "btnSekGiris";
            this.btnSekGiris.Size = new System.Drawing.Size(355, 48);
            this.btnSekGiris.TabIndex = 16;
            this.btnSekGiris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSekGiris.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSekGiris.UseCompatibleTextRendering = true;
            this.btnSekGiris.UseVisualStyleBackColor = false;
            this.btnSekGiris.Click += new System.EventHandler(this.btnSekGiris_Click);
            // 
            // txtSekSifre
            // 
            this.txtSekSifre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSekSifre.Location = new System.Drawing.Point(298, 103);
            this.txtSekSifre.Name = "txtSekSifre";
            this.txtSekSifre.Size = new System.Drawing.Size(185, 27);
            this.txtSekSifre.TabIndex = 15;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(298, 51);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(185, 27);
            this.txtId.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(126, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Şifre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(126, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::HastaneOtomasyonu.Properties.Resources.health_icon_transparent_1;
            this.pictureBox1.Location = new System.Drawing.Point(301, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(807, 606);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaSayfa";
            this.Text = "Anasayfa-Giriş";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sifre_unuttum;
        private System.Windows.Forms.Button giris_yap;
        private System.Windows.Forms.Button btnkayitt;
        private System.Windows.Forms.Button btnDktrGiris;
        private System.Windows.Forms.TextBox txtDktrSifre;
        private System.Windows.Forms.TextBox txtDktrTc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSekGiris;
        private System.Windows.Forms.TextBox txtSekSifre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

