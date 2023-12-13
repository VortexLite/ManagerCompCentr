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
    public partial class DellCustomer : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public DellCustomer()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void EnterOK_Click(object sender, EventArgs e)
        {
            string combotxt = dellCustomerr.Text;
            string[] words2 = combotxt.Split(' ');
            string id = words2[0];

            if (dellCustomerr.SelectedItem != null)
            {
                var cmd = new SqlCommand("DellCustomer", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                dellCustomerr.Items.Remove(dellCustomerr.SelectedItem);
                MessageBox.Show("Клієнта видалено", "Успіх", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Помилка у видаленні", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DellCustomer_Load(object sender, EventArgs e)
        {
            dellCustomerr.Items.Clear();
            var cmd = new SqlCommand("select CustomerID, First_Name, Last_Name\r\nfrom Customer", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetInt32(0).ToString();
                string fistName = reader.GetString(1);
                string lastName = reader.GetString(2);
                string comboBoxItem = $"{id} {fistName} {lastName}";
                dellCustomerr.Items.Add(comboBoxItem);
            }
            reader.Close();
        }
    }
}
