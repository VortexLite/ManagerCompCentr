using Microsoft.Reporting.WinForms;
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

namespace ManagerCompCentr.Report
{
    public partial class ReportSupplierProduct : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public ReportSupplierProduct()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void ReportSupplierProduct_Load(object sender, EventArgs e)
        {

            string quary = "select * from SupplierDetails order by Company_Name";

            SqlCommand comand = new SqlCommand(quary, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet2", dataTable);
            reportViewer1.LocalReport.ReportPath = "Report2.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);

            reportViewer1.RefreshReport();
        }
    }
}
