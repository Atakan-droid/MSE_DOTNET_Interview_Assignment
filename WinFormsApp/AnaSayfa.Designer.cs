
namespace WinFormsApp
{
    partial class AnaSayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.KullaniciIslemleri = new System.Windows.Forms.Button();
            this.IstasyonIslemleri = new System.Windows.Forms.Button();
            this.UretimYolu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KullaniciIslemleri
            // 
            this.KullaniciIslemleri.Location = new System.Drawing.Point(68, 184);
            this.KullaniciIslemleri.Name = "KullaniciIslemleri";
            this.KullaniciIslemleri.Size = new System.Drawing.Size(160, 55);
            this.KullaniciIslemleri.TabIndex = 0;
            this.KullaniciIslemleri.Text = "Kullanıcı İşlemleri";
            this.KullaniciIslemleri.UseVisualStyleBackColor = true;
            this.KullaniciIslemleri.Click += new System.EventHandler(this.KullaniciIslemleri_Click);
            // 
            // IstasyonIslemleri
            // 
            this.IstasyonIslemleri.Location = new System.Drawing.Point(314, 184);
            this.IstasyonIslemleri.Name = "IstasyonIslemleri";
            this.IstasyonIslemleri.Size = new System.Drawing.Size(160, 55);
            this.IstasyonIslemleri.TabIndex = 1;
            this.IstasyonIslemleri.Text = "İstasyon İşlemleri";
            this.IstasyonIslemleri.UseVisualStyleBackColor = true;
            this.IstasyonIslemleri.Click += new System.EventHandler(this.IstasyonIslemleri_Click);
            // 
            // UretimYolu
            // 
            this.UretimYolu.Location = new System.Drawing.Point(553, 184);
            this.UretimYolu.Name = "UretimYolu";
            this.UretimYolu.Size = new System.Drawing.Size(160, 55);
            this.UretimYolu.TabIndex = 2;
            this.UretimYolu.Text = "Üretim Yolu İşlemleri";
            this.UretimYolu.UseVisualStyleBackColor = true;
            this.UretimYolu.Click += new System.EventHandler(this.UretimYolu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(203, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "DOTNET_DEV_Homework";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UretimYolu);
            this.Controls.Add(this.IstasyonIslemleri);
            this.Controls.Add(this.KullaniciIslemleri);
            this.Name = "AnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KullaniciIslemleri;
        private System.Windows.Forms.Button IstasyonIslemleri;
        private System.Windows.Forms.Button UretimYolu;
        private System.Windows.Forms.Label label1;
    }
}

