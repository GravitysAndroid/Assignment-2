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
    public partial class FrmStaff : FrmItem
    {
        public string Role;

        public FrmStaff()
        {
            InitializeComponent();
        }

        protected override void UpdateDisplay()
        {
            base.UpdateDisplay();
            //TxtName.Text = _Cost.Name;
            //TxtCost.Text = Convert.ToString(_Cost.Cost);
            TxtStaffRole.Text = (_Cost as ClsStaff).Role;
        }

        protected override void PushData()
        {
            base.PushData();
            //_Cost.Name = TxtName.Text;
            //_Cost.Cost = Convert.ToDecimal(TxtCost.Text);
            (_Cost as ClsStaff).Role = TxtStaffRole.Text;
        }
    }
}
