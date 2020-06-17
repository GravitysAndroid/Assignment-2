using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Two
{
    [Serializable]
    public abstract class ClsCost
    {
        private string _Name;
        private decimal _Cost;
        //protected ClsCost _CostClass;
        //public string _TotalCost;
        public static readonly string[] _TypeOfCost = { "Staff", "Vehicle", "Other" };
        private Dictionary<string, ClsCost> _CostList = new Dictionary<string, ClsCost>();

        public Dictionary<string, ClsCost> CostList
        {
            get => _CostList;
        }

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

        public abstract decimal CalculatedCost();

        public abstract bool ViewEdit();

        protected abstract string TypeOfCost();

        public override string ToString()
        {
            return _Name + "\t" + _Cost + "\t" + TypeOfCost();
        }

        public static ClsCost NewCost(int prChoice)
        {
            if (prChoice == 0)
                return new ClsStaff();
            else if (prChoice == 1)
                return new ClsVehicle();
            else
                return new ClsOther();
        }
    }
}
