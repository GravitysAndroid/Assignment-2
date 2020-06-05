namespace Assignment_Two
{
    partial class FrmTour
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
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.LblCode = new System.Windows.Forms.Label();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.LblEndDate = new System.Windows.Forms.Label();
            this.LblPassengers = new System.Windows.Forms.Label();
            this.LblDistance = new System.Windows.Forms.Label();
            this.LblMarkUp = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnItems = new System.Windows.Forms.Button();
            this.DtpStart = new System.Windows.Forms.DateTimePicker();
            this.DtpEnd = new System.Windows.Forms.DateTimePicker();
            this.NumPassMax = new System.Windows.Forms.NumericUpDown();
            this.NumDistance = new System.Windows.Forms.NumericUpDown();
            this.NumMarkUp = new System.Windows.Forms.NumericUpDown();
            this.lblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumPassMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMarkUp)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCode
            // 
            this.TxtCode.Location = new System.Drawing.Point(130, 6);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(100, 20);
            this.TxtCode.TabIndex = 0;
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Location = new System.Drawing.Point(12, 9);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(35, 13);
            this.LblCode.TabIndex = 1;
            this.LblCode.Text = "Code:";
            // 
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Location = new System.Drawing.Point(12, 64);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(58, 13);
            this.LblStartDate.TabIndex = 2;
            this.LblStartDate.Text = "Start Date:";
            // 
            // LblEndDate
            // 
            this.LblEndDate.AutoSize = true;
            this.LblEndDate.Location = new System.Drawing.Point(12, 90);
            this.LblEndDate.Name = "LblEndDate";
            this.LblEndDate.Size = new System.Drawing.Size(55, 13);
            this.LblEndDate.TabIndex = 3;
            this.LblEndDate.Text = "End Date:";
            // 
            // LblPassengers
            // 
            this.LblPassengers.AutoSize = true;
            this.LblPassengers.Location = new System.Drawing.Point(12, 116);
            this.LblPassengers.Name = "LblPassengers";
            this.LblPassengers.Size = new System.Drawing.Size(112, 13);
            this.LblPassengers.TabIndex = 4;
            this.LblPassengers.Text = "Maximum Passengers:";
            // 
            // LblDistance
            // 
            this.LblDistance.AutoSize = true;
            this.LblDistance.Location = new System.Drawing.Point(12, 142);
            this.LblDistance.Name = "LblDistance";
            this.LblDistance.Size = new System.Drawing.Size(72, 13);
            this.LblDistance.TabIndex = 5;
            this.LblDistance.Text = "Distance(km):";
            // 
            // LblMarkUp
            // 
            this.LblMarkUp.AutoSize = true;
            this.LblMarkUp.Location = new System.Drawing.Point(12, 168);
            this.LblMarkUp.Name = "LblMarkUp";
            this.LblMarkUp.Size = new System.Drawing.Size(65, 13);
            this.LblMarkUp.TabIndex = 6;
            this.LblMarkUp.Text = "Mark Up(%):";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(13, 223);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 12;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(268, 223);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnItems
            // 
            this.BtnItems.Location = new System.Drawing.Point(130, 223);
            this.BtnItems.Name = "BtnItems";
            this.BtnItems.Size = new System.Drawing.Size(100, 23);
            this.BtnItems.TabIndex = 14;
            this.BtnItems.Text = "Configure Items";
            this.BtnItems.UseVisualStyleBackColor = true;
            this.BtnItems.Click += new System.EventHandler(this.BtnItems_Click);
            // 
            // DtpStart
            // 
            this.DtpStart.Location = new System.Drawing.Point(130, 62);
            this.DtpStart.Name = "DtpStart";
            this.DtpStart.Size = new System.Drawing.Size(200, 20);
            this.DtpStart.TabIndex = 15;
            // 
            // DtpEnd
            // 
            this.DtpEnd.Location = new System.Drawing.Point(130, 89);
            this.DtpEnd.Name = "DtpEnd";
            this.DtpEnd.Size = new System.Drawing.Size(200, 20);
            this.DtpEnd.TabIndex = 16;
            // 
            // NumPassMax
            // 
            this.NumPassMax.Location = new System.Drawing.Point(130, 116);
            this.NumPassMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumPassMax.Name = "NumPassMax";
            this.NumPassMax.Size = new System.Drawing.Size(100, 20);
            this.NumPassMax.TabIndex = 17;
            this.NumPassMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumDistance
            // 
            this.NumDistance.Location = new System.Drawing.Point(130, 143);
            this.NumDistance.Name = "NumDistance";
            this.NumDistance.Size = new System.Drawing.Size(100, 20);
            this.NumDistance.TabIndex = 18;
            // 
            // NumMarkUp
            // 
            this.NumMarkUp.Location = new System.Drawing.Point(130, 170);
            this.NumMarkUp.Name = "NumMarkUp";
            this.NumMarkUp.Size = new System.Drawing.Size(100, 20);
            this.NumMarkUp.TabIndex = 19;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(130, 33);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 21;
            // 
            // FrmTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 258);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.NumMarkUp);
            this.Controls.Add(this.NumDistance);
            this.Controls.Add(this.NumPassMax);
            this.Controls.Add(this.DtpEnd);
            this.Controls.Add(this.DtpStart);
            this.Controls.Add(this.BtnItems);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.LblMarkUp);
            this.Controls.Add(this.LblDistance);
            this.Controls.Add(this.LblPassengers);
            this.Controls.Add(this.LblEndDate);
            this.Controls.Add(this.LblStartDate);
            this.Controls.Add(this.LblCode);
            this.Controls.Add(this.TxtCode);
            this.Name = "FrmTour";
            this.Text = "Add New Tour";
            ((System.ComponentModel.ISupportInitialize)(this.NumPassMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMarkUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Label LblCode;
        private System.Windows.Forms.Label LblStartDate;
        private System.Windows.Forms.Label LblEndDate;
        private System.Windows.Forms.Label LblPassengers;
        private System.Windows.Forms.Label LblDistance;
        private System.Windows.Forms.Label LblMarkUp;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnItems;
        private System.Windows.Forms.DateTimePicker DtpStart;
        private System.Windows.Forms.DateTimePicker DtpEnd;
        private System.Windows.Forms.NumericUpDown NumPassMax;
        private System.Windows.Forms.NumericUpDown NumDistance;
        private System.Windows.Forms.NumericUpDown NumMarkUp;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox TxtName;
    }
}