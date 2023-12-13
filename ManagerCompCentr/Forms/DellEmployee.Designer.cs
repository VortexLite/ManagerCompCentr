namespace ManagerCompCentr.Forms
{
    partial class DellEmployee
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
            this.dellEmployeee = new System.Windows.Forms.ComboBox();
            this.EnterOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dellEmployeee
            // 
            this.dellEmployeee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dellEmployeee.FormattingEnabled = true;
            this.dellEmployeee.Location = new System.Drawing.Point(76, 49);
            this.dellEmployeee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dellEmployeee.Name = "dellEmployeee";
            this.dellEmployeee.Size = new System.Drawing.Size(371, 28);
            this.dellEmployeee.TabIndex = 40;
            // 
            // EnterOK
            // 
            this.EnterOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterOK.Location = new System.Drawing.Point(76, 103);
            this.EnterOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterOK.Name = "EnterOK";
            this.EnterOK.Size = new System.Drawing.Size(371, 43);
            this.EnterOK.TabIndex = 39;
            this.EnterOK.Text = "Звільнення";
            this.EnterOK.UseVisualStyleBackColor = true;
            this.EnterOK.Click += new System.EventHandler(this.EnterOK_Click);
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
            this.label2.TabIndex = 38;
            this.label2.Text = "Звільнення працівника";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(36, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 174);
            this.label1.TabIndex = 37;
            // 
            // DellEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(520, 217);
            this.Controls.Add(this.dellEmployeee);
            this.Controls.Add(this.EnterOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DellEmployee";
            this.Text = "Звільнити працівника";
            this.Load += new System.EventHandler(this.DellEmployee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox dellEmployeee;
        private System.Windows.Forms.Button EnterOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}