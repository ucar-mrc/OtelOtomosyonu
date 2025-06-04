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

namespace OtelOtomosyonu.forms.employees
{
    public partial class frmAdd : Form
    {
        SqlConnection conn = new SqlConnection("data source=.;initial catalog = otelDB;integrated security = True;MultipleActiveResultSets=True;App=EntityFramework");


        private frmEmployee Frmemployees;

        public frmAdd(frmEmployee frm) //hastaları anımsattık 
        {
            InitializeComponent();
            this.Frmemployees = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into employees values ('" + employeeNametxt.Text + "','" + employeeLastnametxt.Text + "','" + employeAgetxt.Text + "','" + cmbemployeeSection.SelectedItem.ToString() + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Çalışan kaydı başarılı şekilde eklendi");

            Frmemployees.goster();
            this.Hide();
        }
    }
}
