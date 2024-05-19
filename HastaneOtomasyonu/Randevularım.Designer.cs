namespace HastaneOtomasyonu
{
    partial class Randevularım
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randevularım));
            this.label1 = new System.Windows.Forms.Label();
            this.dtRandevu = new System.Windows.Forms.DataGridView();
            this.btnRandevuYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtRandevu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Randevularım";
            // 
            // dtRandevu
            // 
            this.dtRandevu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRandevu.Location = new System.Drawing.Point(21, 49);
            this.dtRandevu.Name = "dtRandevu";
            this.dtRandevu.RowHeadersWidth = 51;
            this.dtRandevu.RowTemplate.Height = 24;
            this.dtRandevu.Size = new System.Drawing.Size(745, 341);
            this.dtRandevu.TabIndex = 1;
            // 
            // btnRandevuYenile
            // 
            this.btnRandevuYenile.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.refresh_data;
            this.btnRandevuYenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRandevuYenile.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnRandevuYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuYenile.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuYenile.Location = new System.Drawing.Point(156, 396);
            this.btnRandevuYenile.Name = "btnRandevuYenile";
            this.btnRandevuYenile.Size = new System.Drawing.Size(459, 169);
            this.btnRandevuYenile.TabIndex = 2;
            this.btnRandevuYenile.Text = "Yenile";
            this.btnRandevuYenile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRandevuYenile.UseVisualStyleBackColor = true;
            // 
            // Randevularım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.btnRandevuYenile);
            this.Controls.Add(this.dtRandevu);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Randevularım";
            this.Text = "Randevularım";
            ((System.ComponentModel.ISupportInitialize)(this.dtRandevu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtRandevu;
        private System.Windows.Forms.Button btnRandevuYenile;
    }
}