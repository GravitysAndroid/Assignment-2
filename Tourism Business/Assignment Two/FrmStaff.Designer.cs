namespace Assignment_Two
{
    partial class FrmStaff
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
            this.LblName = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.LblRate = new System.Windows.Forms.Label();
            this.TxtRate = new System.Windows.Forms.TextBox();
            this.TxtType = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(12, 16);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(38, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name:";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(12, 42);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(34, 13);
            this.LblType.TabIndex = 1;
            this.LblType.Text = "Type:";
            // 
            // LblRate
            // 
            this.LblRate.AutoSize = true;
            this.LblRate.Location = new System.Drawing.Point(12, 68);
            this.LblRate.Name = "LblRate";
            this.LblRate.Size = new System.Drawing.Size(59, 13);
            this.LblRate.TabIndex = 2;
            this.LblRate.Text = "Daily Rate:";
            // 
            // TxtRate
            // 
            this.TxtRate.Location = new System.Drawing.Point(79, 65);
            this.TxtRate.Name = "TxtRate";
            this.TxtRate.Size = new System.Drawing.Size(100, 20);
            this.TxtRate.TabIndex = 3;
            // 
            // TxtType
            // 
            this.TxtType.Location = new System.Drawing.Point(79, 39);
            this.TxtType.Name = "TxtType";
            this.TxtType.Size = new System.Drawing.Size(100, 20);
            this.TxtType.TabIndex = 4;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(79, 13);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 5;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(12, 106);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 6;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(113, 106);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // FrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 136);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtType);
            this.Controls.Add(this.TxtRate);
            this.Controls.Add(this.LblRate);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.LblName);
            this.Name = "FrmStaff";
            this.Text = "Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblRate;
        private System.Windows.Forms.TextBox TxtRate;
        private System.Windows.Forms.TextBox TxtType;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button Cancel;
    }
}