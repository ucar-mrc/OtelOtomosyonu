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

namespace OtelOtomosyonu.forms.customers
{
    public partial class frmCustomerDelete : Form
    {
        SqlConnection conn = new SqlConnection("data source=.;initial catalog = otelDB;integrated security = True;MultipleActiveResultSets=True;App=EntityFramework");
        private frmCustomer anaForm;
        private int customerId;
        public frmCustomerDelete(frmCustomer form, int id, string name, string lastname, int age, string roomtype, string dayofentry)
        {
            InitializeComponent();
            this.anaForm = form;
            customerId = id;

           

            string formattedDate = dayOfEntry.Value.ToString("yyyy-MM-dd HH:mm:ss");
            customerNametxt.Text = name;
            customerLastnametxt.Text = lastname;
            customerAgetxt.Text = age.ToString();
            cmbcustomerRoomtype.Text = roomtype;
            formattedDate = dayofentry;
        }

         private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(customerId.ToString());

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM customers WHERE customerId =@IDs";
            cmd.Parameters.AddWithValue("@IDs", customerId);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Müşteri kaydı başarıyla silindi");

            anaForm.goster();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
