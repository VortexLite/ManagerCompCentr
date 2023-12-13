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

namespace ManagerCompCentr.Forms
{
    public partial class AddCustomer : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public AddCustomer()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void EnterOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(emailCustomer.Text) &&
                !string.IsNullOrWhiteSpace(phoneCustomer.Text) &&
                !string.IsNullOrWhiteSpace(fistNameCustomer.Text) &&
                !string.IsNullOrWhiteSpace(lastNameCustomer.Text) &&
                !string.IsNullOrWhiteSpace(adressCustomer.Text))
            {
                string idCustomer = "";
                var command = new SqlCommand("SELECT MAX(CAST(CustomerID AS INT)) AS max_id FROM Customer", connection);
                try
                {
                    idCustomer = Convert.ToString(Convert.ToInt32(command.ExecuteScalar().ToString()) + 1);
                }
                catch
                {
                    idCustomer = "1";
                }

                var cmd = new SqlCommand("AddCustomer", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerID", idCustomer);
                cmd.Parameters.AddWithValue("@Email", emailCustomer.Text);
                cmd.Parameters.AddWithValue("@Phone", phoneCustomer.Text);
                cmd.Parameters.AddWithValue("@First_Name", fistNameCustomer.Text);
                cmd.Parameters.AddWithValue("@Last_Name", lastNameCustomer.Text);
                cmd.Parameters.AddWithValue("@Address_Customer", adressCustomer.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Клієнт добавлений", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Помилка у введені даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
