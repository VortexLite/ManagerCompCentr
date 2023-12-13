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
    public partial class OrderDell : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public OrderDell()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void OrderDell_Load(object sender, EventArgs e)
        {
            dellOrder.Items.Clear();
            var cmd = new SqlCommand("select OrderID, prod.Product_Name, Total_Amount from Orders inner join Product as prod ON prod.ProductID = Orders.ProductID", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetInt32(0).ToString();
                string name = reader.GetString(1);
                string total_amount = reader.GetDecimal(2).ToString();
                string comboBoxItem = $"{id} {name} {total_amount}";
                dellOrder.Items.Add(comboBoxItem);
            }
            reader.Close();
        }

        private void EnterOK_Click(object sender, EventArgs e)
        {
            string combotxt = dellOrder.Text;
            string[] words2 = combotxt.Split(' ');
            string id = words2[0];

            if (dellOrder.SelectedItem != null)
            {
                var cmd = new SqlCommand("DellOrder", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                dellOrder.Items.Remove(dellOrder.SelectedItem);
                MessageBox.Show("Запис на прийом видалено", "Успіх", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Помилка у видаленні", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
