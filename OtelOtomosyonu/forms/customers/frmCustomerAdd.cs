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
    public partial class frmCustomerAdd : Form
    {
        SqlConnection conn = new SqlConnection("data source=.;initial catalog = otelDB;integrated security = True;MultipleActiveResultSets=True;App=EntityFramework");

        private frmCustomer Frmcustomers;
        public frmCustomerAdd(frmCustomer frm)
        {
            InitializeComponent();
            this.Frmcustomers = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //risk taşıyan şekil
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            string formattedDate = dayOfEntry.Value.ToString("yyyy-MM-dd HH:mm:ss");
            cmd.CommandText = "insert into customers values ('" + customerNametxt.Text + "','" + customerLastnametxt.Text + "','" + customerAgetxt.Text + "','" + cmbcustomerRoomtype.SelectedItem.ToString() +"','" + formattedDate + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("MÜşteri kaydı başarılı şekilde eklendi");
            
            Frmcustomers.goster();
            this.Hide();

            //Riski olmayan Şekil
           /* conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO customers (customerName, customerLastName, customerAge, roomType, dayOfEntry) VALUES (@name, @lastname, @age, @roomType, @dayOfEntry)";
            cmd.Parameters.AddWithValue("@name", customerNametxt.Text);
            cmd.Parameters.AddWithValue("@lastname", customerLastnametxt.Text);
            cmd.Parameters.AddWithValue("@age", customerAgetxt.Text);
            cmd.Parameters.AddWithValue("@roomType", cmbcustomerRoomtype.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@dayOfEntry", dateTimePickerLogin.Value);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Müşteri kaydı başarılı şekilde eklendi");

            Frmcustomers.goster();
            this.Hide();*/
        }


    }
}
