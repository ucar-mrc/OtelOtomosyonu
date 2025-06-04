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
    public partial class frmDelete : Form
    {
      
        SqlConnection conn = new SqlConnection("data source=.;initial catalog = otelDB;integrated security = True;MultipleActiveResultSets=True;App=EntityFramework");

        private frmEmployee frmEmployees;
        int empId;
        public frmDelete(frmEmployee frm, int employeeId, string employeeName, string employeeLastname, int  employeeAge, string employeeSection)
        {
            InitializeComponent();
            this.frmEmployees = frm;

            empId = employeeId;
            employeeNametxt.Text = employeeName;
            employeeLastnametxt.Text = employeeLastname;
            employeAgetxt.Text = employeeAge.ToString();
            employeeSectiontxt.Text = employeeSection;


        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            MessageBox.Show(empId.ToString());

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM employees WHERE employeeId =@IDs";
            cmd.Parameters.AddWithValue("@IDs", empId);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Çalışan kaydı başarıyla silindi");

            frmEmployees.goster();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
