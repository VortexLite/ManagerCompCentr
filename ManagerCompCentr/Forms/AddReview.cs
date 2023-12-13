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
    public partial class AddReview : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;

        private string dateTime;
        public AddReview()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void AddReview_Load(object sender, EventArgs e)
        {
            productIDReview.Items.Clear();
            var cmd = new SqlCommand("select ProductID, Product_Name, Price\r\nfrom Product", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string idCustomer = reader.GetInt32(0).ToString();
                string firstName = reader.GetString(1);
                string LastName = reader.GetDecimal(2).ToString();
                string comboBoxItem = $"{idCustomer} {firstName} {LastName}";
                productIDReview.Items.Add(comboBoxItem);
            }
            reader.Close();

            customerIDReview.Items.Clear();
            cmd = new SqlCommand("select CustomerID, First_Name, Last_Name\r\nfrom Customer", connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string idEmployee = reader.GetInt32(0).ToString();
                string firstName = reader.GetString(1);
                string LastName = reader.GetString(2);
                string comboBoxItem = $"{idEmployee} {firstName} {LastName}";
                customerIDReview.Items.Add(comboBoxItem);
            }
            reader.Close();

            dateTime = DateTime.Now.ToString("yyyy-MM-dd");

            dateReview.Text = dateTime;
        }

        private void EnterOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextReview.Text) &&
                !string.IsNullOrWhiteSpace(dateReview.Text) &&
                !string.IsNullOrWhiteSpace(productIDReview.Text) &&
                !string.IsNullOrWhiteSpace(customerIDReview.Text))
            {
                string idReview = "";
                var command = new SqlCommand("SELECT MAX(CAST(OrderID AS INT)) AS max_id FROM Orders", connection);
                try
                {
                    idReview = Convert.ToString(Convert.ToInt32(command.ExecuteScalar().ToString()) + 1);
                }
                catch
                {
                    idReview = "1";
                }

                string combotxt = productIDReview.Text;
                string[] words = combotxt.Split(' ');
                string idProduct = words[0];

                combotxt = customerIDReview.Text;
                words = combotxt.Split(' ');
                string idCustomer = words[0];

                var cmd = new SqlCommand("AddReview", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReviewID", idReview);
                cmd.Parameters.AddWithValue("@Review_Text", TextReview.Text);
                cmd.Parameters.AddWithValue("@Date_Review", dateReview.Text);
                cmd.Parameters.AddWithValue("@ProductID", idProduct);
                cmd.Parameters.AddWithValue("@CustomerID", idCustomer);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Відгук додано", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Помилка у введені даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
