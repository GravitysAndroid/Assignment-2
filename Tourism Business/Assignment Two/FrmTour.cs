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
    public partial class FrmTour : Form
    {
        private FrmTourItems _FrmTourItems = new FrmTourItems();
        private ClsTour _Tour;
        public FrmTour()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(ClsTour prTour)
        {
            _Tour = prTour;
            UpdateDisplay();
            return ShowDialog();
        }

        private void UpdateDisplay()
        {
            TxtCode.Text = _Tour.Code;
            TxtCode.Enabled = String.IsNullOrEmpty(_Tour.Code);
            TxtName.Text = _Tour.Name;
            NumDistance.Value = _Tour.Distance;
            DtpEnd.Value = _Tour.EndDate;
            DtpStart.Value = _Tour.StartDate;
            NumPassMax.Value = _Tour.MaxPax;
            NumMarkUp.Value = _Tour.MarkUp;
        }

        private void PushData()
        {
            _Tour.Code = TxtCode.Text;
            _Tour.Name = TxtName.Text;
            _Tour.Distance = Convert.ToInt32(NumDistance.Value);
            _Tour.EndDate = DtpEnd.Value;
            _Tour.StartDate = DtpStart.Value;
            _Tour.MaxPax = Convert.ToInt32(NumPassMax.Value);
            _Tour.MarkUp = Convert.ToInt32(NumMarkUp.Value);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (ClsCompanyData.TourList.ContainsKey(TxtCode.Text) && (TxtCode.Enabled = string.IsNullOrEmpty(_Tour.Code)))
                MessageBox.Show("Code already in use");
            else
            {
                PushData();
                DialogResult = DialogResult.OK;
            }
        }

        private void BtnItems_Click(object sender, EventArgs e)
        {
            //FrmTourItem _FrmTourItems = new FrmTourItems();
            PushData();
            _FrmTourItems.ShowDialog(_Tour);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
