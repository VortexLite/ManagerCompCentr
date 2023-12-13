using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCompCentr.Forms
{
    public partial class DellEmployee : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public DellEmployee()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void EnterOK_Click(object sender, EventArgs e)
        {
            string combotxt = dellEmployeee.Text;
            string[] words2 = combotxt.Split(' ');
            string id = words2[0];

            if (dellEmployeee.SelectedItem != null)
            {
                var cmd = new SqlCommand("DellEmployee", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                dellEmployeee.Items.Remove(dellEmployeee.SelectedItem);
                MessageBox.Show("Працівника звільнено", "Успіх", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Помилка у видаленні", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DellEmployee_Load(object sender, EventArgs e)
        {
            dellEmployeee.Items.Clear();
            var cmd = new SqlCommand("select EmployeeID, First_Name, Last_Name\r\nfrom Employee", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetInt32(0).ToString();
                string fistName = reader.GetString(1);
                string lastName = reader.GetString(2);
                string comboBoxItem = $"{id} {fistName} {lastName}";
                dellEmployeee.Items.Add(comboBoxItem);
            }
            reader.Close();
        }
    }
}
