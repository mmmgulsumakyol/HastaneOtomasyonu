namespace HastaneOtomasyonu
{
    partial class HastaRandevuSorgula
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
            this.txtSekHastc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtSekHastaRand = new System.Windows.Forms.DataGridView();
            this.btnHastaSorgula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtSekHastaRand)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSekHastc
            // 
            this.txtSekHastc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSekHastc.Location = new System.Drawing.Point(250, 77);
            this.txtSekHastc.Name = "txtSekHastc";
            this.txtSekHastc.Size = new System.Drawing.Size(239, 34);
            this.txtSekHastc.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(39, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 33);
            this.label1.TabIndex = 42;
            this.label1.Text = "Hasta T.C. No:\r\n";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(196, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(330, 33);
            this.label15.TabIndex = 41;
            this.label15.Text = "Hasta Randevu Sorgula\r\n";
            // 
            // dtSekHastaRand
            // 
            this.dtSekHastaRand.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtSekHastaRand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSekHastaRand.Location = new System.Drawing.Point(35, 126);
            this.dtSekHastaRand.Name = "dtSekHastaRand";
            this.dtSekHastaRand.RowHeadersWidth = 51;
            this.dtSekHastaRand.RowTemplate.Height = 24;
            this.dtSekHastaRand.Size = new System.Drawing.Size(743, 335);
            this.dtSekHastaRand.TabIndex = 44;
            // 
            // btnHastaSorgula
            // 
            this.btnHastaSorgula.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.magnifying_glass;
            this.btnHastaSorgula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHastaSorgula.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnHastaSorgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaSorgula.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaSorgula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHastaSorgula.Location = new System.Drawing.Point(495, 68);
            this.btnHastaSorgula.Name = "btnHastaSorgula";
            this.btnHastaSorgula.Size = new System.Drawing.Size(283, 43);
            this.btnHastaSorgula.TabIndex = 46;
            this.btnHastaSorgula.Text = "Randevu Sorgula  ";
            this.btnHastaSorgula.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHastaSorgula.UseVisualStyleBackColor = true;
            // 
            // HastaRandevuSorgula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(810, 486);
            this.Controls.Add(this.btnHastaSorgula);
            this.Controls.Add(this.dtSekHastaRand);
            this.Controls.Add(this.txtSekHastc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Name = "HastaRandevuSorgula";
            this.Text = "HastaRandevuSorgula";
            ((System.ComponentModel.ISupportInitialize)(this.dtSekHastaRand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSekHastc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dtSekHastaRand;
        private System.Windows.Forms.Button btnHastaSorgula;
    }
}