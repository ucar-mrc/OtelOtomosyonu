using OtelOtomosyonu.forms.employees;
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
    public partial class frmEmployee : Form
    {
        SqlConnection conn = new SqlConnection("data source=.;initial catalog = otelDB;integrated security = True;MultipleActiveResultSets=True;App=EntityFramework");
        public frmEmployee()
        {
            InitializeComponent();
            goster();
        }

        public void goster()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from employees";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvEmployees.DataSource = dt;
            conn.Close();

        }

        int selectedId;
        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEmployees.SelectedRows[0];
                if (selectedRow.Cells["Id"].Value != null)
                {
                    selectedId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                }
            }
        }

        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Form frmAdd = new frmAdd(this);
            frmAdd.Show();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvEmployees.CurrentRow;

            if (row != null)
            {
                int employeeId = int.Parse(row.Cells["employeeId"].Value.ToString());
                String employeeName = row.Cells["employeeName"].Value.ToString();
                String employeeLastname = row.Cells["employeeLastname"].Value.ToString();
                int employeeAge = int.Parse(row.Cells["employeeAge"].Value.ToString());
                String employeeSection = row.Cells["employeeSection"].Value.ToString();

                frmDelete frm = new frmDelete(this, employeeId, employeeName, employeeLastname, employeeAge, employeeSection);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    goster();
                }
            }
            else
                MessageBox.Show("Lütfen silinecek hastayı seçin.");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvEmployees.CurrentRow;

            if (row != null)
            {
                int employeeId = int.Parse(row.Cells["employeeId"].Value.ToString());
                String employeeName = row.Cells["employeeName"].Value.ToString();
                String employeeLastname = row.Cells["employeeLastname"].Value.ToString();
                int employeeAge = int.Parse(row.Cells["employeeAge"].Value.ToString());
                String employeeSection = row.Cells["employeeSection"].Value.ToString();

                frmUpdate frm = new frmUpdate(this, employeeId, employeeName, employeeLastname, employeeAge, employeeSection);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    goster(); // listeyi yenile
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek Çalışanı seçin.");
            }
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form mainForm = new mainForm();
            this.Hide();
            mainForm.Show();
        }
    }
}
