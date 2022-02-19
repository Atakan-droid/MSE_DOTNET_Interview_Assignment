
namespace WinFormsApp
{
    partial class UretimYolu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getall = new System.Windows.Forms.Button();
            this.getbyid = new System.Windows.Forms.Button();
            this.addLine = new System.Windows.Forms.Button();
            this.updateLine = new System.Windows.Forms.Button();
            this.deleteLine = new System.Windows.Forms.Button();
            this.geridon = new System.Windows.Forms.Button();
            this.getbyidText = new System.Windows.Forms.TextBox();
            this.updateIdText = new System.Windows.Forms.TextBox();
            this.deleteIdText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(920, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // getall
            // 
            this.getall.Location = new System.Drawing.Point(12, 116);
            this.getall.Name = "getall";
            this.getall.Size = new System.Drawing.Size(151, 61);
            this.getall.TabIndex = 1;
            this.getall.Text = "Hepsini Getir";
            this.getall.UseVisualStyleBackColor = true;
            this.getall.Click += new System.EventHandler(this.getall_Click);
            // 
            // getbyid
            // 
            this.getbyid.Location = new System.Drawing.Point(191, 116);
            this.getbyid.Name = "getbyid";
            this.getbyid.Size = new System.Drawing.Size(151, 61);
            this.getbyid.TabIndex = 2;
            this.getbyid.Text = "Id ye Göre Getir";
            this.getbyid.UseVisualStyleBackColor = true;
            this.getbyid.Click += new System.EventHandler(this.getbyid_Click);
            // 
            // addLine
            // 
            this.addLine.Location = new System.Drawing.Point(387, 116);
            this.addLine.Name = "addLine";
            this.addLine.Size = new System.Drawing.Size(151, 61);
            this.addLine.TabIndex = 3;
            this.addLine.Text = "Ekle";
            this.addLine.UseVisualStyleBackColor = true;
            this.addLine.Click += new System.EventHandler(this.addLine_Click);
            // 
            // updateLine
            // 
            this.updateLine.Location = new System.Drawing.Point(587, 116);
            this.updateLine.Name = "updateLine";
            this.updateLine.Size = new System.Drawing.Size(151, 61);
            this.updateLine.TabIndex = 4;
            this.updateLine.Text = "Güncelle";
            this.updateLine.UseVisualStyleBackColor = true;
            this.updateLine.Click += new System.EventHandler(this.updateLine_Click);
            // 
            // deleteLine
            // 
            this.deleteLine.Location = new System.Drawing.Point(781, 116);
            this.deleteLine.Name = "deleteLine";
            this.deleteLine.Size = new System.Drawing.Size(151, 61);
            this.deleteLine.TabIndex = 5;
            this.deleteLine.Text = "Sil";
            this.deleteLine.UseVisualStyleBackColor = true;
            this.deleteLine.Click += new System.EventHandler(this.deleteLine_Click);
            // 
            // geridon
            // 
            this.geridon.Location = new System.Drawing.Point(13, 13);
            this.geridon.Name = "geridon";
            this.geridon.Size = new System.Drawing.Size(75, 23);
            this.geridon.TabIndex = 6;
            this.geridon.Text = "Geri Dön";
            this.geridon.UseVisualStyleBackColor = true;
            this.geridon.Click += new System.EventHandler(this.geridon_Click);
            // 
            // getbyidText
            // 
            this.getbyidText.Location = new System.Drawing.Point(191, 85);
            this.getbyidText.Name = "getbyidText";
            this.getbyidText.PlaceholderText = "Id Giriniz";
            this.getbyidText.Size = new System.Drawing.Size(151, 23);
            this.getbyidText.TabIndex = 7;
            // 
            // updateIdText
            // 
            this.updateIdText.Location = new System.Drawing.Point(587, 85);
            this.updateIdText.Name = "updateIdText";
            this.updateIdText.PlaceholderText = "Id Giriniz";
            this.updateIdText.Size = new System.Drawing.Size(151, 23);
            this.updateIdText.TabIndex = 8;
            // 
            // deleteIdText
            // 
            this.deleteIdText.Location = new System.Drawing.Point(781, 85);
            this.deleteIdText.Name = "deleteIdText";
            this.deleteIdText.PlaceholderText = "Id Giriniz";
            this.deleteIdText.Size = new System.Drawing.Size(151, 23);
            this.deleteIdText.TabIndex = 9;
            // 
            // UretimYolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 447);
            this.Controls.Add(this.deleteIdText);
            this.Controls.Add(this.updateIdText);
            this.Controls.Add(this.getbyidText);
            this.Controls.Add(this.geridon);
            this.Controls.Add(this.deleteLine);
            this.Controls.Add(this.updateLine);
            this.Controls.Add(this.addLine);
            this.Controls.Add(this.getbyid);
            this.Controls.Add(this.getall);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UretimYolu";
            this.Text = "UretimYolu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button getall;
        private System.Windows.Forms.Button getbyid;
        private System.Windows.Forms.Button addLine;
        private System.Windows.Forms.Button updateLine;
        private System.Windows.Forms.Button deleteLine;
        private System.Windows.Forms.Button geridon;
        private System.Windows.Forms.TextBox getbyidText;
        private System.Windows.Forms.TextBox updateIdText;
        private System.Windows.Forms.TextBox deleteIdText;
    }
}