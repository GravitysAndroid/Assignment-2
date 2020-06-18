using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //decimal lcTotal = 0;
            //foreach (clsTour lcTour in _TypeOfCost)
            //    lcTotal += lcTour.TotalSum;
            //return Cost;
            return _Cost * _Tour.Distance;
        }
    }
}
