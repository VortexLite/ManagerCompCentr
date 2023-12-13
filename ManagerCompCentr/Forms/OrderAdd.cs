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
using System.Windows.Forms.VisualStyles;

namespace ManagerCompCentr.Forms
{
    public partial class OrderAdd : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;

        private string dateTime;
        public OrderAdd()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void OrderAdd_Load(object sender, EventArgs e)
        {
            customerOrder.Items.Clear();
            var cmd = new SqlCommand("select\r\nCustomerID, First_Name, Last_Name\r\nfrom Customer", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string idCustomer = reader.GetInt32(0).ToString();
                string firstName = reader.GetString(1);
                string LastName = reader.GetString(2);
                string comboBoxItem = $"{idCustomer} {firstName} {LastName}";
                customerOrder.Items.Add(comboBoxItem);
            }
            reader.Close();

            employeeOrder.Items.Clear();
            cmd = new SqlCommand("select\r\nEmployeeID, First_Name, Last_Name\r\nfrom Employee", connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string idEmployee = reader.GetInt32(0).ToString();
                string firstName = reader.GetString(1);
                string LastName = reader.GetString(2);
                string comboBoxItem = $"{idEmployee} {firstName} {LastName}";
                employeeOrder.Items.Add(comboBoxItem);
            }
            reader.Close();

            statusOrder.Items.Clear();
            cmd = new SqlCommand("select\r\nStatusID, StatusOrder\r\nfrom Status_Order", connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string idStatus = reader.GetInt32(0).ToString();
                string Status = reader.GetString(1);
                string comboBoxItem = $"{idStatus} {Status}";
                statusOrder.Items.Add(comboBoxItem);
            }
            reader.Close();

            productOrder.Items.Clear();
            cmd = new SqlCommand("select ProductID, Product_Name, Price \r\nfrom Product", connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string idProduct = reader.GetInt32(0).ToString();
                string name = reader.GetString(1);
                string price= reader.GetDecimal(2).ToString();
                string comboBoxItem = $"{idProduct} {name} {price}";
                productOrder.Items.Add(comboBoxItem);
            }
            reader.Close();

            dateTime = DateTime.Now.ToString("yyyy-MM-dd");

            DateOrder.Text = dateTime;
        }

        private void productOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string combotxt = productOrder.Text;
                string[] words = combotxt.Split(' ');
                string price = words[words.Length - 1];
                TotalAmount.Text = Convert.ToString(Convert.ToDecimal(price) * Convert.ToDecimal(Product_Quantity.Text));
            }
            catch
            {
                
            }
            
        }

        private void EnterOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TotalAmount.Text) &&
                !string.IsNullOrWhiteSpace(Product_Quantity.Text) &&
                !string.IsNullOrWhiteSpace(customerOrder.Text) &&
                !string.IsNullOrWhiteSpace(employeeOrder.Text) &&
                !string.IsNullOrWhiteSpace(statusOrder.Text))
            {
                string idOrder = "";
                var command = new SqlCommand("SELECT MAX(CAST(OrderID AS INT)) AS max_id FROM Orders", connection);
                try
                {
                    idOrder = Convert.ToString(Convert.ToInt32(command.ExecuteScalar().ToString()) + 1);
                }
                catch
                {
                    idOrder = "1";
                }

                string combotxt = customerOrder.Text;
                string[] words = combotxt.Split(' ');
                string idCustomer = words[0];

                combotxt = employeeOrder.Text;
                words = combotxt.Split(' '); 
                string idEmployee = words[0];

                combotxt = statusOrder.Text;
                words = combotxt.Split(' ');
                string idStatus = words[0];

                combotxt = productOrder.Text;
                words = combotxt.Split(' ');
                string idProduct = words[0];

                var cmd = new SqlCommand("AddOrder", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrderID", idOrder);
                cmd.Parameters.AddWithValue("@Date_Orders", dateTime);
                cmd.Parameters.AddWithValue("@Total_Amount", Convert.ToDecimal(TotalAmount.Text));
                cmd.Parameters.AddWithValue("@Product_Quantity", Product_Quantity.Text);
                cmd.Parameters.AddWithValue("@CustomerID", idCustomer);
                cmd.Parameters.AddWithValue("@EmployeeID", idEmployee);
                cmd.Parameters.AddWithValue("@StatusID", idStatus);
                cmd.Parameters.AddWithValue("@ProductID", idProduct);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Замовлення оформленно", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Помилка у введені даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
