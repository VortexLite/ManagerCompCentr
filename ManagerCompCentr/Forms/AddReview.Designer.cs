namespace ManagerCompCentr.Forms
{
    partial class AddReview
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
            this.TextReview = new System.Windows.Forms.TextBox();
            this.EnterOK = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateReview = new System.Windows.Forms.Label();
            this.productIDReview = new System.Windows.Forms.ComboBox();
            this.customerIDReview = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TextReview
            // 
            this.TextReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextReview.Location = new System.Drawing.Point(229, 48);
            this.TextReview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextReview.Name = "TextReview";
            this.TextReview.Size = new System.Drawing.Size(231, 26);
            this.TextReview.TabIndex = 73;
            // 
            // EnterOK
            // 
            this.EnterOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterOK.Location = new System.Drawing.Point(64, 235);
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
            this.label7.Location = new System.Drawing.Point(60, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 70;
            this.label7.Text = "Відгук";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(60, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 69;
            this.label6.Text = "Клієнт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(60, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "Товар";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(60, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 67;
            this.label4.Text = "Дата";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SlateBlue;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(-3, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(523, 30);
            this.label2.TabIndex = 66;
            this.label2.Text = "Додати відгук";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(33, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 304);
            this.label1.TabIndex = 65;
            // 
            // dateReview
            // 
            this.dateReview.BackColor = System.Drawing.SystemColors.Control;
            this.dateReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateReview.Location = new System.Drawing.Point(225, 89);
            this.dateReview.Name = "dateReview";
            this.dateReview.Size = new System.Drawing.Size(236, 21);
            this.dateReview.TabIndex = 74;
            // 
            // productIDReview
            // 
            this.productIDReview.FormattingEnabled = true;
            this.productIDReview.Location = new System.Drawing.Point(229, 134);
            this.productIDReview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productIDReview.Name = "productIDReview";
            this.productIDReview.Size = new System.Drawing.Size(228, 24);
            this.productIDReview.TabIndex = 75;
            // 
            // customerIDReview
            // 
            this.customerIDReview.FormattingEnabled = true;
            this.customerIDReview.Location = new System.Drawing.Point(229, 176);
            this.customerIDReview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerIDReview.Name = "customerIDReview";
            this.customerIDReview.Size = new System.Drawing.Size(228, 24);
            this.customerIDReview.TabIndex = 76;
            // 
            // AddReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(517, 346);
            this.Controls.Add(this.customerIDReview);
            this.Controls.Add(this.productIDReview);
            this.Controls.Add(this.dateReview);
            this.Controls.Add(this.TextReview);
            this.Controls.Add(this.EnterOK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddReview";
            this.Text = "Додати відгук";
            this.Load += new System.EventHandler(this.AddReview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextReview;
        private System.Windows.Forms.Button EnterOK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateReview;
        private System.Windows.Forms.ComboBox productIDReview;
        private System.Windows.Forms.ComboBox customerIDReview;
    }
}