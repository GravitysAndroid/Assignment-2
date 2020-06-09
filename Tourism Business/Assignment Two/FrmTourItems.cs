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
        private ClsCost _Cost;

        public FrmTourItems()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _FrmStaff.ShowDialog();
        }

        private void BtnAddVehicle_Click(object sender, EventArgs e)
        {
            _FrmVehicle.ShowDialog();
        }

        private void BtnAddOther_Click(object sender, EventArgs e)
        {
            _FrmOther.ShowDialog();
        }

        private void EditTour(ClsCost prCost)
        {
            if (prCost != null && prCost.ViewEdit())
            {
                _Cost = prCost;
            }
        }

            private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        
    }
}
