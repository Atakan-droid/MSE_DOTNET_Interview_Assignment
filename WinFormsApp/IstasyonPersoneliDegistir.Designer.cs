
namespace WinFormsApp
{
    partial class IstasyonPersoneliDegistir
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
            this.stationIdText = new System.Windows.Forms.TextBox();
            this.userIdText = new System.Windows.Forms.TextBox();
            this.updateStation1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stationIdText
            // 
            this.stationIdText.Location = new System.Drawing.Point(130, 72);
            this.stationIdText.Name = "stationIdText";
            this.stationIdText.PlaceholderText = "İstasyon Id ";
            this.stationIdText.Size = new System.Drawing.Size(161, 23);
            this.stationIdText.TabIndex = 0;
            // 
            // userIdText
            // 
            this.userIdText.Location = new System.Drawing.Point(129, 140);
            this.userIdText.Name = "userIdText";
            this.userIdText.PlaceholderText = "Kullanıcı Id";
            this.userIdText.Size = new System.Drawing.Size(161, 23);
            this.userIdText.TabIndex = 1;
            // 
            // updateStation1
            // 
            this.updateStation1.Location = new System.Drawing.Point(130, 210);
            this.updateStation1.Name = "updateStation1";
            this.updateStation1.Size = new System.Drawing.Size(161, 43);
            this.updateStation1.TabIndex = 2;
            this.updateStation1.Text = "Güncelle";
            this.updateStation1.UseVisualStyleBackColor = true;
            this.updateStation1.Click += new System.EventHandler(this.updateStation1_Click);
            // 
            // IstasyonPersoneliDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 303);
            this.Controls.Add(this.updateStation1);
            this.Controls.Add(this.userIdText);
            this.Controls.Add(this.stationIdText);
            this.Name = "IstasyonPersoneliDegistir";
            this.Text = "IstasyonPersoneliDegistir";
            this.Load += new System.EventHandler(this.IstasyonPersoneliDegistir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stationIdText;
        private System.Windows.Forms.TextBox userIdText;
        private System.Windows.Forms.Button updateStation1;
    }
}