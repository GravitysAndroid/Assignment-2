using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Two
{
    [Serializable]
    class ClsVehicle : ClsCost
    {
        private static FrmVehicle _VehicleForm = new FrmVehicle();
        private ClsTour clsTour;

        public override bool ViewEdit()
        {
            return _VehicleForm.ShowDialog(this);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        protected override string TypeOfCost()
        {
            return "Vehicle";
        }

        public override decimal CalculatedCost()
        {
            //decimal lcPercent = (_Tour.MarkUp / 100) + 1;
            return (_Cost * _Tour.Distance);
            //return (_Cost * _Tour.Distance) * (lcPercent + 1);
        }
    }
}
