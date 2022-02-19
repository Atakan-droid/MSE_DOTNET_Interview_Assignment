
namespace WinFormsApp
{
    partial class IstasyonEkle
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
            this.stationName = new System.Windows.Forms.TextBox();
            this.Pressure = new System.Windows.Forms.TextBox();
            this.heat = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.TextBox();
            this.productionLineId = new System.Windows.Forms.TextBox();
            this.maintenanceStaffId = new System.Windows.Forms.TextBox();
            this.addStation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stationName
            // 
            this.stationName.Location = new System.Drawing.Point(141, 41);
            this.stationName.Name = "stationName";
            this.stationName.PlaceholderText = "İstasyon Adı";
            this.stationName.Size = new System.Drawing.Size(215, 23);
            this.stationName.TabIndex = 0;
            // 
            // Pressure
            // 
            this.Pressure.Location = new System.Drawing.Point(141, 89);
            this.Pressure.Name = "Pressure";
            this.Pressure.PlaceholderText = "Basınç";
            this.Pressure.Size = new System.Drawing.Size(215, 23);
            this.Pressure.TabIndex = 1;
            // 
            // heat
            // 
            this.heat.Location = new System.Drawing.Point(141, 136);
            this.heat.Name = "heat";
            this.heat.PlaceholderText = "Isı";
            this.heat.Size = new System.Drawing.Size(215, 23);
            this.heat.TabIndex = 2;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(141, 182);
            this.status.Name = "status";
            this.status.PlaceholderText = "Durum";
            this.status.Size = new System.Drawing.Size(215, 23);
            this.status.TabIndex = 3;
            // 
            // productionLineId
            // 
            this.productionLineId.Location = new System.Drawing.Point(141, 231);
            this.productionLineId.Name = "productionLineId";
            this.productionLineId.PlaceholderText = "Üretim Yolu Id";
            this.productionLineId.Size = new System.Drawing.Size(215, 23);
            this.productionLineId.TabIndex = 4;
            // 
            // maintenanceStaffId
            // 
            this.maintenanceStaffId.Location = new System.Drawing.Point(141, 278);
            this.maintenanceStaffId.Name = "maintenanceStaffId";
            this.maintenanceStaffId.PlaceholderText = "Bakım Çalışanı Id";
            this.maintenanceStaffId.Size = new System.Drawing.Size(215, 23);
            this.maintenanceStaffId.TabIndex = 5;
            // 
            // addStation
            // 
            this.addStation.Location = new System.Drawing.Point(141, 348);
            this.addStation.Name = "addStation";
            this.addStation.Size = new System.Drawing.Size(215, 53);
            this.addStation.TabIndex = 6;
            this.addStation.Text = "Ekle";
            this.addStation.UseVisualStyleBackColor = true;
            this.addStation.Click += new System.EventHandler(this.addStation_Click);
            // 
            // IstasyonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 447);
            this.Controls.Add(this.addStation);
            this.Controls.Add(this.maintenanceStaffId);
            this.Controls.Add(this.productionLineId);
            this.Controls.Add(this.status);
            this.Controls.Add(this.heat);
            this.Controls.Add(this.Pressure);
            this.Controls.Add(this.stationName);
            this.Name = "IstasyonEkle";
            this.Text = "IstasyonEkle";
            this.Load += new System.EventHandler(this.IstasyonEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stationName;
        private System.Windows.Forms.TextBox Pressure;
        private System.Windows.Forms.TextBox heat;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.TextBox productionLineId;
        private System.Windows.Forms.TextBox maintenanceStaffId;
        private System.Windows.Forms.Button addStation;
    }
}