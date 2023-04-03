namespace Demo
{
    partial class MainForm
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
            this.twilightButton1 = new TwilightUI.Controls.TwilightButton();
            this.SuspendLayout();
            // 
            // twilightButton1
            // 
            this.twilightButton1.Context = "Show Message";
            this.twilightButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twilightButton1.Location = new System.Drawing.Point(12, 399);
            this.twilightButton1.Name = "twilightButton1";
            this.twilightButton1.Size = new System.Drawing.Size(110, 39);
            this.twilightButton1.TabIndex = 0;
            this.twilightButton1.Text = "twilightButton1";
            this.twilightButton1.Click += new System.EventHandler(this.twilightButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.twilightButton1);
            this.Name = "MainForm";
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TwilightUI.Controls.TwilightButton twilightButton1;
    }
}

