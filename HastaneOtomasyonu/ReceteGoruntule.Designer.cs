namespace HastaneOtomasyonu
{
    partial class ReceteGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceteGoruntule));
            this.txtRecTc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtReceteGoruntule = new System.Windows.Forms.DataGridView();
            this.btnGoruntule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtReceteGoruntule)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRecTc
            // 
            this.txtRecTc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRecTc.Location = new System.Drawing.Point(217, 77);
            this.txtRecTc.Name = "txtRecTc";
            this.txtRecTc.Size = new System.Drawing.Size(337, 27);
            this.txtRecTc.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hasta T.C. No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Reçete";
            // 
            // dtReceteGoruntule
            // 
            this.dtReceteGoruntule.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtReceteGoruntule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtReceteGoruntule.Location = new System.Drawing.Point(217, 150);
            this.dtReceteGoruntule.Name = "dtReceteGoruntule";
            this.dtReceteGoruntule.RowHeadersWidth = 51;
            this.dtReceteGoruntule.RowTemplate.Height = 24;
            this.dtReceteGoruntule.Size = new System.Drawing.Size(546, 269);
            this.dtReceteGoruntule.TabIndex = 14;
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.cv;
            this.btnGoruntule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoruntule.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoruntule.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoruntule.Location = new System.Drawing.Point(473, 66);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(290, 54);
            this.btnGoruntule.TabIndex = 15;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoruntule.UseVisualStyleBackColor = true;
            // 
            // ReceteGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(877, 466);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.dtReceteGoruntule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRecTc);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReceteGoruntule";
            this.Text = "Reçete Görüntüle";
            ((System.ComponentModel.ISupportInitialize)(this.dtReceteGoruntule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtReceteGoruntule;
        private System.Windows.Forms.Button btnGoruntule;
    }
}