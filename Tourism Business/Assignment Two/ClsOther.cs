using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Two
{
    class ClsOther : ClsCost
    {
        private static FrmOther _OtherForm = new FrmOther();
        public override bool ViewEdit()
        {
            return _OtherForm.ShowDialog(this);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        protected override string TypeOfCost()
        {
            return "Other";
        }
    }
}
