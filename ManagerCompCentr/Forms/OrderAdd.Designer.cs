namespace ManagerCompCentr.Forms
{
    partial class OrderAdd
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
            this.EnterOK = new System.Windows.Forms.Button();
            this.Product_Quantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateOrder = new System.Windows.Forms.Label();
            this.customerOrder = new System.Windows.Forms.ComboBox();
            this.employeeOrder = new System.Windows.Forms.ComboBox();
            this.statusOrder = new System.Windows.Forms.ComboBox();
            this.productOrder = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterOK
            // 
            this.EnterOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterOK.Location = new System.Drawing.Point(68, 343);
            this.EnterOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterOK.Name = "EnterOK";
            this.EnterOK.Size = new System.Drawing.Size(395, 43);
            this.EnterOK.TabIndex = 31;
            this.EnterOK.Text = "Оформити";
            this.EnterOK.UseVisualStyleBackColor = true;
            this.EnterOK.Click += new System.EventHandler(this.EnterOK_Click);
            // 
            // Product_Quantity
            // 
            this.Product_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Product_Quantity.Location = new System.Drawing.Point(232, 123);
            this.Product_Quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Product_Quantity.Name = "Product_Quantity";
            this.Product_Quantity.Size = new System.Drawing.Size(231, 26);
            this.Product_Quantity.TabIndex = 27;
            this.Product_Quantity.TextChanged += new System.EventHandler(this.productOrder_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(63, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Статус";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(63, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Продавець";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(63, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Клієнт";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(63, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Кількість товару";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(63, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Загальна сума";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(63, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Дата";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SlateBlue;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(0, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(523, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Оформлення замовлення";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(36, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 409);
            this.label1.TabIndex = 17;
            // 
            // DateOrder
            // 
            this.DateOrder.BackColor = System.Drawing.SystemColors.Control;
            this.DateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOrder.Location = new System.Drawing.Point(232, 49);
            this.DateOrder.Name = "DateOrder";
            this.DateOrder.Size = new System.Drawing.Size(231, 30);
            this.DateOrder.TabIndex = 32;
            // 
            // customerOrder
            // 
            this.customerOrder.FormattingEnabled = true;
            this.customerOrder.Location = new System.Drawing.Point(232, 174);
            this.customerOrder.Margin = new System.Windows.Forms.Padding(4);
            this.customerOrder.Name = "customerOrder";
            this.customerOrder.Size = new System.Drawing.Size(231, 24);
            this.customerOrder.TabIndex = 33;
            // 
            // employeeOrder
            // 
            this.employeeOrder.FormattingEnabled = true;
            this.employeeOrder.Location = new System.Drawing.Point(231, 212);
            this.employeeOrder.Margin = new System.Windows.Forms.Padding(4);
            this.employeeOrder.Name = "employeeOrder";
            this.employeeOrder.Size = new System.Drawing.Size(231, 24);
            this.employeeOrder.TabIndex = 34;
            // 
            // statusOrder
            // 
            this.statusOrder.FormattingEnabled = true;
            this.statusOrder.Location = new System.Drawing.Point(231, 252);
            this.statusOrder.Margin = new System.Windows.Forms.Padding(4);
            this.statusOrder.Name = "statusOrder";
            this.statusOrder.Size = new System.Drawing.Size(231, 24);
            this.statusOrder.TabIndex = 35;
            // 
            // productOrder
            // 
            this.productOrder.FormattingEnabled = true;
            this.productOrder.Location = new System.Drawing.Point(231, 290);
            this.productOrder.Margin = new System.Windows.Forms.Padding(4);
            this.productOrder.Name = "productOrder";
            this.productOrder.Size = new System.Drawing.Size(231, 24);
            this.productOrder.TabIndex = 37;
            this.productOrder.SelectedIndexChanged += new System.EventHandler(this.productOrder_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(63, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Товар";
            // 
            // TotalAmount
            // 
            this.TotalAmount.BackColor = System.Drawing.SystemColors.Control;
            this.TotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalAmount.Location = new System.Drawing.Point(233, 87);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(231, 30);
            this.TotalAmount.TabIndex = 38;
            // 
            // OrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(520, 470);
            this.Controls.Add(this.TotalAmount);
            this.Controls.Add(this.productOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusOrder);
            this.Controls.Add(this.employeeOrder);
            this.Controls.Add(this.customerOrder);
            this.Controls.Add(this.DateOrder);
            this.Controls.Add(this.EnterOK);
            this.Controls.Add(this.Product_Quantity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderAdd";
            this.Text = "Оформлення замовлення";
            this.Load += new System.EventHandler(this.OrderAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterOK;
        private System.Windows.Forms.TextBox Product_Quantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DateOrder;
        private System.Windows.Forms.ComboBox customerOrder;
        private System.Windows.Forms.ComboBox employeeOrder;
        private System.Windows.Forms.ComboBox statusOrder;
        private System.Windows.Forms.ComboBox productOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TotalAmount;
    }
}