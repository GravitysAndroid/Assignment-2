﻿namespace Assignment_Two
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
            this.BtnAddCost = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.CboCostType = new System.Windows.Forms.ComboBox();
            this.LblITotalItemCost = new System.Windows.Forms.Label();
            this.LblContribution = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstItems
            // 
            this.LstItems.FormattingEnabled = true;
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
            this.LblType.Location = new System.Drawing.Point(65, 9);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(31, 13);
            this.LblType.TabIndex = 2;
            this.LblType.Text = "Type";
            // 
            // LblCost
            // 
            this.LblCost.AutoSize = true;
            this.LblCost.Location = new System.Drawing.Point(111, 9);
            this.LblCost.Name = "LblCost";
            this.LblCost.Size = new System.Drawing.Size(28, 13);
            this.LblCost.TabIndex = 3;
            this.LblCost.Text = "Cost";
            // 
            // BtnAddCost
            // 
            this.BtnAddCost.Location = new System.Drawing.Point(12, 267);
            this.BtnAddCost.Name = "BtnAddCost";
            this.BtnAddCost.Size = new System.Drawing.Size(75, 23);
            this.BtnAddCost.TabIndex = 4;
            this.BtnAddCost.Text = "Add Cost";
            this.BtnAddCost.UseVisualStyleBackColor = true;
            this.BtnAddCost.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(12, 243);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(286, 267);
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
            this.LblTotal.Location = new System.Drawing.Point(194, 243);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(86, 13);
            this.LblTotal.TabIndex = 9;
            this.LblTotal.Text = "Total Items Cost:";
            // 
            // CboCostType
            // 
            this.CboCostType.FormattingEnabled = true;
            this.CboCostType.Location = new System.Drawing.Point(93, 269);
            this.CboCostType.Name = "CboCostType";
            this.CboCostType.Size = new System.Drawing.Size(121, 21);
            this.CboCostType.TabIndex = 10;
            // 
            // LblITotalItemCost
            // 
            this.LblITotalItemCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblITotalItemCost.Location = new System.Drawing.Point(286, 240);
            this.LblITotalItemCost.Name = "LblITotalItemCost";
            this.LblITotalItemCost.Size = new System.Drawing.Size(75, 23);
            this.LblITotalItemCost.TabIndex = 11;
            // 
            // LblContribution
            // 
            this.LblContribution.AutoSize = true;
            this.LblContribution.Location = new System.Drawing.Point(146, 9);
            this.LblContribution.Name = "LblContribution";
            this.LblContribution.Size = new System.Drawing.Size(102, 13);
            this.LblContribution.TabIndex = 12;
            this.LblContribution.Text = "Contribution Cost ($)";
            // 
            // FrmTourItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 331);
            this.Controls.Add(this.LblContribution);
            this.Controls.Add(this.LblITotalItemCost);
            this.Controls.Add(this.CboCostType);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAddCost);
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
        private System.Windows.Forms.Button BtnAddCost;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.ComboBox CboCostType;
        private System.Windows.Forms.Label LblITotalItemCost;
        private System.Windows.Forms.Label LblContribution;
    }
}