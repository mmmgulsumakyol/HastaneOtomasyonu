namespace HastaneOtomasyonu
{
    partial class SekLab
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtSekSonuc = new System.Windows.Forms.TextBox();
            this.dateSekLab = new System.Windows.Forms.DateTimePicker();
            this.txtSekLabTc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSebLabSorgula = new System.Windows.Forms.Button();
            this.btnSekLabKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(168, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 31);
            this.label4.TabIndex = 30;
            this.label4.Text = "Laboratuvar Sonucu Gir";
            // 
            // txtSekSonuc
            // 
            this.txtSekSonuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSekSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSekSonuc.Location = new System.Drawing.Point(244, 215);
            this.txtSekSonuc.MaxLength = 327678;
            this.txtSekSonuc.Name = "txtSekSonuc";
            this.txtSekSonuc.Size = new System.Drawing.Size(284, 136);
            this.txtSekSonuc.TabIndex = 28;
            // 
            // dateSekLab
            // 
            this.dateSekLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateSekLab.Location = new System.Drawing.Point(244, 152);
            this.dateSekLab.Name = "dateSekLab";
            this.dateSekLab.Size = new System.Drawing.Size(284, 34);
            this.dateSekLab.TabIndex = 27;
            // 
            // txtSekLabTc
            // 
            this.txtSekLabTc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSekLabTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSekLabTc.Location = new System.Drawing.Point(244, 97);
            this.txtSekLabTc.Name = "txtSekLabTc";
            this.txtSekLabTc.Size = new System.Drawing.Size(284, 27);
            this.txtSekLabTc.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(66, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 31);
            this.label3.TabIndex = 25;
            this.label3.Text = "Sonuç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(66, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 31);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Hasta T.C. No";
            // 
            // btnSebLabSorgula
            // 
            this.btnSebLabSorgula.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.magnifying_glass;
            this.btnSebLabSorgula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSebLabSorgula.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnSebLabSorgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSebLabSorgula.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSebLabSorgula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSebLabSorgula.Location = new System.Drawing.Point(560, 69);
            this.btnSebLabSorgula.Name = "btnSebLabSorgula";
            this.btnSebLabSorgula.Size = new System.Drawing.Size(200, 282);
            this.btnSebLabSorgula.TabIndex = 47;
            this.btnSebLabSorgula.Text = "Sonucu Sorgula  ";
            this.btnSebLabSorgula.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSebLabSorgula.UseVisualStyleBackColor = true;
            this.btnSebLabSorgula.Click += new System.EventHandler(this.btnSebLabSorgula_Click);
            // 
            // btnSekLabKaydet
            // 
            this.btnSekLabKaydet.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.diskette;
            this.btnSekLabKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSekLabKaydet.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnSekLabKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSekLabKaydet.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSekLabKaydet.Location = new System.Drawing.Point(153, 366);
            this.btnSekLabKaydet.Name = "btnSekLabKaydet";
            this.btnSekLabKaydet.Size = new System.Drawing.Size(345, 58);
            this.btnSekLabKaydet.TabIndex = 29;
            this.btnSekLabKaydet.Text = "Kaydet";
            this.btnSekLabKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSekLabKaydet.UseVisualStyleBackColor = true;
            // 
            // SekLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(813, 463);
            this.Controls.Add(this.btnSebLabSorgula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSekLabKaydet);
            this.Controls.Add(this.txtSekSonuc);
            this.Controls.Add(this.dateSekLab);
            this.Controls.Add(this.txtSekLabTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SekLab";
            this.Text = "Laboratuvar Sonuç";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSekLabKaydet;
        private System.Windows.Forms.TextBox txtSekSonuc;
        private System.Windows.Forms.DateTimePicker dateSekLab;
        private System.Windows.Forms.TextBox txtSekLabTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSebLabSorgula;
    }
}