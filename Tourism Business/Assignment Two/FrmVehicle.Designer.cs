namespace Assignment_Two
{
    partial class FrmVehicle
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
            this.LblDetails = new System.Windows.Forms.Label();
            this.LblCharge = new System.Windows.Forms.Label();
            this.TxtDetails = new System.Windows.Forms.TextBox();
            this.TxtCharge = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblDetails
            // 
            this.LblDetails.AutoSize = true;
            this.LblDetails.Location = new System.Drawing.Point(12, 13);
            this.LblDetails.Name = "LblDetails";
            this.LblDetails.Size = new System.Drawing.Size(80, 13);
            this.LblDetails.TabIndex = 0;
            this.LblDetails.Text = "Vehicle Details:";
            // 
            // LblCharge
            // 
            this.LblCharge.AutoSize = true;
            this.LblCharge.Location = new System.Drawing.Point(12, 61);
            this.LblCharge.Name = "LblCharge";
            this.LblCharge.Size = new System.Drawing.Size(62, 13);
            this.LblCharge.TabIndex = 1;
            this.LblCharge.Text = "Km-Charge:";
            // 
            // TxtDetails
            // 
            this.TxtDetails.Location = new System.Drawing.Point(12, 29);
            this.TxtDetails.Name = "TxtDetails";
            this.TxtDetails.Size = new System.Drawing.Size(197, 20);
            this.TxtDetails.TabIndex = 2;
            // 
            // TxtCharge
            // 
            this.TxtCharge.Location = new System.Drawing.Point(80, 58);
            this.TxtCharge.Name = "TxtCharge";
            this.TxtCharge.Size = new System.Drawing.Size(129, 20);
            this.TxtCharge.TabIndex = 3;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(12, 93);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 4;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(134, 93);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 128);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtCharge);
            this.Controls.Add(this.TxtDetails);
            this.Controls.Add(this.LblCharge);
            this.Controls.Add(this.LblDetails);
            this.Name = "FrmVehicle";
            this.Text = "Vehicles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDetails;
        private System.Windows.Forms.Label LblCharge;
        private System.Windows.Forms.TextBox TxtDetails;
        private System.Windows.Forms.TextBox TxtCharge;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
    }
}