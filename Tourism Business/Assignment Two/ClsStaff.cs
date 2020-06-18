using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Two
{
    [Serializable]
    class ClsStaff : ClsCost
    {
        private static FrmStaff _StaffForm = new FrmStaff();
        private string _Role;

        public string Role
        {
            get { return _Role; }
            set { _Role = value; }
        }

        public override bool ViewEdit()
        {
            return _StaffForm.ShowDialog(this);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        protected override string TypeOfCost()
        {
            return "Staff";
        }

        public override decimal CalculatedCost()
        {
            //decimal lcPercent = (_Tour.MarkUp / 100) + 1;
            return (_Cost * (((_Tour.EndDate.Date - _Tour.StartDate.Date).Days) + 1));
            //return (_Cost * (((_Tour.EndDate.Date - _Tour.StartDate.Date).Days) + 1)) * (lcPercent);
        }
    }
}
