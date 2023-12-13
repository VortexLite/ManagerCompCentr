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
    public partial class DellReview : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public DellReview()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void DellReview_Load(object sender, EventArgs e)
        {
            dellRevieww.Items.Clear();
            var cmd = new SqlCommand("select ReviewID, Review_Text, prod.Product_Name\r\nfrom Reviews\r\ninner join Product as prod ON prod.ProductID = Reviews.ProductID", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetInt32(0).ToString();
                string reviewText = reader.GetString(1);
                string productName = reader.GetString(2);
                string comboBoxItem = $"{id} {reviewText} {productName}";
                dellRevieww.Items.Add(comboBoxItem);
            }
            reader.Close();
        }

        private void EnterOK_Click(object sender, EventArgs e)
        {
            string combotxt = dellRevieww.Text;
            string[] words2 = combotxt.Split(' ');
            string id = words2[0];

            if (dellRevieww.SelectedItem != null)
            {
                var cmd = new SqlCommand("DellReview", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                dellRevieww.Items.Remove(dellRevieww.SelectedItem);
                MessageBox.Show("Відгук видалено", "Успіх", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Помилка у видаленні", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
