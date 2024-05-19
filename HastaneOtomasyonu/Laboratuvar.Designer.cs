namespace HastaneOtomasyonu
{
    partial class Laboratuvar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHastaTc = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtHastaSonuc = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta T.C. No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(44, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sonuç";
            // 
            // txtHastaTc
            // 
            this.txtHastaTc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHastaTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHastaTc.Location = new System.Drawing.Point(222, 64);
            this.txtHastaTc.Name = "txtHastaTc";
            this.txtHastaTc.Size = new System.Drawing.Size(284, 27);
            this.txtHastaTc.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(222, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(284, 34);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // txtHastaSonuc
            // 
            this.txtHastaSonuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHastaSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHastaSonuc.Location = new System.Drawing.Point(222, 182);
            this.txtHastaSonuc.MaxLength = 327678;
            this.txtHastaSonuc.Name = "txtHastaSonuc";
            this.txtHastaSonuc.Size = new System.Drawing.Size(284, 136);
            this.txtHastaSonuc.TabIndex = 5;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.diskette;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(114, 333);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(362, 59);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // Laboratuvar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtHastaSonuc);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtHastaTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Laboratuvar";
            this.Text = "Laboratuvar Sonuç";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHastaTc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtHastaSonuc;
        private System.Windows.Forms.Button btnKaydet;
    }
}