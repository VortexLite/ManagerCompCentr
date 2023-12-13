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
    public partial class AddEmoloyee : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public AddEmoloyee()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void EnterOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(phoneEmployee.Text) &&
                !string.IsNullOrWhiteSpace(fistNameEmployee.Text) &&
                !string.IsNullOrWhiteSpace(lastNameEmployee.Text) &&
                !string.IsNullOrWhiteSpace(emailEmployee.Text))
            {
                string idEmployee = "";
                var command = new SqlCommand("SELECT MAX(CAST(EmployeeID AS INT)) AS max_id FROM Employee", connection);
                try
                {
                    idEmployee = Convert.ToString(Convert.ToInt32(command.ExecuteScalar().ToString()) + 1);
                }
                catch
                {
                    idEmployee = "1";
                }

                var cmd = new SqlCommand("AddEmployee", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeID", idEmployee);
                cmd.Parameters.AddWithValue("@Employee_Phone", phoneEmployee.Text);
                cmd.Parameters.AddWithValue("@First_Name", fistNameEmployee.Text);
                cmd.Parameters.AddWithValue("@Last_Name", lastNameEmployee.Text);
                cmd.Parameters.AddWithValue("@Email", emailEmployee.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Працівник найнятий", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Помилка у введені даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
