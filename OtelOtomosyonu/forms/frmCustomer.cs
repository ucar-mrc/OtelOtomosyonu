using OtelOtomosyonu.forms.customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OtelOtomosyonu.forms
{
    public partial class frmCustomer : Form
    {
        SqlConnection conn = new SqlConnection("data source=.;initial catalog = otelDB;integrated security = True;MultipleActiveResultSets=True;App=EntityFramework");
        public frmCustomer()
        {
            InitializeComponent();
            goster();
        }

        public void goster()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from customers";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvCustomers.DataSource = dt;
            conn.Close();

        }

        int selectedId;
        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCustomers.SelectedRows[0];
                if (selectedRow.Cells["Id"].Value != null)
                {
                    selectedId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Form frmCustomerAdd = new frmCustomerAdd(this);
            frmCustomerAdd.Show();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvCustomers.CurrentRow;

            if (row != null)
            {
                int customerId = int.Parse(row.Cells["customerId"].Value.ToString());
                String customerName = row.Cells["customerName"].Value.ToString();
                String customerLastname = row.Cells["customerLastname"].Value.ToString();
                int customerAge = int.Parse(row.Cells["customerAge"].Value.ToString());
                String roomType = row.Cells["roomType"].Value.ToString();
                string dayofentry = row.Cells["dayOfEntry"].Value.ToString();

                frmCustomerDelete frm = new frmCustomerDelete( this, customerId, customerName, customerLastname, customerAge, roomType, dayofentry);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    goster();
                }
            }
            else
                MessageBox.Show("Lütfen silinecek müşteriyi seçin.");
        }



        private void btnguncelle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvCustomers.CurrentRow;

            if (row != null)
            {
                int customerId = int.Parse(row.Cells["customerId"].Value.ToString());
                String customerName = row.Cells["customerName"].Value.ToString();
                String customerLastname = row.Cells["customerLastname"].Value.ToString();
                int customerAge = int.Parse(row.Cells["customerAge"].Value.ToString());
                String roomType = row.Cells["roomType"].Value.ToString();
                string dayofentry = row.Cells["dayOfEntry"].Value.ToString();

                frmCustomerUpdate frm = new frmCustomerUpdate(this, customerId, customerName, customerLastname, customerAge, roomType, dayofentry);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    goster(); // listeyi yenile
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek müşteriyi seçin.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mainForm = new mainForm();
            this.Hide();
            mainForm.Show();
        }
    }
}
