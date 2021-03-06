﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Two
{
    [Serializable]
    public class ClsTour
    {
        private static FrmTour _TourForm = new FrmTour();
        private System.Collections.Generic.List<ClsCost> _CostList = new List<ClsCost>();
        public decimal TotalSum = FrmItem.CostLabel;
        private String _code;

        public List<ClsCost> CostList 
        { 
            get => _CostList; 
        }

        public String Code
        {
            get { return _code; }
            set { _code = value; }
        }

        private String _name;
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private DateTime _startDate = DateTime.Today;
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        private DateTime _endDate = DateTime.Today;
        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        private int _maxPax = 1;
        public int MaxPax
        {
            get { return _maxPax; }
            set { _maxPax = value; }
        }

        private int _distance = 1;
        public int Distance
        {
            get { return _distance; }
            set { _distance = value; }
        }

        private int _markUp;
        public int MarkUp
        {
            get { return _markUp; }
            set { _markUp = value; }
        }

        public static ClsTour NewTour()
        {
            return new ClsTour();
        }

        public bool ViewEdit()
        {
            return _TourForm.ShowDialog(this) == DialogResult.OK;
        }

        public override String ToString()
        {
            return _code + "\t" + _name + "\t" + _startDate.ToShortDateString() + "\t" + _maxPax + "\t\t" + _distance;
        }

        public decimal CalcTotalCost()
        {
            decimal lcTotal = 0;
            foreach (ClsCost lcCost in CostList)
                lcTotal += lcCost.CalculatedCost();
            return lcTotal;
        }
    }
}
