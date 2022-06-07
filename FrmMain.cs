using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA220607
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnKoszon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNev.Text))
            {
                MessageBox.Show("Előbb írd be a neved!");
            }
            else
            {
                MessageBox.Show($"Szia {tbNev.Text}!");
            }
        }
    }
}
