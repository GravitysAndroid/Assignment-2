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
    public partial class FrmNewTour : Form
    {
        private FrmTourItems _FrmTourItems = new FrmTourItems();
        public FrmNewTour()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

        }

        private void BtnItems_Click(object sender, EventArgs e)
        {
            _FrmTourItems.ShowDialog();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
