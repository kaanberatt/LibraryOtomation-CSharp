
namespace KutuphaneOtomasyonu
{
    partial class Grafik_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grafik_Form));
            this.lbl_Baslik = new System.Windows.Forms.Label();
            this.pictureBox_CikisYap = new System.Windows.Forms.PictureBox();
            this.grafikKitap = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CikisYap)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Baslik
            // 
            this.lbl_Baslik.AutoSize = true;
            this.lbl_Baslik.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Baslik.ForeColor = System.Drawing.Color.Black;
            this.lbl_Baslik.Location = new System.Drawing.Point(482, 74);
            this.lbl_Baslik.Name = "lbl_Baslik";
            this.lbl_Baslik.Size = new System.Drawing.Size(172, 32);
            this.lbl_Baslik.TabIndex = 12;
            this.lbl_Baslik.Text = "Kitap Grafik";
            // 
            // pictureBox_CikisYap
            // 
            this.pictureBox_CikisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_CikisYap.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_CikisYap.Image")));
            this.pictureBox_CikisYap.Location = new System.Drawing.Point(980, 43);
            this.pictureBox_CikisYap.Name = "pictureBox_CikisYap";
            this.pictureBox_CikisYap.Size = new System.Drawing.Size(66, 63);
            this.pictureBox_CikisYap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_CikisYap.TabIndex = 14;
            this.pictureBox_CikisYap.TabStop = false;
            this.pictureBox_CikisYap.Click += new System.EventHandler(this.pictureBox_CikisYap_Click);
            // 
            // grafikKitap
            // 
            this.grafikKitap.Location = new System.Drawing.Point(82, 132);
            this.grafikKitap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grafikKitap.Name = "grafikKitap";
            this.grafikKitap.ScrollGrace = 0D;
            this.grafikKitap.ScrollMaxX = 0D;
            this.grafikKitap.ScrollMaxY = 0D;
            this.grafikKitap.ScrollMaxY2 = 0D;
            this.grafikKitap.ScrollMinX = 0D;
            this.grafikKitap.ScrollMinY = 0D;
            this.grafikKitap.ScrollMinY2 = 0D;
            this.grafikKitap.Size = new System.Drawing.Size(964, 484);
            this.grafikKitap.TabIndex = 15;
            this.grafikKitap.UseExtendedPrintDialog = true;
            // 
            // Grafik_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 679);
            this.Controls.Add(this.grafikKitap);
            this.Controls.Add(this.pictureBox_CikisYap);
            this.Controls.Add(this.lbl_Baslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Grafik_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafik_Form";
            this.Load += new System.EventHandler(this.Grafik_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CikisYap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Baslik;
        private System.Windows.Forms.PictureBox pictureBox_CikisYap;
        private ZedGraph.ZedGraphControl grafikKitap;
    }
}