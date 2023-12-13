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
    public partial class AddProduct : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public AddProduct()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void EnterOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameProduct.Text) &&
                !string.IsNullOrWhiteSpace(descriptionProduct.Text) &&
                !string.IsNullOrWhiteSpace(priceProduct.Text) &&
                !string.IsNullOrWhiteSpace(supplierIDProduct.Text))
            {
                string idProduct = "";
                var command = new SqlCommand("SELECT MAX(CAST(ProductID AS INT)) AS max_id FROM Product", connection);
                try
                {
                    idProduct = Convert.ToString(Convert.ToInt32(command.ExecuteScalar().ToString()) + 1);
                }
                catch
                {
                    idProduct = "1";
                }

                string combotxt = supplierIDProduct.Text;
                string[] words = combotxt.Split(' ');
                string idSupplier = words[0];

                var cmd = new SqlCommand("AddProduct", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductID", idProduct);
                cmd.Parameters.AddWithValue("@Product_Name", nameProduct.Text);
                cmd.Parameters.AddWithValue("@Description_Product", descriptionProduct.Text);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(priceProduct.Text));
                cmd.Parameters.AddWithValue("@SupplierID", idSupplier);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Товар доданий", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Помилка у введені даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            supplierIDProduct.Items.Clear();
            var cmd = new SqlCommand("select SupplierID, Company_Name, Contact_Person\r\nfrom Suppliers", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string idCustomer = reader.GetInt32(0).ToString();
                string companyName = reader.GetString(1);
                string ContactPerson = reader.GetString(2);
                string comboBoxItem = $"{idCustomer} {companyName} {ContactPerson}";
                supplierIDProduct.Items.Add(comboBoxItem);
            }
            reader.Close();
        }
    }
}
