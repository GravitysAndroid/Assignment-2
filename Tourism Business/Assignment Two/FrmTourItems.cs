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
    public partial class FrmTourItems : Form
    {
        private FrmStaff _FrmStaff = new FrmStaff();
        private FrmVehicle _FrmVehicle = new FrmVehicle();
        private FrmOther _FrmOther = new FrmOther();
        private ClsTour _Tour;
        //private decimal lcTempSum;

        public FrmTourItems()
        {
            InitializeComponent();
            CboCostType.DataSource = ClsCost._TypeOfCost;
            CboCostType.SelectedIndex = 0;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ClsCost lcCost = ClsCost.NewCost(CboCostType.SelectedIndex);
            if (lcCost != null && lcCost.ViewEdit())
            {
                _Tour.CostList.Add(lcCost);
                UpdateDisplay();
            }
        }

        private void BtnAddVehicle_Click(object sender, EventArgs e)
        {
            _FrmVehicle.ShowDialog();
        }

        private void BtnAddOther_Click(object sender, EventArgs e)
        {
            _FrmOther.ShowDialog();
        }

        private void EditCost(ClsCost prCost)
        {
            if (prCost != null && prCost.ViewEdit())
            {
                UpdateDisplay();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            ClsCost lcCost = (ClsCost)LstItems.SelectedItem;
            if (lcCost != null && lcCost.ViewEdit())
            {
                UpdateDisplay();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (LstItems.SelectedIndex == -1)
            { //Not Selected Anything
                MessageBox.Show("Select an item to delete");
            }
            else
            {
                LstItems.Items.RemoveAt(LstItems.SelectedIndex);
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            UpdateDisplay();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public bool ShowDialog(ClsTour prTour)
        {
            _Tour = prTour;
            UpdateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        private void UpdateDisplay()
        {
            //ClsTour Costing = new ClsTour();
            LstItems.DataSource = null;
            LstItems.DataSource = _Tour.CostList;
            //LblTotal.Text = "Total Cost: " + (lcTempSum + _Tour.TotalSum);
            //lcTempSum = Costing.TotalSum;
        }
    }
}
