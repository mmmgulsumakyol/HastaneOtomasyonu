namespace HastaneOtomasyonu
{
    partial class SekIsmeGöreOda
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
            this.txtOdaSorgu = new System.Windows.Forms.TextBox();
            this.btnLab = new System.Windows.Forms.Button();
            this.dtSekOdaSorgu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtSekOdaSorgu)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(279, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 21);
            this.label15.TabIndex = 35;
            this.label15.Text = "İsme Göre Oda Sorgu";
            // 
            // txtOdaSorgu
            // 
            this.txtOdaSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdaSorgu.Location = new System.Drawing.Point(158, 99);
            this.txtOdaSorgu.Name = "txtOdaSorgu";
            this.txtOdaSorgu.Size = new System.Drawing.Size(252, 30);
            this.txtOdaSorgu.TabIndex = 36;
            // 
            // btnLab
            // 
            this.btnLab.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.seo;
            this.btnLab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLab.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLab.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLab.Location = new System.Drawing.Point(427, 68);
            this.btnLab.Name = "btnLab";
            this.btnLab.Size = new System.Drawing.Size(279, 67);
            this.btnLab.TabIndex = 37;
            this.btnLab.Text = "     Sorgula";
            this.btnLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLab.UseVisualStyleBackColor = true;
            // 
            // dtSekOdaSorgu
            // 
            this.dtSekOdaSorgu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtSekOdaSorgu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSekOdaSorgu.Location = new System.Drawing.Point(32, 152);
            this.dtSekOdaSorgu.Name = "dtSekOdaSorgu";
            this.dtSekOdaSorgu.RowHeadersWidth = 51;
            this.dtSekOdaSorgu.RowTemplate.Height = 24;
            this.dtSekOdaSorgu.Size = new System.Drawing.Size(741, 286);
            this.dtSekOdaSorgu.TabIndex = 38;
            // 
            // SekIsmeGöreOda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtSekOdaSorgu);
            this.Controls.Add(this.btnLab);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtOdaSorgu);
            this.Name = "SekIsmeGöreOda";
            this.Text = "İsme Göre Oda Öğren";
            ((System.ComponentModel.ISupportInitialize)(this.dtSekOdaSorgu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLab;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtOdaSorgu;
        private System.Windows.Forms.DataGridView dtSekOdaSorgu;
    }
}