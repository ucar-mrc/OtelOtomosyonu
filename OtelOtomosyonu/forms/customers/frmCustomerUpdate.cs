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
    public partial class frmCustomerUpdate : Form
    {
        SqlConnection conn = new SqlConnection("data source=.;initial catalog = otelDB;integrated security = True;MultipleActiveResultSets=True;App=EntityFramework");

        private frmCustomer anaForm;
        private int customerId;
        
        public frmCustomerUpdate(frmCustomer form,int id, string name, string lastname, int age, string roomtype,string dayofentry)
        {
            InitializeComponent();
            anaForm = form;
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
            try
            {
                conn.Open();
                string query = "UPDATE customers SET customerName=@name, customerLastname=@lastName, customerAge=@Age, roomType=@roomType,dayOfEntry=@dayOfEntry WHERE customerId=@id";
                SqlCommand guncelle = new SqlCommand(query, conn);

                guncelle.Parameters.AddWithValue("@id", customerId); // Burası eksikti
                guncelle.Parameters.AddWithValue("@name", customerNametxt.Text);
                guncelle.Parameters.AddWithValue("@lastname", customerLastnametxt.Text);
                guncelle.Parameters.AddWithValue("@age", customerAgetxt.Text);
                guncelle.Parameters.AddWithValue("@roomType", cmbcustomerRoomtype.SelectedItem.ToString());
                guncelle.Parameters.AddWithValue("@dayOfEntry", dayOfEntry.Value);
                guncelle.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Müşteri güncellendi.");
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
