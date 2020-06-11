using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Two
{
    public abstract class ClsCost
    {
        private string _Name;
        private decimal _Cost;
        public static readonly string[] _TypeOfCost = { "Staff)", "Vehicle", "Other" };

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public Decimal Cost
        {
            get { return _Cost; }
            set { _Cost = value; }
        }

        public abstract bool ViewEdit();

        protected abstract string TypeOfCost();

        public override string ToString()
        {
            return _Name + "\t" + _Cost + "\t" + TypeOfCost();
        }

        protected abstract decimal CalculateCost();

        //protected static ClsCost NewCost(int prChoice)
        //{
        //    if (prChoice == 0)
        //        return new ClsStaff();
        //    else if (prChoice == 1)
        //        return new ClsVehicle();
        //    else
        //        return new ClsOther();
        //}
    }
}
