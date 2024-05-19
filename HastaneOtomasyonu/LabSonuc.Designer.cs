namespace HastaneOtomasyonu
{
    partial class LabSonuc
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
            this.txtLabSonuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLabTc = new System.Windows.Forms.TextBox();
            this.dateLab = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLabKaydet = new System.Windows.Forms.Button();
            this.btnLab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLabSonuc
            // 
            this.txtLabSonuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLabSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLabSonuc.Location = new System.Drawing.Point(193, 195);
            this.txtLabSonuc.MaxLength = 327678;
            this.txtLabSonuc.Name = "txtLabSonuc";
            this.txtLabSonuc.Size = new System.Drawing.Size(284, 136);
            this.txtLabSonuc.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hasta T.C. No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sonuç";
            // 
            // txtLabTc
            // 
            this.txtLabTc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLabTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLabTc.Location = new System.Drawing.Point(193, 77);
            this.txtLabTc.Name = "txtLabTc";
            this.txtLabTc.Size = new System.Drawing.Size(284, 27);
            this.txtLabTc.TabIndex = 18;
            // 
            // dateLab
            // 
            this.dateLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateLab.Location = new System.Drawing.Point(193, 132);
            this.dateLab.Name = "dateLab";
            this.dateLab.Size = new System.Drawing.Size(284, 34);
            this.dateLab.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(117, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "Laboratuvar Sonucu Gir";
            // 
            // btnLabKaydet
            // 
            this.btnLabKaydet.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.diskette;
            this.btnLabKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLabKaydet.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnLabKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLabKaydet.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLabKaydet.Location = new System.Drawing.Point(103, 337);
            this.btnLabKaydet.Name = "btnLabKaydet";
            this.btnLabKaydet.Size = new System.Drawing.Size(345, 58);
            this.btnLabKaydet.TabIndex = 21;
            this.btnLabKaydet.Text = "Kaydet";
            this.btnLabKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLabKaydet.UseVisualStyleBackColor = true;
            this.btnLabKaydet.Click += new System.EventHandler(this.btnLabKaydet_Click);
            // 
            // btnLab
            // 
            this.btnLab.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.seo;
            this.btnLab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLab.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLab.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLab.Location = new System.Drawing.Point(492, 81);
            this.btnLab.Name = "btnLab";
            this.btnLab.Size = new System.Drawing.Size(253, 235);
            this.btnLab.TabIndex = 46;
            this.btnLab.Text = "Laboratuvar Sonucu Sorgula";
            this.btnLab.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLab.UseVisualStyleBackColor = true;
            this.btnLab.Click += new System.EventHandler(this.btnLab_Click);
            // 
            // LabSonuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(755, 462);
            this.Controls.Add(this.btnLab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLabKaydet);
            this.Controls.Add(this.txtLabSonuc);
            this.Controls.Add(this.dateLab);
            this.Controls.Add(this.txtLabTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LabSonuc";
            this.Text = "LabSonuc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLabKaydet;
        private System.Windows.Forms.TextBox txtLabSonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLabTc;
        private System.Windows.Forms.DateTimePicker dateLab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLab;
    }
}