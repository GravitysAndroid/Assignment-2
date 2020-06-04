﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Two
{
    public partial class FrmMain : Form
    {
        private FrmTour _FrmNewTour = new FrmTour();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ClsTour lcTour = new ClsTour();

            if (_FrmNewTour.ShowDialog(_lcTour) == DialogResult.OK)
            {
                ClsCompanyData.TourList.Add(lcTour.Code, lcTour);
                UpdateDisplay();
            }
            
        }

        private void UpdateDisplay()
        {
            LstTours.DataSource = null;
            LstTours.DataSource = ClsCompanyData.TourList.Values.ToList<ClsTour>();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
