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
    public partial class AddSupplier : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public AddSupplier()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void EnterOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(companyNameSupplier.Text) &&
                !string.IsNullOrWhiteSpace(contactSupplier.Text) &&
                !string.IsNullOrWhiteSpace(phoneSupplier.Text) &&
                !string.IsNullOrWhiteSpace(emailSupplier.Text) &&
                !string.IsNullOrWhiteSpace(addressSupplier.Text))
            {
                string idSupplier = "";
                var command = new SqlCommand("SELECT MAX(CAST(SupplierID AS INT)) AS max_id FROM Suppliers", connection);
                try
                {
                    idSupplier = Convert.ToString(Convert.ToInt32(command.ExecuteScalar().ToString()) + 1);
                }
                catch
                {
                    idSupplier = "1";
                }

                var cmd = new SqlCommand("AddSupplier", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SupplierID", idSupplier);
                cmd.Parameters.AddWithValue("@Company_Name", companyNameSupplier.Text);
                cmd.Parameters.AddWithValue("@Contact_Person", contactSupplier.Text);
                cmd.Parameters.AddWithValue("@Phone", phoneSupplier.Text);
                cmd.Parameters.AddWithValue("@Email", emailSupplier.Text);
                cmd.Parameters.AddWithValue("@Address_Suppliers", addressSupplier.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Постачальник добавлений", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Помилка у введені даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
