﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Two
{
    class ClsStaff : ClsCost
    {
        private static FrmStaff _StaffForm = new FrmStaff();

        public string Role
        {
            get => _Role;
            set => _Role = Value;
        }
        public override bool ViewEdit()
        {
            return _StaffForm.ShowDialog(this);

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