using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Two
{
    class ClsVehicle : ClsCost
    {
        private static FrmVehicle _VehicleForm = new FrmVehicle();
        public override bool ViewEdit()
        {
            return _VehicleForm.ShowDialog(this);

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override decimal CalculateCost()
        {
            return
        }

        protected override string TypeOfCost()
        {
            return "Other";
        }
    }
}
