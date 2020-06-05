namespace Assignment_Two
{
    partial class FrmMain
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
            this.LstTours = new System.Windows.Forms.ListBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.LblPassMax = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.LblDistance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstTours
            // 
            this.LstTours.FormattingEnabled = true;
            this.LstTours.Location = new System.Drawing.Point(12, 25);
            this.LstTours.Name = "LstTours";
            this.LstTours.Size = new System.Drawing.Size(359, 238);
            this.LstTours.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(296, 269);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 269);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(95, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add New Tour";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(113, 269);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 3;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(194, 269);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(62, 9);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 5;
            this.LblName.Text = "Name";
            // 
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Location = new System.Drawing.Point(110, 9);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(55, 13);
            this.LblStartDate.TabIndex = 6;
            this.LblStartDate.Text = "Start Date";
            // 
            // LblPassMax
            // 
            this.LblPassMax.AutoSize = true;
            this.LblPassMax.Location = new System.Drawing.Point(184, 9);
            this.LblPassMax.Name = "LblPassMax";
            this.LblPassMax.Size = new System.Drawing.Size(85, 13);
            this.LblPassMax.TabIndex = 7;
            this.LblPassMax.Text = "Max Passengers";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(25, 9);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(18, 13);
            this.LblID.TabIndex = 8;
            this.LblID.Text = "ID";
            // 
            // LblDistance
            // 
            this.LblDistance.AutoSize = true;
            this.LblDistance.Location = new System.Drawing.Point(285, 9);
            this.LblDistance.Name = "LblDistance";
            this.LblDistance.Size = new System.Drawing.Size(49, 13);
            this.LblDistance.TabIndex = 9;
            this.LblDistance.Text = "Distance";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 301);
            this.Controls.Add(this.LblDistance);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.LblPassMax);
            this.Controls.Add(this.LblStartDate);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LstTours);
            this.Name = "FrmMain";
            this.Text = "Tourism \'R\' Us";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstTours;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblStartDate;
        private System.Windows.Forms.Label LblPassMax;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblDistance;
    }
}

