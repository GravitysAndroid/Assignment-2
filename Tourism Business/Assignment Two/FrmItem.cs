using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Two
{
    public partial class FrmItem : Form
    {
        protected ClsCost _Cost;
        private FrmTourItems frmTourItems;
                       
        public FrmItem()
        {
            this.frmTourItems = frmTourItems;
            InitializeComponent();
        }

        public bool ShowDialog(ClsCost prCost)
        {
            _Cost = prCost;
            UpdateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        protected virtual void UpdateDisplay()
        {
            TxtName.Text = _Cost.Name;
            TxtCost.Text = Convert.ToString(_Cost.Cost);
        }

        protected virtual void PushData()
        {
            _Cost.Name = TxtName.Text;
            _Cost.Cost = Convert.ToDecimal(TxtCost.Text);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            _Cost.Name = TxtName.Text;
            _Cost.Cost = Convert.ToDecimal(TxtCost.Text);
            frmTourItems.LabelText = "Total Cost:" + TxtCost.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
