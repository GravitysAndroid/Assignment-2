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
        public FrmStaff()
        {
            InitializeComponent();
        }

        protected override void UpdateDisplay()
        {
            base.UpdateDisplay();
            ClsStaff lcStaff = (ClsStaff) _CostClass;
            TxtStaffRole.Text = _StaffRole;
        }

        protected override void PushData()
        {
            base.PushData();
            ClsMOEStudent lcStudent = (ClsMOEStudent)_Student;
            lcStudent.LoanAmount = Convert.ToDecimal(TxtLoan.Text);
            lcStudent.FullTime = ChkFullTime.Checked;
        }
    }
}
