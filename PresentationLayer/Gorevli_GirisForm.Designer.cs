
namespace KutuphaneOtomasyonu
{
    partial class Gorevli_GirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gorevli_GirisForm));
            this.pictureBox_CikisYap = new System.Windows.Forms.PictureBox();
            this.btn_grvlgiris = new System.Windows.Forms.Button();
            this.textBox_GrvlSifre = new System.Windows.Forms.TextBox();
            this.textBox_GrvlTc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_OncekiForm = new System.Windows.Forms.PictureBox();
            this.checkBox_Sifre_Gstr = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CikisYap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OncekiForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_CikisYap
            // 
            this.pictureBox_CikisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_CikisYap.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_CikisYap.Image")));
            this.pictureBox_CikisYap.Location = new System.Drawing.Point(722, 2);
            this.pictureBox_CikisYap.Name = "pictureBox_CikisYap";
            this.pictureBox_CikisYap.Size = new System.Drawing.Size(75, 74);
            this.pictureBox_CikisYap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_CikisYap.TabIndex = 10;
            this.pictureBox_CikisYap.TabStop = false;
            this.pictureBox_CikisYap.Click += new System.EventHandler(this.pictureBox_CikisYap_Click);
            // 
            // btn_grvlgiris
            // 
            this.btn_grvlgiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_grvlgiris.Location = new System.Drawing.Point(268, 277);
            this.btn_grvlgiris.Name = "btn_grvlgiris";
            this.btn_grvlgiris.Size = new System.Drawing.Size(91, 43);
            this.btn_grvlgiris.TabIndex = 9;
            this.btn_grvlgiris.Text = "Giriş Yap";
            this.btn_grvlgiris.UseVisualStyleBackColor = true;
            this.btn_grvlgiris.Click += new System.EventHandler(this.btn_grvlgiris_Click);
            // 
            // textBox_GrvlSifre
            // 
            this.textBox_GrvlSifre.Location = new System.Drawing.Point(226, 196);
            this.textBox_GrvlSifre.Name = "textBox_GrvlSifre";
            this.textBox_GrvlSifre.Size = new System.Drawing.Size(163, 22);
            this.textBox_GrvlSifre.TabIndex = 7;
            this.textBox_GrvlSifre.UseSystemPasswordChar = true;
            // 
            // textBox_GrvlTc
            // 
            this.textBox_GrvlTc.Location = new System.Drawing.Point(226, 132);
            this.textBox_GrvlTc.Name = "textBox_GrvlTc";
            this.textBox_GrvlTc.Size = new System.Drawing.Size(163, 22);
            this.textBox_GrvlTc.TabIndex = 8;
            this.textBox_GrvlTc.TextChanged += new System.EventHandler(this.textBox_GrvlTc_TextChanged);
            this.textBox_GrvlTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_GrvlTc_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Görevli Şifre : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Görevli Tc :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(223, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Görevli Giriş ";
            // 
            // pictureBox_OncekiForm
            // 
            this.pictureBox_OncekiForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_OncekiForm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_OncekiForm.Image")));
            this.pictureBox_OncekiForm.Location = new System.Drawing.Point(1, 2);
            this.pictureBox_OncekiForm.Name = "pictureBox_OncekiForm";
            this.pictureBox_OncekiForm.Size = new System.Drawing.Size(71, 74);
            this.pictureBox_OncekiForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_OncekiForm.TabIndex = 11;
            this.pictureBox_OncekiForm.TabStop = false;
            this.pictureBox_OncekiForm.Click += new System.EventHandler(this.pictureBox_OncekiForm_Click);
            // 
            // checkBox_Sifre_Gstr
            // 
            this.checkBox_Sifre_Gstr.AutoSize = true;
            this.checkBox_Sifre_Gstr.Location = new System.Drawing.Point(413, 198);
            this.checkBox_Sifre_Gstr.Name = "checkBox_Sifre_Gstr";
            this.checkBox_Sifre_Gstr.Size = new System.Drawing.Size(73, 21);
            this.checkBox_Sifre_Gstr.TabIndex = 12;
            this.checkBox_Sifre_Gstr.Text = "Göster";
            this.checkBox_Sifre_Gstr.UseVisualStyleBackColor = true;
            this.checkBox_Sifre_Gstr.CheckedChanged += new System.EventHandler(this.checkBox_Sifre_Gstr_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 500;
            this.errorProvider1.ContainerControl = this;
            // 
            // Gorevli_GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox_Sifre_Gstr);
            this.Controls.Add(this.pictureBox_OncekiForm);
            this.Controls.Add(this.pictureBox_CikisYap);
            this.Controls.Add(this.btn_grvlgiris);
            this.Controls.Add(this.textBox_GrvlSifre);
            this.Controls.Add(this.textBox_GrvlTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Gorevli_GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görevli Giriş";
            this.Load += new System.EventHandler(this.Gorevli_GirisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CikisYap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OncekiForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_CikisYap;
        private System.Windows.Forms.Button btn_grvlgiris;
        private System.Windows.Forms.TextBox textBox_GrvlSifre;
        private System.Windows.Forms.TextBox textBox_GrvlTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_OncekiForm;
        private System.Windows.Forms.CheckBox checkBox_Sifre_Gstr;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}