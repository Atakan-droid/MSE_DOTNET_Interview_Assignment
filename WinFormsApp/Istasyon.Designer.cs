
namespace WinFormsApp
{
    partial class Istasyon
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
            this.geridon = new System.Windows.Forms.Button();
            this.getall = new System.Windows.Forms.Button();
            this.getbyid = new System.Windows.Forms.Button();
            this.addstation = new System.Windows.Forms.Button();
            this.updatestation = new System.Windows.Forms.Button();
            this.deletestation = new System.Windows.Forms.Button();
            this.getbyidText = new System.Windows.Forms.TextBox();
            this.updateId = new System.Windows.Forms.TextBox();
            this.deleteId = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maintenanceStaff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(189, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(578, 252);
            this.dataGridView1.TabIndex = 0;
            // 
            // geridon
            // 
            this.geridon.Location = new System.Drawing.Point(13, 13);
            this.geridon.Name = "geridon";
            this.geridon.Size = new System.Drawing.Size(75, 23);
            this.geridon.TabIndex = 1;
            this.geridon.Text = "Geri Dön";
            this.geridon.UseVisualStyleBackColor = true;
            this.geridon.Click += new System.EventHandler(this.geridon_Click);
            // 
            // getall
            // 
            this.getall.Location = new System.Drawing.Point(31, 108);
            this.getall.Name = "getall";
            this.getall.Size = new System.Drawing.Size(134, 55);
            this.getall.TabIndex = 2;
            this.getall.Text = "Hepsini Getir";
            this.getall.UseVisualStyleBackColor = true;
            this.getall.Click += new System.EventHandler(this.getall_Click);
            // 
            // getbyid
            // 
            this.getbyid.Location = new System.Drawing.Point(189, 108);
            this.getbyid.Name = "getbyid";
            this.getbyid.Size = new System.Drawing.Size(134, 55);
            this.getbyid.TabIndex = 3;
            this.getbyid.Text = "Id ye Göre Getir";
            this.getbyid.UseVisualStyleBackColor = true;
            this.getbyid.Click += new System.EventHandler(this.button2_Click);
            // 
            // addstation
            // 
            this.addstation.Location = new System.Drawing.Point(338, 108);
            this.addstation.Name = "addstation";
            this.addstation.Size = new System.Drawing.Size(134, 55);
            this.addstation.TabIndex = 4;
            this.addstation.Text = "Ekle";
            this.addstation.UseVisualStyleBackColor = true;
            this.addstation.Click += new System.EventHandler(this.addstation_Click);
            // 
            // updatestation
            // 
            this.updatestation.Location = new System.Drawing.Point(487, 108);
            this.updatestation.Name = "updatestation";
            this.updatestation.Size = new System.Drawing.Size(134, 55);
            this.updatestation.TabIndex = 5;
            this.updatestation.Text = "Güncelle";
            this.updatestation.UseVisualStyleBackColor = true;
            this.updatestation.Click += new System.EventHandler(this.updatestation_Click);
            // 
            // deletestation
            // 
            this.deletestation.Location = new System.Drawing.Point(633, 108);
            this.deletestation.Name = "deletestation";
            this.deletestation.Size = new System.Drawing.Size(134, 55);
            this.deletestation.TabIndex = 6;
            this.deletestation.Text = "Sil";
            this.deletestation.UseVisualStyleBackColor = true;
            this.deletestation.Click += new System.EventHandler(this.deletestation_Click);
            // 
            // getbyidText
            // 
            this.getbyidText.Location = new System.Drawing.Point(189, 69);
            this.getbyidText.Name = "getbyidText";
            this.getbyidText.PlaceholderText = "Id Giriniz";
            this.getbyidText.Size = new System.Drawing.Size(134, 23);
            this.getbyidText.TabIndex = 7;
            // 
            // updateId
            // 
            this.updateId.Location = new System.Drawing.Point(487, 70);
            this.updateId.Name = "updateId";
            this.updateId.PlaceholderText = "Id Giriniz";
            this.updateId.Size = new System.Drawing.Size(134, 23);
            this.updateId.TabIndex = 8;
            // 
            // deleteId
            // 
            this.deleteId.Location = new System.Drawing.Point(633, 69);
            this.deleteId.Name = "deleteId";
            this.deleteId.PlaceholderText = "Id Giriniz";
            this.deleteId.Size = new System.Drawing.Size(134, 23);
            this.deleteId.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 266);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 23);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Üretim Yoluna Göre Getir";
            // 
            // maintenanceStaff
            // 
            this.maintenanceStaff.Location = new System.Drawing.Point(31, 347);
            this.maintenanceStaff.Name = "maintenanceStaff";
            this.maintenanceStaff.Size = new System.Drawing.Size(138, 54);
            this.maintenanceStaff.TabIndex = 12;
            this.maintenanceStaff.Text = "Bakım Personeli Ata";
            this.maintenanceStaff.UseVisualStyleBackColor = true;
            this.maintenanceStaff.Click += new System.EventHandler(this.maintenanceStaff_Click);
            // 
            // Istasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maintenanceStaff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.deleteId);
            this.Controls.Add(this.updateId);
            this.Controls.Add(this.getbyidText);
            this.Controls.Add(this.deletestation);
            this.Controls.Add(this.updatestation);
            this.Controls.Add(this.addstation);
            this.Controls.Add(this.getbyid);
            this.Controls.Add(this.getall);
            this.Controls.Add(this.geridon);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Istasyon";
            this.Text = "Istasyon";
            this.Load += new System.EventHandler(this.Istasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button geridon;
        private System.Windows.Forms.Button getall;
        private System.Windows.Forms.Button getbyid;
        private System.Windows.Forms.Button addstation;
        private System.Windows.Forms.Button updatestation;
        private System.Windows.Forms.Button deletestation;
        private System.Windows.Forms.TextBox getbyidText;
        private System.Windows.Forms.TextBox updateId;
        private System.Windows.Forms.TextBox deleteId;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button maintenanceStaff;
    }
}