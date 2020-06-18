using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Two
{
    [Serializable]
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

        public override decimal CalculatedCost()
        {
            //decimal lcPercent = (_Tour.MarkUp / 100) + 1;
            return Cost;
            //return Cost * lcPercent;
        }
    }
}
