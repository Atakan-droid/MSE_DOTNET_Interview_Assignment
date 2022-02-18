
namespace WinFormsApp
{
    partial class KullaniciEkle
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Mail ";
            this.textBox1.Size = new System.Drawing.Size(192, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Password";
            this.textBox2.Size = new System.Drawing.Size(192, 23);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 151);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Name";
            this.textBox3.Size = new System.Drawing.Size(192, 23);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(148, 198);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "Surname";
            this.textBox4.Size = new System.Drawing.Size(192, 23);
            this.textBox4.TabIndex = 3;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(148, 265);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(192, 60);
            this.add.TabIndex = 4;
            this.add.Text = "Ekle";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // KullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 401);
            this.Controls.Add(this.add);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "KullaniciEkle";
            this.Text = "KullaniciEkle";
            this.Load += new System.EventHandler(this.KullaniciEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button add;
    }
}