
namespace KutuphaneOtomasyonu
{
    partial class Ogrenci_KitapArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrenci_KitapArama));
            this.pictureBox_CikisYap = new System.Windows.Forms.PictureBox();
            this.lbl_Baslik = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.btn_KitapGoster = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_KitapAd = new System.Windows.Forms.Label();
            this.lbl_KitapSayfa = new System.Windows.Forms.Label();
            this.lbl_KitapYazar = new System.Windows.Forms.Label();
            this.lbl_KitapTuru = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView_KitapListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CikisYap)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KitapListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_CikisYap
            // 
            this.pictureBox_CikisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_CikisYap.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_CikisYap.Image")));
            this.pictureBox_CikisYap.Location = new System.Drawing.Point(1023, 33);
            this.pictureBox_CikisYap.Name = "pictureBox_CikisYap";
            this.pictureBox_CikisYap.Size = new System.Drawing.Size(66, 63);
            this.pictureBox_CikisYap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_CikisYap.TabIndex = 11;
            this.pictureBox_CikisYap.TabStop = false;
            this.pictureBox_CikisYap.Click += new System.EventHandler(this.pictureBox_CikisYap_Click);
            // 
            // lbl_Baslik
            // 
            this.lbl_Baslik.AutoSize = true;
            this.lbl_Baslik.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Baslik.ForeColor = System.Drawing.Color.Black;
            this.lbl_Baslik.Location = new System.Drawing.Point(502, 47);
            this.lbl_Baslik.Name = "lbl_Baslik";
            this.lbl_Baslik.Size = new System.Drawing.Size(197, 32);
            this.lbl_Baslik.TabIndex = 13;
            this.lbl_Baslik.Text = "Kitap Bilgileri ";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(740, 231);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(145, 22);
            this.txt_Id.TabIndex = 14;
            this.txt_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Id_KeyPress);
            // 
            // btn_KitapGoster
            // 
            this.btn_KitapGoster.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_KitapGoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KitapGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KitapGoster.ForeColor = System.Drawing.Color.Black;
            this.btn_KitapGoster.Location = new System.Drawing.Point(898, 218);
            this.btn_KitapGoster.Name = "btn_KitapGoster";
            this.btn_KitapGoster.Size = new System.Drawing.Size(193, 42);
            this.btn_KitapGoster.TabIndex = 22;
            this.btn_KitapGoster.Text = "Kitabı Göster";
            this.btn_KitapGoster.UseVisualStyleBackColor = false;
            this.btn_KitapGoster.Click += new System.EventHandler(this.btn_KitapGoster_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(600, 231);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 18);
            this.label16.TabIndex = 23;
            this.label16.Text = "Kitap ID Giriniz ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Kitap Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(285, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Kitap Türü :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Sayfa Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(270, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Kitap Yazarı :";
            // 
            // lbl_KitapAd
            // 
            this.lbl_KitapAd.AutoSize = true;
            this.lbl_KitapAd.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KitapAd.Location = new System.Drawing.Point(129, 76);
            this.lbl_KitapAd.Name = "lbl_KitapAd";
            this.lbl_KitapAd.Size = new System.Drawing.Size(28, 18);
            this.lbl_KitapAd.TabIndex = 23;
            this.lbl_KitapAd.Text = "00";
            // 
            // lbl_KitapSayfa
            // 
            this.lbl_KitapSayfa.AutoSize = true;
            this.lbl_KitapSayfa.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KitapSayfa.Location = new System.Drawing.Point(129, 180);
            this.lbl_KitapSayfa.Name = "lbl_KitapSayfa";
            this.lbl_KitapSayfa.Size = new System.Drawing.Size(28, 18);
            this.lbl_KitapSayfa.TabIndex = 23;
            this.lbl_KitapSayfa.Text = "00";
            // 
            // lbl_KitapYazar
            // 
            this.lbl_KitapYazar.AutoSize = true;
            this.lbl_KitapYazar.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KitapYazar.Location = new System.Drawing.Point(387, 234);
            this.lbl_KitapYazar.Name = "lbl_KitapYazar";
            this.lbl_KitapYazar.Size = new System.Drawing.Size(28, 18);
            this.lbl_KitapYazar.TabIndex = 23;
            this.lbl_KitapYazar.Text = "00";
            // 
            // lbl_KitapTuru
            // 
            this.lbl_KitapTuru.AutoSize = true;
            this.lbl_KitapTuru.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KitapTuru.Location = new System.Drawing.Point(408, 127);
            this.lbl_KitapTuru.Name = "lbl_KitapTuru";
            this.lbl_KitapTuru.Size = new System.Drawing.Size(28, 18);
            this.lbl_KitapTuru.TabIndex = 23;
            this.lbl_KitapTuru.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(155, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 32);
            this.label9.TabIndex = 13;
            this.label9.Text = "Kitap Detayları";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbl_KitapTuru);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_KitapYazar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_KitapSayfa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_KitapAd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(548, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 292);
            this.panel1.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OldLace;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.dataGridView_KitapListesi);
            this.panel3.Location = new System.Drawing.Point(63, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 270);
            this.panel3.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(145, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 32);
            this.label10.TabIndex = 13;
            this.label10.Text = "Kitap Listesi";
            // 
            // dataGridView_KitapListesi
            // 
            this.dataGridView_KitapListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_KitapListesi.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_KitapListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KitapListesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_KitapListesi.Location = new System.Drawing.Point(22, 57);
            this.dataGridView_KitapListesi.Name = "dataGridView_KitapListesi";
            this.dataGridView_KitapListesi.RowHeadersWidth = 51;
            this.dataGridView_KitapListesi.RowTemplate.Height = 24;
            this.dataGridView_KitapListesi.Size = new System.Drawing.Size(427, 201);
            this.dataGridView_KitapListesi.TabIndex = 12;
            this.dataGridView_KitapListesi.SelectionChanged += new System.EventHandler(this.dataGridView_KitapListesi_SelectionChanged);
            // 
            // Ogrenci_KitapArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1201, 721);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btn_KitapGoster);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Baslik);
            this.Controls.Add(this.pictureBox_CikisYap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ogrenci_KitapArama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Ogrenci_KitapArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CikisYap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KitapListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_CikisYap;
        private System.Windows.Forms.Label lbl_Baslik;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Button btn_KitapGoster;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_KitapAd;
        private System.Windows.Forms.Label lbl_KitapSayfa;
        private System.Windows.Forms.Label lbl_KitapYazar;
        private System.Windows.Forms.Label lbl_KitapTuru;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView_KitapListesi;
    }
}