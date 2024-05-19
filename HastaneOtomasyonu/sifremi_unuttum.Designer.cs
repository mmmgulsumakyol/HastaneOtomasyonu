namespace HastaneOtomasyonu
{
    partial class sifremi_unuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sifremi_unuttum));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.btnyenile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "E-Posta:";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(303, 117);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(210, 22);
            this.txtTc.TabIndex = 14;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(303, 77);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(210, 22);
            this.txtEposta.TabIndex = 15;
            // 
            // btnyenile
            // 
            this.btnyenile.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.btnyenile.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.Ekran_görüntüsü_2024_05_11_123739;
            this.btnyenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnyenile.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnyenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyenile.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyenile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnyenile.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnyenile.Location = new System.Drawing.Point(160, 173);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(289, 44);
            this.btnyenile.TabIndex = 30;
            this.btnyenile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnyenile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnyenile.UseCompatibleTextRendering = true;
            this.btnyenile.UseVisualStyleBackColor = false;
            // 
            // sifremi_unuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(614, 320);
            this.Controls.Add(this.btnyenile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtEposta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sifremi_unuttum";
            this.Text = "Şifremi Unuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Button btnyenile;
    }
}