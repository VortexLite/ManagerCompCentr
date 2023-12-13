namespace ManagerCompCentr
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStripView = new System.Windows.Forms.MenuStrip();
            this.SuppliersView = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductView = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeView = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerView = new System.Windows.Forms.ToolStripMenuItem();
            this.ReviewView = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderView = new System.Windows.Forms.ToolStripMenuItem();
            this.CentrText = new System.Windows.Forms.Label();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.ControlBtn = new System.Windows.Forms.Button();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStripView.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.menuStripView);
            this.panel1.Location = new System.Drawing.Point(153, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 521);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(916, 487);
            this.dataGridView1.TabIndex = 1;
            // 
            // menuStripView
            // 
            this.menuStripView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SuppliersView,
            this.ProductView,
            this.EmployeeView,
            this.CustomerView,
            this.ReviewView,
            this.OrderView});
            this.menuStripView.Location = new System.Drawing.Point(0, 0);
            this.menuStripView.Name = "menuStripView";
            this.menuStripView.Size = new System.Drawing.Size(916, 28);
            this.menuStripView.TabIndex = 0;
            this.menuStripView.Text = "menuStrip1";
            // 
            // SuppliersView
            // 
            this.SuppliersView.Name = "SuppliersView";
            this.SuppliersView.Size = new System.Drawing.Size(130, 24);
            this.SuppliersView.Text = "Постачальники";
            this.SuppliersView.Click += new System.EventHandler(this.SuppliersView_Click);
            // 
            // ProductView
            // 
            this.ProductView.Name = "ProductView";
            this.ProductView.Size = new System.Drawing.Size(74, 24);
            this.ProductView.Text = "Товари";
            this.ProductView.Click += new System.EventHandler(this.ProductView_Click);
            // 
            // EmployeeView
            // 
            this.EmployeeView.Name = "EmployeeView";
            this.EmployeeView.Size = new System.Drawing.Size(106, 24);
            this.EmployeeView.Text = "Працівники";
            this.EmployeeView.Click += new System.EventHandler(this.EmployeeView_Click);
            // 
            // CustomerView
            // 
            this.CustomerView.Name = "CustomerView";
            this.CustomerView.Size = new System.Drawing.Size(112, 24);
            this.CustomerView.Text = "База клієнтів";
            this.CustomerView.Click += new System.EventHandler(this.CustomerView_Click);
            // 
            // ReviewView
            // 
            this.ReviewView.Name = "ReviewView";
            this.ReviewView.Size = new System.Drawing.Size(73, 24);
            this.ReviewView.Text = "Відгуки";
            this.ReviewView.Click += new System.EventHandler(this.ReviewsView_Click);
            // 
            // OrderView
            // 
            this.OrderView.Name = "OrderView";
            this.OrderView.Size = new System.Drawing.Size(109, 24);
            this.OrderView.Text = "Замовлення";
            this.OrderView.Click += new System.EventHandler(this.OrderView_Click);
            // 
            // CentrText
            // 
            this.CentrText.BackColor = System.Drawing.Color.SlateBlue;
            this.CentrText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CentrText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CentrText.Location = new System.Drawing.Point(0, -1);
            this.CentrText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CentrText.Name = "CentrText";
            this.CentrText.Size = new System.Drawing.Size(1069, 42);
            this.CentrText.TabIndex = 2;
            this.CentrText.Text = "Перегляд";
            this.CentrText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.ViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ViewBtn.Location = new System.Drawing.Point(16, 118);
            this.ViewBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(115, 34);
            this.ViewBtn.TabIndex = 3;
            this.ViewBtn.Text = "Перегляд";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // ControlBtn
            // 
            this.ControlBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.ControlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ControlBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ControlBtn.Location = new System.Drawing.Point(16, 233);
            this.ControlBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ControlBtn.Name = "ControlBtn";
            this.ControlBtn.Size = new System.Drawing.Size(115, 34);
            this.ControlBtn.TabIndex = 4;
            this.ControlBtn.Text = "Управління";
            this.ControlBtn.UseVisualStyleBackColor = false;
            this.ControlBtn.Click += new System.EventHandler(this.ControlBtn_Click);
            // 
            // ReportBtn
            // 
            this.ReportBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.ReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReportBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ReportBtn.Location = new System.Drawing.Point(16, 289);
            this.ReportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(115, 34);
            this.ReportBtn.TabIndex = 5;
            this.ReportBtn.Text = "Звіти";
            this.ReportBtn.UseVisualStyleBackColor = false;
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // OrderBtn
            // 
            this.OrderBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.OrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OrderBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OrderBtn.Location = new System.Drawing.Point(16, 174);
            this.OrderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(115, 34);
            this.OrderBtn.TabIndex = 6;
            this.OrderBtn.Text = "Замовлення";
            this.OrderBtn.UseVisualStyleBackColor = false;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitBtn.Location = new System.Drawing.Point(16, 505);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(115, 34);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Вихід";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.ReportBtn);
            this.Controls.Add(this.ControlBtn);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.CentrText);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStripView;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "АРМ менеджера комп техніки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStripView.ResumeLayout(false);
            this.menuStripView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CentrText;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Button ControlBtn;
        private System.Windows.Forms.Button ReportBtn;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.MenuStrip menuStripView;
        private System.Windows.Forms.ToolStripMenuItem SuppliersView;
        private System.Windows.Forms.ToolStripMenuItem ProductView;
        private System.Windows.Forms.ToolStripMenuItem EmployeeView;
        private System.Windows.Forms.ToolStripMenuItem CustomerView;
        private System.Windows.Forms.ToolStripMenuItem ReviewView;
        private System.Windows.Forms.ToolStripMenuItem OrderView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ExitBtn;
    }
}