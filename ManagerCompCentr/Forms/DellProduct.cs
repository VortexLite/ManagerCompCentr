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
    public partial class DellProduct : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public DellProduct()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void EnterOK_Click(object sender, EventArgs e)
        {
            string combotxt = dellProductt.Text;
            string[] words2 = combotxt.Split(' ');
            string id = words2[0];

            if (dellProductt.SelectedItem != null)
            {
                var cmd = new SqlCommand("DellProduct", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                dellProductt.Items.Remove(dellProductt.SelectedItem);
                MessageBox.Show("Продукт видалено", "Успіх", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Помилка у видаленні", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DellProduct_Load(object sender, EventArgs e)
        {
            dellProductt.Items.Clear();
            var cmd = new SqlCommand("select ProductID, Product_Name, Price\r\nfrom Product", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetInt32(0).ToString();
                string productName = reader.GetString(1);
                string Price = reader.GetDecimal(2).ToString();
                string comboBoxItem = $"{id} {productName} {Price}";
                dellProductt.Items.Add(comboBoxItem);
            }
            reader.Close();
        }
    }
}
