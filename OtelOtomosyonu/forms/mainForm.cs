using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomosyonu.forms
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            
            
        }

        private void btnemployee_Click(object sender, EventArgs e)
        {
            Form frmEmployee = new frmEmployee();
            this.Hide();
            frmEmployee.Show();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            Form frmCustomer = new frmCustomer();
            this.Hide();
            frmCustomer.Show();
        }
    }
}
