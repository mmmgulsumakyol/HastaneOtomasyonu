namespace HastaneOtomasyonu
{
    partial class LabSonucSorgu
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
            this.dtSekLabHastaRand = new System.Windows.Forms.DataGridView();
            this.txtSekLabHastc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSekLabSorgula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtSekLabHastaRand)).BeginInit();
            this.SuspendLayout();
            // 
            // dtSekLabHastaRand
            // 
            this.dtSekLabHastaRand.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtSekLabHastaRand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSekLabHastaRand.Location = new System.Drawing.Point(33, 142);
            this.dtSekLabHastaRand.Name = "dtSekLabHastaRand";
            this.dtSekLabHastaRand.RowHeadersWidth = 51;
            this.dtSekLabHastaRand.RowTemplate.Height = 24;
            this.dtSekLabHastaRand.Size = new System.Drawing.Size(743, 335);
            this.dtSekLabHastaRand.TabIndex = 50;
            // 
            // txtSekLabHastc
            // 
            this.txtSekLabHastc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSekLabHastc.Location = new System.Drawing.Point(248, 93);
            this.txtSekLabHastc.Name = "txtSekLabHastc";
            this.txtSekLabHastc.Size = new System.Drawing.Size(239, 34);
            this.txtSekLabHastc.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(27, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 33);
            this.label1.TabIndex = 48;
            this.label1.Text = "Hasta T.C. No:\r\n";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(176, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(384, 33);
            this.label15.TabIndex = 47;
            this.label15.Text = "Laboratuvar Sonuç Sorgula\r\n";
            // 
            // btnSekLabSorgula
            // 
            this.btnSekLabSorgula.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.magnifying_glass;
            this.btnSekLabSorgula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSekLabSorgula.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnSekLabSorgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSekLabSorgula.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSekLabSorgula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSekLabSorgula.Location = new System.Drawing.Point(502, 84);
            this.btnSekLabSorgula.Name = "btnSekLabSorgula";
            this.btnSekLabSorgula.Size = new System.Drawing.Size(223, 43);
            this.btnSekLabSorgula.TabIndex = 51;
            this.btnSekLabSorgula.Text = "Sorgula  ";
            this.btnSekLabSorgula.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSekLabSorgula.UseVisualStyleBackColor = true;
            // 
            // LabSonucSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(802, 514);
            this.Controls.Add(this.btnSekLabSorgula);
            this.Controls.Add(this.dtSekLabHastaRand);
            this.Controls.Add(this.txtSekLabHastc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Name = "LabSonucSorgu";
            this.Text = "LabSonucSorgu";
            ((System.ComponentModel.ISupportInitialize)(this.dtSekLabHastaRand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSekLabSorgula;
        private System.Windows.Forms.DataGridView dtSekLabHastaRand;
        private System.Windows.Forms.TextBox txtSekLabHastc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
    }
}