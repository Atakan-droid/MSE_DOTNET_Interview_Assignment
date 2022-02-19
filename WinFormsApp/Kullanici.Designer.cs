
namespace WinFormsApp
{
    partial class Kullanici
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
            this.geridon = new System.Windows.Forms.Button();
            this.getall = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.getbyid = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_text = new System.Windows.Forms.TextBox();
            this.updateUserId = new System.Windows.Forms.TextBox();
            this.deleteUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // geridon
            // 
            this.geridon.Location = new System.Drawing.Point(13, 13);
            this.geridon.Name = "geridon";
            this.geridon.Size = new System.Drawing.Size(75, 23);
            this.geridon.TabIndex = 0;
            this.geridon.Text = "Geri Dön";
            this.geridon.UseVisualStyleBackColor = true;
            this.geridon.Click += new System.EventHandler(this.geridon_Click);
            // 
            // getall
            // 
            this.getall.Location = new System.Drawing.Point(29, 84);
            this.getall.Name = "getall";
            this.getall.Size = new System.Drawing.Size(149, 64);
            this.getall.TabIndex = 1;
            this.getall.Text = "Hepsini Getir";
            this.getall.UseVisualStyleBackColor = true;
            this.getall.Click += new System.EventHandler(this.getall_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(745, 84);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(150, 64);
            this.delete.TabIndex = 2;
            this.delete.Text = "Sil";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(578, 84);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(148, 64);
            this.update.TabIndex = 3;
            this.update.Text = "Güncelle";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(394, 84);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(164, 64);
            this.add.TabIndex = 4;
            this.add.Text = "Ekle";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // getbyid
            // 
            this.getbyid.Location = new System.Drawing.Point(215, 84);
            this.getbyid.Name = "getbyid";
            this.getbyid.Size = new System.Drawing.Size(150, 64);
            this.getbyid.TabIndex = 5;
            this.getbyid.Text = "Id ye Göre Getir";
            this.getbyid.UseVisualStyleBackColor = true;
            this.getbyid.Click += new System.EventHandler(this.getbyid_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(866, 245);
            this.dataGridView1.TabIndex = 6;
            // 
            // id_text
            // 
            this.id_text.Location = new System.Drawing.Point(215, 55);
            this.id_text.Name = "id_text";
            this.id_text.PlaceholderText = "Id Giriniz";
            this.id_text.Size = new System.Drawing.Size(150, 23);
            this.id_text.TabIndex = 7;
            // 
            // updateUserId
            // 
            this.updateUserId.Location = new System.Drawing.Point(578, 55);
            this.updateUserId.Name = "updateUserId";
            this.updateUserId.PlaceholderText = "Güncellemek için Id Giriniz";
            this.updateUserId.Size = new System.Drawing.Size(148, 23);
            this.updateUserId.TabIndex = 8;
            // 
            // deleteUser
            // 
            this.deleteUser.Location = new System.Drawing.Point(745, 55);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.PlaceholderText = "Silmek için Id Giriniz";
            this.deleteUser.Size = new System.Drawing.Size(150, 23);
            this.deleteUser.TabIndex = 9;
            // 
            // Kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 450);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.updateUserId);
            this.Controls.Add(this.id_text);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.getbyid);
            this.Controls.Add(this.add);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.getall);
            this.Controls.Add(this.geridon);
            this.Name = "Kullanici";
            this.Text = "Kullanici İşlemleri";
            this.Load += new System.EventHandler(this.Kullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geridon;
        private System.Windows.Forms.Button getall;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button getbyid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.TextBox updateUserId;
        private System.Windows.Forms.TextBox deleteUser;
    }
}