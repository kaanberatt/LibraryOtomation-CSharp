
namespace KutuphaneOtomasyonu
{
    partial class Ogrenci_GirisForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrenci_GirisForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_OgrnNo = new System.Windows.Forms.TextBox();
            this.textBox_OgrnSifre = new System.Windows.Forms.TextBox();
            this.btn_OgrnGirisYap = new System.Windows.Forms.Button();
            this.pictureBox_CikisYap = new System.Windows.Forms.PictureBox();
            this.pictureBox_OncekiForm = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CikisYap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OncekiForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(235, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Giriş ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Öğrenci Numarası :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Öğrenci Şifre : ";
            // 
            // textBox_OgrnNo
            // 
            this.textBox_OgrnNo.Location = new System.Drawing.Point(227, 131);
            this.textBox_OgrnNo.Name = "textBox_OgrnNo";
            this.textBox_OgrnNo.Size = new System.Drawing.Size(163, 22);
            this.textBox_OgrnNo.TabIndex = 1;
            this.textBox_OgrnNo.TextChanged += new System.EventHandler(this.textBox_OgrnTc_TextChanged);
            this.textBox_OgrnNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_OgrnTc_KeyPress);
            // 
            // textBox_OgrnSifre
            // 
            this.textBox_OgrnSifre.Location = new System.Drawing.Point(227, 195);
            this.textBox_OgrnSifre.Name = "textBox_OgrnSifre";
            this.textBox_OgrnSifre.Size = new System.Drawing.Size(163, 22);
            this.textBox_OgrnSifre.TabIndex = 1;
            this.textBox_OgrnSifre.UseSystemPasswordChar = true;
            // 
            // btn_OgrnGirisYap
            // 
            this.btn_OgrnGirisYap.Location = new System.Drawing.Point(299, 253);
            this.btn_OgrnGirisYap.Name = "btn_OgrnGirisYap";
            this.btn_OgrnGirisYap.Size = new System.Drawing.Size(91, 43);
            this.btn_OgrnGirisYap.TabIndex = 2;
            this.btn_OgrnGirisYap.Text = "Giriş Yap";
            this.btn_OgrnGirisYap.UseVisualStyleBackColor = true;
            this.btn_OgrnGirisYap.Click += new System.EventHandler(this.btn_OgrnGirisYap_Click);
            // 
            // pictureBox_CikisYap
            // 
            this.pictureBox_CikisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_CikisYap.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_CikisYap.Image")));
            this.pictureBox_CikisYap.Location = new System.Drawing.Point(732, 1);
            this.pictureBox_CikisYap.Name = "pictureBox_CikisYap";
            this.pictureBox_CikisYap.Size = new System.Drawing.Size(66, 63);
            this.pictureBox_CikisYap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_CikisYap.TabIndex = 3;
            this.pictureBox_CikisYap.TabStop = false;
            this.pictureBox_CikisYap.Click += new System.EventHandler(this.pictureBox_CikisYap_Click);
            // 
            // pictureBox_OncekiForm
            // 
            this.pictureBox_OncekiForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_OncekiForm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_OncekiForm.Image")));
            this.pictureBox_OncekiForm.Location = new System.Drawing.Point(2, 1);
            this.pictureBox_OncekiForm.Name = "pictureBox_OncekiForm";
            this.pictureBox_OncekiForm.Size = new System.Drawing.Size(66, 63);
            this.pictureBox_OncekiForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_OncekiForm.TabIndex = 3;
            this.pictureBox_OncekiForm.TabStop = false;
            this.pictureBox_OncekiForm.Click += new System.EventHandler(this.pictureBox_OncekiForm_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(406, 197);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Ogrenci_GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox_OncekiForm);
            this.Controls.Add(this.pictureBox_CikisYap);
            this.Controls.Add(this.btn_OgrnGirisYap);
            this.Controls.Add(this.textBox_OgrnSifre);
            this.Controls.Add(this.textBox_OgrnNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ogrenci_GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Giriş";
            this.Load += new System.EventHandler(this.Ogrenci_GirisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CikisYap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OncekiForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_OgrnNo;
        private System.Windows.Forms.TextBox textBox_OgrnSifre;
        private System.Windows.Forms.Button btn_OgrnGirisYap;
        private System.Windows.Forms.PictureBox pictureBox_CikisYap;
        private System.Windows.Forms.PictureBox pictureBox_OncekiForm;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}