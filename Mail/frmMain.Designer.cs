namespace Mail
{
    partial class frmMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbKime = new System.Windows.Forms.TextBox();
            this.lblKime = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.lblKonu = new System.Windows.Forms.Label();
            this.tbKonu = new System.Windows.Forms.TextBox();
            this.tbKutu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbKime
            // 
            this.tbKime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKime.Location = new System.Drawing.Point(48, 6);
            this.tbKime.Name = "tbKime";
            this.tbKime.Size = new System.Drawing.Size(657, 20);
            this.tbKime.TabIndex = 0;
            // 
            // lblKime
            // 
            this.lblKime.AutoSize = true;
            this.lblKime.Location = new System.Drawing.Point(12, 9);
            this.lblKime.Name = "lblKime";
            this.lblKime.Size = new System.Drawing.Size(30, 13);
            this.lblKime.TabIndex = 1;
            this.lblKime.Text = "Kime";
            // 
            // btnGonder
            // 
            this.btnGonder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGonder.Location = new System.Drawing.Point(713, 6);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(75, 48);
            this.btnGonder.TabIndex = 5;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // lblKonu
            // 
            this.lblKonu.AutoSize = true;
            this.lblKonu.Location = new System.Drawing.Point(12, 35);
            this.lblKonu.Name = "lblKonu";
            this.lblKonu.Size = new System.Drawing.Size(32, 13);
            this.lblKonu.TabIndex = 3;
            this.lblKonu.Text = "Konu";
            // 
            // tbKonu
            // 
            this.tbKonu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKonu.Location = new System.Drawing.Point(48, 32);
            this.tbKonu.Name = "tbKonu";
            this.tbKonu.Size = new System.Drawing.Size(657, 20);
            this.tbKonu.TabIndex = 2;
            // 
            // tbKutu
            // 
            this.tbKutu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKutu.Location = new System.Drawing.Point(15, 60);
            this.tbKutu.Multiline = true;
            this.tbKutu.Name = "tbKutu";
            this.tbKutu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbKutu.Size = new System.Drawing.Size(773, 378);
            this.tbKutu.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbKutu);
            this.Controls.Add(this.tbKonu);
            this.Controls.Add(this.lblKonu);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.lblKime);
            this.Controls.Add(this.tbKime);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Gönder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKime;
        private System.Windows.Forms.Label lblKime;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label lblKonu;
        private System.Windows.Forms.TextBox tbKonu;
        private System.Windows.Forms.TextBox tbKutu;
    }
}

