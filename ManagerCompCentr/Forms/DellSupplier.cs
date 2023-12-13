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
    public partial class DellSupplier : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public DellSupplier()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void EnterOK_Click(object sender, EventArgs e)
        {
            string combotxt = dellSupplierss.Text;
            string[] words2 = combotxt.Split(' ');
            string id = words2[0];

            if (dellSupplierss.SelectedItem != null)
            {
                var cmd = new SqlCommand("DellSupplier", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                dellSupplierss.Items.Remove(dellSupplierss.SelectedItem);
                MessageBox.Show("Постачальника видалено", "Успіх", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Помилка у видаленні", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DellSupplier_Load(object sender, EventArgs e)
        {
            dellSupplierss.Items.Clear();
            var cmd = new SqlCommand("select SupplierID, Company_Name, Contact_Person\r\nfrom Suppliers", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetInt32(0).ToString();
                string compName = reader.GetString(1);
                string ContactPerson = reader.GetString(2);
                string comboBoxItem = $"{id} {compName} {ContactPerson}";
                dellSupplierss.Items.Add(comboBoxItem);
            }
            reader.Close();
        }
    }
}
