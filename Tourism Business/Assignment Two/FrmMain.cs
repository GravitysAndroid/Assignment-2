using System;
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
        private ClsTour _Tour;
        private static FrmTour _FrmNewTour = new FrmTour();

        public FrmMain()
        {
            try
            {
                ClsCompanyData.Retreive();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
            InitializeComponent();
        }
        private void EditTour(ClsTour prTour)
        {
            if (prTour != null && prTour.ViewEdit())
            {
                _Tour = prTour;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ClsTour lcTour = new ClsTour();
            if (lcTour != null && lcTour.ViewEdit())
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
            ClsTour lcTour = (ClsTour)LstTours.SelectedItem;
            if (lcTour != null && lcTour.ViewEdit())
            {
                UpdateDisplay();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ClsTour lcTour = (ClsTour)LstTours.SelectedValue;
            if (LstTours.SelectedIndex == -1)
            { //Not Selected Anything
                MessageBox.Show("Select an item to delete");
            }
            else
            {
                LstTours.Items.RemoveAt(LstTours.SelectedIndex);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            try
            {
                ClsCompanyData.Save();
                DialogResult = DialogResult.Cancel;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
    }
}
