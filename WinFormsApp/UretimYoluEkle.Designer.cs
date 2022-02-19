
namespace WinFormsApp
{
    partial class UretimYoluEkle
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
            this.addLine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lineName
            // 
            this.lineName.Location = new System.Drawing.Point(123, 27);
            this.lineName.Name = "lineName";
            this.lineName.PlaceholderText = "Üretim Yolu Adı";
            this.lineName.Size = new System.Drawing.Size(183, 23);
            this.lineName.TabIndex = 0;
            // 
            // addLine
            // 
            this.addLine.Location = new System.Drawing.Point(123, 82);
            this.addLine.Name = "addLine";
            this.addLine.Size = new System.Drawing.Size(183, 33);
            this.addLine.TabIndex = 1;
            this.addLine.Text = "Ekle";
            this.addLine.UseVisualStyleBackColor = true;
            this.addLine.Click += new System.EventHandler(this.addLine_Click);
            // 
            // UretimYoluEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 150);
            this.Controls.Add(this.addLine);
            this.Controls.Add(this.lineName);
            this.Name = "UretimYoluEkle";
            this.Text = "UretimYoluEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lineName;
        private System.Windows.Forms.Button addLine;
    }
}