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
using ManagerCompCentr.Forms;
using ManagerCompCentr.Report;

namespace ManagerCompCentr
{
    public partial class Form2 : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;

        private string login;


        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;

        public Form2(string login)
        {
            InitializeComponent();
            this.login = login;
            dataGridView1.Hide();
            menuStripView.Hide();

            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();

            if (login == "manager") 
                ReportBtn.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            bool hasOpenForms = Application.OpenForms.Cast<Form>().Any(form => form.Visible);

            if (!hasOpenForms)
            {
                Application.Exit();
            }
        }

        private void Views()
        {
            ToolStripMenuItem suppliersView = new ToolStripMenuItem("Постачальники");
            ToolStripMenuItem productView = new ToolStripMenuItem("Товари");
            ToolStripMenuItem employeeView = new ToolStripMenuItem("Працівники");
            ToolStripMenuItem customerView = new ToolStripMenuItem("База клієнтів");
            ToolStripMenuItem reviewsView = new ToolStripMenuItem("Відгуки");
            ToolStripMenuItem orderView = new ToolStripMenuItem("Замовлення");
            menuStripView.Items.Add(suppliersView);
            menuStripView.Items.Add(productView);
            menuStripView.Items.Add(employeeView);
            menuStripView.Items.Add(customerView);
            menuStripView.Items.Add(reviewsView);
            menuStripView.Items.Add(orderView);

            suppliersView.Click += SuppliersView_Click;
            productView.Click += ProductView_Click;
            employeeView.Click += EmployeeView_Click;
            customerView.Click += CustomerView_Click;
            reviewsView.Click += ReviewsView_Click;
            orderView.Click += OrderView_Click;
        }

        private void OrderView_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Show();
            dataAdapter = new SqlDataAdapter("select \r\nOrderID as [ID], \r\nDate_Orders as [Дата],\r\nTotal_Amount as [Загальна сума],\r\nProduct_Quantity as [Кількість товару],\r\ncus.First_Name as [Ім'я клієнта],\r\ncus.Last_Name as [Прізвище клієнта],\r\nemp.First_Name as [Ім'я продавця],\r\nemp.Last_Name as [Прізвище продавця],\r\nstat.StatusOrder as [Статус заказу]\r\nfrom Orders\r\ninner join Customer as cus ON cus.CustomerID = Orders.CustomerID\r\ninner join Employee as emp ON emp.EmployeeID = Orders.EmployeeID\r\ninner join Status_Order as stat ON stat.StatusID = Orders.StatusID", connection);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Orders");

            dataGridView1.DataSource = dataSet.Tables["Orders"];
        }

        private void ReviewsView_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Show();
            dataAdapter = new SqlDataAdapter("select \r\nReviewID as [ID], \r\nReview_Text as [Відгук],\r\nDate_Review as [Дата],\r\nprod.Product_Name as [Назва продукту],\r\ncus.First_Name as [Ім'я],\r\ncus.Last_Name as [Прізвище]\r\nfrom Reviews\r\ninner join Product as prod ON prod.ProductID = Reviews.ProductID\r\ninner join Customer as cus ON cus.CustomerID = Reviews.CustomerID", connection);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Reviews");

            dataGridView1.DataSource = dataSet.Tables["Reviews"];
        }

        private void CustomerView_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Show();
            dataAdapter = new SqlDataAdapter("select \r\nCustomerID as [ID], \r\nEmail,\r\nPhone as [Телефон],\r\nFirst_Name as [Ім'я],\r\nLast_Name as [Прізвище],\r\nAddress_Customer as [Адреса]\r\nfrom Customer", connection);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Customer");

            dataGridView1.DataSource = dataSet.Tables["Customer"];
        }

        private void EmployeeView_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Show();
            dataAdapter = new SqlDataAdapter("select \r\nEmployeeID as [ID], \r\nEmployee_Phone as [Телефон],\r\nFirst_Name as [Ім'я],\r\nLast_Name as [Прізвище],\r\nEmail\r\nfrom Employee", connection);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Employee");

            dataGridView1.DataSource = dataSet.Tables["Employee"];
        }

        private void ProductView_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Show();
            dataAdapter = new SqlDataAdapter("select \r\nProductID as [ID], \r\nProduct_Name as [Назва продукта],\r\nDescription_Product as [Опис],\r\nPrice as [Ціна],\r\nsup.Company_Name as [Тип запчастини]\r\nfrom Product\r\ninner join Suppliers as sup ON sup.SupplierID = Product.SupplierID", connection);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Product");

            dataGridView1.DataSource = dataSet.Tables["Product"];
        }

        private void SuppliersView_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Show();
            dataAdapter = new SqlDataAdapter("select \r\nSupplierID as [ID], \r\nCompany_Name as [Назва компанії],\r\nContact_Person as [Контакти],\r\nPhone as [Телефон],\r\nEmail,\r\nAddress_Suppliers as [Адреса]\r\nfrom Suppliers", connection);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Suppliers");

            dataGridView1.DataSource = dataSet.Tables["Suppliers"];
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            CentrText.Text = ViewBtn.Text;

            menuStripView.Show();
            menuStripView.Items.Clear();
            dataGridView1.ClearSelection();
            dataGridView1.Show();

            Views();
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            CentrText.Text = OrderBtn.Text;

            menuStripView.Show();
            menuStripView.Items.Clear();
            dataGridView1.ClearSelection();
            dataGridView1.Hide();

            Order();
        }

        private void Order()
        {
            ToolStripMenuItem orderAddView = new ToolStripMenuItem("Зробити замовлення");
            ToolStripMenuItem orderDellView = new ToolStripMenuItem("Відмінити замовлення");

            menuStripView.Items.Add(orderAddView);
            menuStripView.Items.Add(orderDellView);

            orderAddView.Click += OrderAddView_Click;
            orderDellView.Click += OrderDellView_Click;
        }

        private void OrderDellView_Click(object sender, EventArgs e)
        {
            var orderDell = new OrderDell();
            orderDell.ShowDialog();
        }

        private void OrderAddView_Click(object sender, EventArgs e)
        {
            var addOrder = new OrderAdd();
            addOrder.ShowDialog();
        }

        private void ControlMenu()
        {
            if (login == "director")
            {
                ToolStripMenuItem employeeControl = new ToolStripMenuItem("Працівники");
                ToolStripMenuItem customerControl = new ToolStripMenuItem("Клієнти");
                ToolStripMenuItem reviewsControl = new ToolStripMenuItem("Відгуки");
                ToolStripMenuItem productControl = new ToolStripMenuItem("Продукти");
                ToolStripMenuItem suppliersControl = new ToolStripMenuItem("Постачальники");

                ToolStripMenuItem addEmployeeControl = new ToolStripMenuItem("Найняти працівника");
                ToolStripMenuItem dellEmployeeControl = new ToolStripMenuItem("Звільнити працівника");

                ToolStripMenuItem addCustomerControl = new ToolStripMenuItem("Добавити клієнта");
                ToolStripMenuItem dellCustomerControl = new ToolStripMenuItem("Видалити клієнта");

                ToolStripMenuItem addReviewsControl = new ToolStripMenuItem("Дадати відгука");
                ToolStripMenuItem dellReviewsControl = new ToolStripMenuItem("Видалити відгука");

                ToolStripMenuItem addProductControl = new ToolStripMenuItem("Добавити продукт");
                ToolStripMenuItem dellProductControl = new ToolStripMenuItem("Видалити продукт");

                ToolStripMenuItem addSuppliersControl = new ToolStripMenuItem("Добавити постачальника");
                ToolStripMenuItem dellSuppliersControl = new ToolStripMenuItem("Видалити постачальника");

                employeeControl.DropDownItems.Add(addEmployeeControl);
                employeeControl.DropDownItems.Add(dellEmployeeControl);

                customerControl.DropDownItems.Add(addCustomerControl);
                customerControl.DropDownItems.Add(dellCustomerControl);

                reviewsControl.DropDownItems.Add(addReviewsControl);
                reviewsControl.DropDownItems.Add(dellReviewsControl);

                productControl.DropDownItems.Add(addProductControl);
                productControl.DropDownItems.Add(dellProductControl);

                suppliersControl.DropDownItems.Add(addSuppliersControl);
                suppliersControl.DropDownItems.Add(dellSuppliersControl);

                menuStripView.Items.Add(employeeControl);
                menuStripView.Items.Add(customerControl);
                menuStripView.Items.Add(reviewsControl);
                menuStripView.Items.Add(productControl);
                menuStripView.Items.Add(suppliersControl);

                addEmployeeControl.Click += addEmployeeControl_Click;
                dellEmployeeControl.Click += dellEmployeeControl_Click;

                addCustomerControl.Click += addCustomerControl_Click;
                dellCustomerControl.Click += dellCustomerControl_Click;

                addReviewsControl.Click += addReviewsControl_Click;
                dellReviewsControl.Click += dellReviewsControl_Click;

                addProductControl.Click += addProductControl_Click;
                dellProductControl.Click += dellProductControl_Click;

                addSuppliersControl.Click += addSuppliersControl_Click;
                dellSuppliersControl.Click += dellSuppliersControl_Click;
            }
            else
            {
                ToolStripMenuItem customerControl = new ToolStripMenuItem("Клієнти");
                ToolStripMenuItem reviewsControl = new ToolStripMenuItem("Відгуки");
                ToolStripMenuItem productControl = new ToolStripMenuItem("Продукти");

                ToolStripMenuItem addCustomerControl = new ToolStripMenuItem("Добавити клієнта");
                ToolStripMenuItem dellCustomerControl = new ToolStripMenuItem("Видалити клієнта");

                ToolStripMenuItem addReviewsControl = new ToolStripMenuItem("Дадати відгука");
                ToolStripMenuItem dellReviewsControl = new ToolStripMenuItem("Видалити відгука");

                ToolStripMenuItem addProductControl = new ToolStripMenuItem("Добавити продукт");
                ToolStripMenuItem dellProductControl = new ToolStripMenuItem("Видалити продукт");

                customerControl.DropDownItems.Add(addCustomerControl);
                customerControl.DropDownItems.Add(dellCustomerControl);

                reviewsControl.DropDownItems.Add(addReviewsControl);
                reviewsControl.DropDownItems.Add(dellReviewsControl);

                productControl.DropDownItems.Add(addProductControl);
                productControl.DropDownItems.Add(dellProductControl);

                menuStripView.Items.Add(customerControl);
                menuStripView.Items.Add(reviewsControl);
                menuStripView.Items.Add(productControl);

                addCustomerControl.Click += addCustomerControl_Click;
                dellCustomerControl.Click += dellCustomerControl_Click;

                addReviewsControl.Click += addReviewsControl_Click;
                dellReviewsControl.Click += dellReviewsControl_Click;

                addProductControl.Click += addProductControl_Click;
                dellProductControl.Click += dellProductControl_Click;
            }

        }

        private void dellSuppliersControl_Click(object sender, EventArgs e)
        {
            var dellSupplier = new DellSupplier();
            dellSupplier.ShowDialog();
        }

        private void addSuppliersControl_Click(object sender, EventArgs e)
        {
            var addSuppliers = new AddSupplier();
            addSuppliers.ShowDialog();
        }

        private void dellProductControl_Click(object sender, EventArgs e)
        {
            var dellProduct = new DellProduct();
            dellProduct.ShowDialog();
        }

        private void addProductControl_Click(object sender, EventArgs e)
        {
            var addProduct = new AddProduct();
            addProduct.ShowDialog();
        }

        private void dellReviewsControl_Click(object sender, EventArgs e)
        {
            var dellReview = new DellReview();
            dellReview.ShowDialog();
        }

        private void addReviewsControl_Click(object sender, EventArgs e)
        {
            var addReview = new AddReview();
            addReview.ShowDialog();
        }

        private void dellCustomerControl_Click(object sender, EventArgs e)
        {
            var dellCustomer = new DellCustomer();
            dellCustomer.ShowDialog();
        }

        private void addCustomerControl_Click(object sender, EventArgs e)
        {
            var addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }

        private void dellEmployeeControl_Click(object sender, EventArgs e)
        {
            var dellEmployee = new DellEmployee();
            dellEmployee.ShowDialog();
        }

        private void addEmployeeControl_Click(object sender, EventArgs e)
        {
            var addEmployee = new AddEmoloyee();
            addEmployee.ShowDialog();
        }

        private void ControlBtn_Click(object sender, EventArgs e)
        {
            CentrText.Text = ControlBtn.Text;

            menuStripView.Show();
            menuStripView.Items.Clear();
            dataGridView1.ClearSelection();
            dataGridView1.Hide();

            ControlMenu();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            var auth = new Form1();
            this.Hide();
            auth.ShowDialog();
        }

        private void ReportR()
        {
            ToolStripMenuItem reportCustomerOrder = new ToolStripMenuItem("Звіт по клієнтам які зробили замовлення");
            ToolStripMenuItem reportSupplierProduct = new ToolStripMenuItem("Наявних продуктів від постачальника");

            menuStripView.Items.Add(reportCustomerOrder);
            menuStripView.Items.Add(reportSupplierProduct);

            reportCustomerOrder.Click += ReportCustomerOrder_Click;
            reportSupplierProduct.Click += ReportSupplierProduct_Click;
        }

        private void ReportSupplierProduct_Click(object sender, EventArgs e)
        {
            var reportSupplierProduct = new ReportSupplierProduct();
            reportSupplierProduct.ShowDialog();
        }

        private void ReportCustomerOrder_Click(object sender, EventArgs e)
        {
            var reportCustomerOrder = new ReportCustomerOrder();
            reportCustomerOrder.ShowDialog();
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            CentrText.Text = ReportBtn.Text;

            menuStripView.Show();
            menuStripView.Items.Clear();
            dataGridView1.ClearSelection();
            dataGridView1.Hide();

            ReportR();
        }
    }
}
