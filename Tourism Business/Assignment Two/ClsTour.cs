using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Two
{
    [Serializable]
    public class ClsTour
    {
        private String _code;
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

        private int _maxPax;
        public int MaxPax
        {
            get { return _maxPax; }
            set { _maxPax = value; }
        }

        private int _distance;
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

        public static ClsTour NewTour(int prChoice)
        {
            if (prChoice == 0)
                return new ClsMOEStudent();
            else
                return new ClsInternationalStudent();
        }

        public String ToString()
        {
            throw new System.Exception("Not implemented");
        }

        public Decimal CalculatePricePassenger()
        {
            decimal lcTotal = 0;
            foreach (ClsTour lcCost in TourList.Values)
                lcTotal += lcCost.Balance;
            return lcTotal;
        }

        public void ViewEdit()
        {
            throw new System.Exception("Not implemented");
        }

        private System.Collections.Generic.List<ClsCost> clsCost;


    }
}
