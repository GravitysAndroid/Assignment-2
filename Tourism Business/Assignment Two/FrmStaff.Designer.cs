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
            this.LblStaffRole = new System.Windows.Forms.Label();
            this.TxtStaffRole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblStaffRole
            // 
            this.LblStaffRole.AutoSize = true;
            this.LblStaffRole.Location = new System.Drawing.Point(12, 68);
            this.LblStaffRole.Name = "LblStaffRole";
            this.LblStaffRole.Size = new System.Drawing.Size(54, 13);
            this.LblStaffRole.TabIndex = 8;
            this.LblStaffRole.Text = "Staff Role";
            // 
            // TxtStaffRole
            // 
            this.TxtStaffRole.Location = new System.Drawing.Point(84, 65);
            this.TxtStaffRole.Name = "TxtStaffRole";
            this.TxtStaffRole.Size = new System.Drawing.Size(100, 20);
            this.TxtStaffRole.TabIndex = 9;
            // 
            // FrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 135);
            this.Controls.Add(this.TxtStaffRole);
            this.Controls.Add(this.LblStaffRole);
            this.Name = "FrmStaff";
            this.Text = "FrmStaff";
            this.Controls.SetChildIndex(this.LblStaffRole, 0);
            this.Controls.SetChildIndex(this.TxtStaffRole, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblStaffRole;
        private System.Windows.Forms.TextBox TxtStaffRole;
    }
}