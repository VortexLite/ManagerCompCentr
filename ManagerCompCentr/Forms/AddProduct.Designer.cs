namespace ManagerCompCentr.Forms
{
    partial class AddProduct
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
            this.descriptionProduct = new System.Windows.Forms.TextBox();
            this.priceProduct = new System.Windows.Forms.TextBox();
            this.nameProduct = new System.Windows.Forms.TextBox();
            this.EnterOK = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.supplierIDProduct = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // descriptionProduct
            // 
            this.descriptionProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionProduct.Location = new System.Drawing.Point(232, 87);
            this.descriptionProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionProduct.Name = "descriptionProduct";
            this.descriptionProduct.Size = new System.Drawing.Size(231, 26);
            this.descriptionProduct.TabIndex = 75;
            // 
            // priceProduct
            // 
            this.priceProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceProduct.Location = new System.Drawing.Point(232, 133);
            this.priceProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.Size = new System.Drawing.Size(231, 26);
            this.priceProduct.TabIndex = 74;
            // 
            // nameProduct
            // 
            this.nameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameProduct.Location = new System.Drawing.Point(232, 50);
            this.nameProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(231, 26);
            this.nameProduct.TabIndex = 73;
            // 
            // EnterOK
            // 
            this.EnterOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterOK.Location = new System.Drawing.Point(67, 233);
            this.EnterOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterOK.Name = "EnterOK";
            this.EnterOK.Size = new System.Drawing.Size(395, 43);
            this.EnterOK.TabIndex = 72;
            this.EnterOK.Text = "Додати";
            this.EnterOK.UseVisualStyleBackColor = true;
            this.EnterOK.Click += new System.EventHandler(this.EnterOK_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(63, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 70;
            this.label7.Text = "Назва";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(63, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 69;
            this.label6.Text = "Поставщик";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(63, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "Ціна";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(63, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 67;
            this.label4.Text = "Опис";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SlateBlue;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(0, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(523, 30);
            this.label2.TabIndex = 66;
            this.label2.Text = "Додати товар";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(36, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 300);
            this.label1.TabIndex = 65;
            // 
            // supplierIDProduct
            // 
            this.supplierIDProduct.FormattingEnabled = true;
            this.supplierIDProduct.Location = new System.Drawing.Point(232, 178);
            this.supplierIDProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.supplierIDProduct.Name = "supplierIDProduct";
            this.supplierIDProduct.Size = new System.Drawing.Size(228, 24);
            this.supplierIDProduct.TabIndex = 76;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(521, 354);
            this.Controls.Add(this.supplierIDProduct);
            this.Controls.Add(this.descriptionProduct);
            this.Controls.Add(this.priceProduct);
            this.Controls.Add(this.nameProduct);
            this.Controls.Add(this.EnterOK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddProduct";
            this.Text = "Додати товар";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox descriptionProduct;
        private System.Windows.Forms.TextBox priceProduct;
        private System.Windows.Forms.TextBox nameProduct;
        private System.Windows.Forms.Button EnterOK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox supplierIDProduct;
    }
}