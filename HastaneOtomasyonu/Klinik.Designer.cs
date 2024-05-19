namespace HastaneOtomasyonu
{
    partial class Klinik
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
            this.label15 = new System.Windows.Forms.Label();
            this.dtSekKlinik = new System.Windows.Forms.DataGridView();
            this.txtSekKlinikAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSekKlinikEkle = new System.Windows.Forms.Button();
            this.btnSekKlinikYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtSekKlinik)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(431, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(194, 51);
            this.label15.TabIndex = 42;
            this.label15.Text = "Klinikler";
            // 
            // dtSekKlinik
            // 
            this.dtSekKlinik.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtSekKlinik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSekKlinik.Location = new System.Drawing.Point(23, 138);
            this.dtSekKlinik.Name = "dtSekKlinik";
            this.dtSekKlinik.RowHeadersWidth = 51;
            this.dtSekKlinik.RowTemplate.Height = 24;
            this.dtSekKlinik.Size = new System.Drawing.Size(975, 335);
            this.dtSekKlinik.TabIndex = 45;
            // 
            // txtSekKlinikAdi
            // 
            this.txtSekKlinikAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSekKlinikAdi.Location = new System.Drawing.Point(294, 90);
            this.txtSekKlinikAdi.Name = "txtSekKlinikAdi";
            this.txtSekKlinikAdi.Size = new System.Drawing.Size(264, 34);
            this.txtSekKlinikAdi.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(109, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 33);
            this.label1.TabIndex = 46;
            this.label1.Text = "Klinik Adı:\r\n";
            // 
            // btnSekKlinikEkle
            // 
            this.btnSekKlinikEkle.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.add;
            this.btnSekKlinikEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSekKlinikEkle.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnSekKlinikEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSekKlinikEkle.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSekKlinikEkle.Location = new System.Drawing.Point(537, 74);
            this.btnSekKlinikEkle.Name = "btnSekKlinikEkle";
            this.btnSekKlinikEkle.Size = new System.Drawing.Size(278, 58);
            this.btnSekKlinikEkle.TabIndex = 48;
            this.btnSekKlinikEkle.Text = "Ekle";
            this.btnSekKlinikEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSekKlinikEkle.UseVisualStyleBackColor = true;
            // 
            // btnSekKlinikYenile
            // 
            this.btnSekKlinikYenile.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.update__1_;
            this.btnSekKlinikYenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSekKlinikYenile.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnSekKlinikYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSekKlinikYenile.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSekKlinikYenile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSekKlinikYenile.Location = new System.Drawing.Point(269, 479);
            this.btnSekKlinikYenile.Name = "btnSekKlinikYenile";
            this.btnSekKlinikYenile.Size = new System.Drawing.Size(388, 89);
            this.btnSekKlinikYenile.TabIndex = 60;
            this.btnSekKlinikYenile.Text = "Yenile";
            this.btnSekKlinikYenile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSekKlinikYenile.UseVisualStyleBackColor = true;
            // 
            // Klinik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1025, 585);
            this.Controls.Add(this.btnSekKlinikYenile);
            this.Controls.Add(this.btnSekKlinikEkle);
            this.Controls.Add(this.txtSekKlinikAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtSekKlinik);
            this.Controls.Add(this.label15);
            this.Name = "Klinik";
            this.Text = "Klinik";
            ((System.ComponentModel.ISupportInitialize)(this.dtSekKlinik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dtSekKlinik;
        private System.Windows.Forms.TextBox txtSekKlinikAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSekKlinikEkle;
        private System.Windows.Forms.Button btnSekKlinikYenile;
    }
}