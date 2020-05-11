namespace Assignment_Two
{
    partial class FrmTourItems
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
            this.LstItems = new System.Windows.Forms.ListBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.LblCost = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstItems
            // 
            this.LstItems.FormattingEnabled = true;
            this.LstItems.Items.AddRange(new object[] {
            "Rope\t\t\tOther\t\t\t10",
            "4x4\t\t\tVehicle\t\t\t500",
            "Parachute\t\tOther\t\t\t100",
            "John\t\t\tStaff\t\t\t1000",
            "Lizzy\t\t\tStaff\t\t\t1200",
            "Anton\t\t\tStaff\t\t\t1500",
            "Rations\t\t\tOther\t\t\t500",
            "Water\t\t\tOther\t\t\t150"});
            this.LstItems.Location = new System.Drawing.Point(12, 25);
            this.LstItems.Name = "LstItems";
            this.LstItems.Size = new System.Drawing.Size(349, 212);
            this.LstItems.TabIndex = 0;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(12, 9);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(157, 9);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(31, 13);
            this.LblType.TabIndex = 2;
            this.LblType.Text = "Type";
            // 
            // LblCost
            // 
            this.LblCost.AutoSize = true;
            this.LblCost.Location = new System.Drawing.Point(300, 9);
            this.LblCost.Name = "LblCost";
            this.LblCost.Size = new System.Drawing.Size(28, 13);
            this.LblCost.TabIndex = 3;
            this.LblCost.Text = "Cost";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 243);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add Item";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(143, 243);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(286, 243);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(286, 296);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(12, 296);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 8;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(132, 301);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(86, 13);
            this.LblTotal.TabIndex = 9;
            this.LblTotal.Text = "Total Items Cost:";
            // 
            // FrmTourItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 331);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblCost);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LstItems);
            this.Name = "FrmTourItems";
            this.Text = "Tour Items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstItems;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblCost;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label LblTotal;
    }
}