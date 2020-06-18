﻿using System;
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
        protected decimal _Cost;
        public static readonly string[] _TypeOfCost = { "Staff", "Vehicle", "Other" };
        private Dictionary<string, ClsCost> _CostList = new Dictionary<string, ClsCost>();
        protected ClsTour _Tour;

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
            return _Name + "\t"  + TypeOfCost() + "\t" + _Cost + "\t" + CalculatedCost();
        }

        public static ClsCost NewCost(int prChoice, ClsTour prTour)
        {
            if (prChoice == 0)
                return new ClsStaff() { _Tour = prTour};
            else if (prChoice == 1)
                return new ClsVehicle() { _Tour = prTour };
            else
                return new ClsOther() { _Tour = prTour };
        }
    }
}
