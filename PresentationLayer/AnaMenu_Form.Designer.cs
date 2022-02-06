
namespace KutuphaneOtomasyonu
{
    partial class AnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenu));
            this.lbl_baslik = new System.Windows.Forms.Label();
            this.pictureBox_Gorevligir = new System.Windows.Forms.PictureBox();
            this.pictureBox_OgrenciGir = new System.Windows.Forms.PictureBox();
            this.pictureBox_CikisYap = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gorevligir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OgrenciGir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CikisYap)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_baslik
            // 
            this.lbl_baslik.AutoSize = true;
            this.lbl_baslik.BackColor = System.Drawing.Color.Transparent;
            this.lbl_baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_baslik.Location = new System.Drawing.Point(143, 52);
            this.lbl_baslik.Name = "lbl_baslik";
            this.lbl_baslik.Size = new System.Drawing.Size(469, 29);
            this.lbl_baslik.TabIndex = 0;
            this.lbl_baslik.Text = "Kütüphane Otomasyonuna Hoşgeldiniz ";
            // 
            // pictureBox_Gorevligir
            // 
            this.pictureBox_Gorevligir.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Gorevligir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_Gorevligir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Gorevligir.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Gorevligir.Image")));
            this.pictureBox_Gorevligir.Location = new System.Drawing.Point(92, 137);
            this.pictureBox_Gorevligir.Name = "pictureBox_Gorevligir";
            this.pictureBox_Gorevligir.Size = new System.Drawing.Size(213, 184);
            this.pictureBox_Gorevligir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Gorevligir.TabIndex = 1;
            this.pictureBox_Gorevligir.TabStop = false;
            this.pictureBox_Gorevligir.Click += new System.EventHandler(this.pictureBox_Gorevligir_Click);
            // 
            // pictureBox_OgrenciGir
            // 
            this.pictureBox_OgrenciGir.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_OgrenciGir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_OgrenciGir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_OgrenciGir.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_OgrenciGir.Image")));
            this.pictureBox_OgrenciGir.Location = new System.Drawing.Point(460, 137);
            this.pictureBox_OgrenciGir.Name = "pictureBox_OgrenciGir";
            this.pictureBox_OgrenciGir.Size = new System.Drawing.Size(229, 184);
            this.pictureBox_OgrenciGir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_OgrenciGir.TabIndex = 1;
            this.pictureBox_OgrenciGir.TabStop = false;
            this.pictureBox_OgrenciGir.Click += new System.EventHandler(this.pictureBox_OgrenciGir_Click);
            // 
            // pictureBox_CikisYap
            // 
            this.pictureBox_CikisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_CikisYap.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_CikisYap.Image")));
            this.pictureBox_CikisYap.Location = new System.Drawing.Point(731, 3);
            this.pictureBox_CikisYap.Name = "pictureBox_CikisYap";
            this.pictureBox_CikisYap.Size = new System.Drawing.Size(66, 63);
            this.pictureBox_CikisYap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_CikisYap.TabIndex = 1;
            this.pictureBox_CikisYap.TabStop = false;
            this.pictureBox_CikisYap.Click += new System.EventHandler(this.pictureBox_CikisYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(143, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Görevli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(523, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Öğrenci";
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox_CikisYap);
            this.Controls.Add(this.pictureBox_OgrenciGir);
            this.Controls.Add(this.pictureBox_Gorevligir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_baslik);
            this.Name = "AnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gorevligir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OgrenciGir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CikisYap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_baslik;
        private System.Windows.Forms.PictureBox pictureBox_Gorevligir;
        private System.Windows.Forms.PictureBox pictureBox_OgrenciGir;
        private System.Windows.Forms.PictureBox pictureBox_CikisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

