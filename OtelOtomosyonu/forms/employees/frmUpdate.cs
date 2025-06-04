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
    public partial class frmUpdate : Form
    {
        SqlConnection conn = new SqlConnection("data source=.;initial catalog = otelDB;integrated security = True;MultipleActiveResultSets=True;App=EntityFramework");
        private frmEmployee anaForm;
        private int hastaId;

        public frmUpdate(frmEmployee form, int id, string ad, string soyad, int yas, string bolum)
        {
            InitializeComponent();
            anaForm = form;
            hastaId = id;

            // Gelen değerleri form kontrollerine yerleştir
            employeeNametxt.Text = ad;
            employeeLastnametxt.Text = soyad;
            employeAgetxt.Text = yas.ToString();
            cmbemployeeSection.Text = bolum;
        }





        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "UPDATE employees SET employeeName=@name, employeeLastname=@lastName, employeeAge=@Age, employeeSection=@section WHERE employeeId=@id";
                SqlCommand guncelle = new SqlCommand(query, conn);
                guncelle.Parameters.AddWithValue("@id", hastaId);
                guncelle.Parameters.AddWithValue("@name", employeeNametxt.Text);
                guncelle.Parameters.AddWithValue("@lastName", employeeLastnametxt.Text);
                guncelle.Parameters.AddWithValue("@Age", int.Parse(employeAgetxt.Text));
                guncelle.Parameters.AddWithValue("@section", cmbemployeeSection.Text);
                guncelle.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Çalışan güncellendi.");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
