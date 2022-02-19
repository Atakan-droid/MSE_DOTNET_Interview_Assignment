
namespace WinFormsApp
{
    partial class IstasyonGuncelle
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
            this.pressure = new System.Windows.Forms.TextBox();
            this.heat = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.TextBox();
            this.productionLineId = new System.Windows.Forms.TextBox();
            this.maintenanceStaffId = new System.Windows.Forms.TextBox();
            this.updateStation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stationName
            // 
            this.stationName.Location = new System.Drawing.Point(134, 54);
            this.stationName.Name = "stationName";
            this.stationName.Size = new System.Drawing.Size(265, 23);
            this.stationName.TabIndex = 0;
            // 
            // pressure
            // 
            this.pressure.Location = new System.Drawing.Point(134, 95);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(265, 23);
            this.pressure.TabIndex = 1;
            // 
            // heat
            // 
            this.heat.Location = new System.Drawing.Point(134, 139);
            this.heat.Name = "heat";
            this.heat.Size = new System.Drawing.Size(265, 23);
            this.heat.TabIndex = 2;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(134, 184);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(265, 23);
            this.status.TabIndex = 3;
            // 
            // productionLineId
            // 
            this.productionLineId.Location = new System.Drawing.Point(134, 237);
            this.productionLineId.Name = "productionLineId";
            this.productionLineId.Size = new System.Drawing.Size(265, 23);
            this.productionLineId.TabIndex = 4;
            // 
            // maintenanceStaffId
            // 
            this.maintenanceStaffId.Location = new System.Drawing.Point(134, 279);
            this.maintenanceStaffId.Name = "maintenanceStaffId";
            this.maintenanceStaffId.Size = new System.Drawing.Size(265, 23);
            this.maintenanceStaffId.TabIndex = 5;
            // 
            // updateStation
            // 
            this.updateStation.Location = new System.Drawing.Point(134, 340);
            this.updateStation.Name = "updateStation";
            this.updateStation.Size = new System.Drawing.Size(265, 50);
            this.updateStation.TabIndex = 6;
            this.updateStation.Text = "Güncelle";
            this.updateStation.UseVisualStyleBackColor = true;
            this.updateStation.Click += new System.EventHandler(this.updateStation_Click);
            // 
            // IstasyonGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 436);
            this.Controls.Add(this.updateStation);
            this.Controls.Add(this.maintenanceStaffId);
            this.Controls.Add(this.productionLineId);
            this.Controls.Add(this.status);
            this.Controls.Add(this.heat);
            this.Controls.Add(this.pressure);
            this.Controls.Add(this.stationName);
            this.Name = "IstasyonGuncelle";
            this.Text = "IstasyonGuncelle";
            this.Load += new System.EventHandler(this.IstasyonGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stationName;
        private System.Windows.Forms.TextBox pressure;
        private System.Windows.Forms.TextBox heat;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.TextBox productionLineId;
        private System.Windows.Forms.TextBox maintenanceStaffId;
        private System.Windows.Forms.Button updateStation;
    }
}