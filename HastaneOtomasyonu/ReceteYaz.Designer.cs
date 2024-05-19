namespace HastaneOtomasyonu
{
    partial class ReceteYaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceteYaz));
            this.txtRecSonuc = new System.Windows.Forms.TextBox();
            this.dateRec = new System.Windows.Forms.DateTimePicker();
            this.txtRecTc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReceteG = new System.Windows.Forms.Button();
            this.btnRecKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRecSonuc
            // 
            this.txtRecSonuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRecSonuc.Location = new System.Drawing.Point(246, 243);
            this.txtRecSonuc.MaxLength = 327678;
            this.txtRecSonuc.Name = "txtRecSonuc";
            this.txtRecSonuc.Size = new System.Drawing.Size(284, 136);
            this.txtRecSonuc.TabIndex = 12;
            // 
            // dateRec
            // 
            this.dateRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateRec.Location = new System.Drawing.Point(246, 180);
            this.dateRec.Name = "dateRec";
            this.dateRec.Size = new System.Drawing.Size(284, 34);
            this.dateRec.TabIndex = 11;
            // 
            // txtRecTc
            // 
            this.txtRecTc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRecTc.Location = new System.Drawing.Point(246, 125);
            this.txtRecTc.Name = "txtRecTc";
            this.txtRecTc.Size = new System.Drawing.Size(284, 27);
            this.txtRecTc.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(68, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sonuç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hasta T.C. No";
            // 
            // btnReceteG
            // 
            this.btnReceteG.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.cv;
            this.btnReceteG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReceteG.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnReceteG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceteG.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReceteG.Location = new System.Drawing.Point(292, 12);
            this.btnReceteG.Name = "btnReceteG";
            this.btnReceteG.Size = new System.Drawing.Size(410, 58);
            this.btnReceteG.TabIndex = 14;
            this.btnReceteG.Text = "Reçete Görüntüle";
            this.btnReceteG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReceteG.UseVisualStyleBackColor = true;
            this.btnReceteG.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRecKaydet
            // 
            this.btnRecKaydet.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.diskette;
            this.btnRecKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecKaydet.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnRecKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecKaydet.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRecKaydet.Location = new System.Drawing.Point(155, 394);
            this.btnRecKaydet.Name = "btnRecKaydet";
            this.btnRecKaydet.Size = new System.Drawing.Size(345, 58);
            this.btnRecKaydet.TabIndex = 13;
            this.btnRecKaydet.Text = "Kaydet";
            this.btnRecKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecKaydet.UseVisualStyleBackColor = true;
            // 
            // ReceteYaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(724, 475);
            this.Controls.Add(this.btnReceteG);
            this.Controls.Add(this.btnRecKaydet);
            this.Controls.Add(this.txtRecSonuc);
            this.Controls.Add(this.dateRec);
            this.Controls.Add(this.txtRecTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReceteYaz";
            this.Text = "Reçete Yaz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecKaydet;
        private System.Windows.Forms.TextBox txtRecSonuc;
        private System.Windows.Forms.DateTimePicker dateRec;
        private System.Windows.Forms.TextBox txtRecTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReceteG;
    }
}