
namespace WinFormsApp
{
    partial class UretimYoluGuncelle
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
            this.lineName = new System.Windows.Forms.TextBox();
            this.updateLine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lineName
            // 
            this.lineName.Location = new System.Drawing.Point(127, 40);
            this.lineName.Name = "lineName";
            this.lineName.PlaceholderText = "Üretim Yolu Adı";
            this.lineName.Size = new System.Drawing.Size(252, 23);
            this.lineName.TabIndex = 0;
            // 
            // updateLine
            // 
            this.updateLine.Location = new System.Drawing.Point(127, 108);
            this.updateLine.Name = "updateLine";
            this.updateLine.Size = new System.Drawing.Size(252, 32);
            this.updateLine.TabIndex = 1;
            this.updateLine.Text = "Güncelle";
            this.updateLine.UseVisualStyleBackColor = true;
            this.updateLine.Click += new System.EventHandler(this.updateLine_Click);
            // 
            // UretimYoluGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 181);
            this.Controls.Add(this.updateLine);
            this.Controls.Add(this.lineName);
            this.Name = "UretimYoluGuncelle";
            this.Text = "UretimYoluGuncelle";
            this.Load += new System.EventHandler(this.UretimYoluGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lineName;
        private System.Windows.Forms.Button updateLine;
    }
}