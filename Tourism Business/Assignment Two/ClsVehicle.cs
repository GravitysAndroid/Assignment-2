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

        //public static decimal TotalBalance()
        //{
        //    decimal lcTotal = 0;
        //    foreach (ClsCost lcStudent in _CostList)
        //        lcTotal += lcStudent.Balance;
        //    return lcTotal;
        //}

        public override decimal CalculatedCost()
        {
            throw new NotImplementedException();
        }
    }
}
