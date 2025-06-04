
namespace OtelOtomosyonu.forms.employees
{
    partial class frmDelete
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
            this.employeeSectiontxt = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.employeAgetxt = new System.Windows.Forms.TextBox();
            this.employeeLastnametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeNametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeSectiontxt
            // 
            this.employeeSectiontxt.Enabled = false;
            this.employeeSectiontxt.Location = new System.Drawing.Point(146, 169);
            this.employeeSectiontxt.Name = "employeeSectiontxt";
            this.employeeSectiontxt.Size = new System.Drawing.Size(100, 22);
            this.employeeSectiontxt.TabIndex = 28;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(146, 228);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(121, 43);
            this.btnsil.TabIndex = 27;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Çalıştığı Bölüm";
            // 
            // employeAgetxt
            // 
            this.employeAgetxt.Enabled = false;
            this.employeAgetxt.Location = new System.Drawing.Point(146, 126);
            this.employeAgetxt.Name = "employeAgetxt";
            this.employeAgetxt.Size = new System.Drawing.Size(100, 22);
            this.employeAgetxt.TabIndex = 25;
            // 
            // employeeLastnametxt
            // 
            this.employeeLastnametxt.Enabled = false;
            this.employeeLastnametxt.Location = new System.Drawing.Point(146, 98);
            this.employeeLastnametxt.Name = "employeeLastnametxt";
            this.employeeLastnametxt.Size = new System.Drawing.Size(100, 22);
            this.employeeLastnametxt.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Çalışan Yaş";
            // 
            // employeeNametxt
            // 
            this.employeeNametxt.Enabled = false;
            this.employeeNametxt.Location = new System.Drawing.Point(146, 55);
            this.employeeNametxt.Name = "employeeNametxt";
            this.employeeNametxt.Size = new System.Drawing.Size(100, 22);
            this.employeeNametxt.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Çalışan Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Çalışan Ad";
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 326);
            this.Controls.Add(this.employeeSectiontxt);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.employeAgetxt);
            this.Controls.Add(this.employeeLastnametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.employeeNametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDelete";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox employeeSectiontxt;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox employeAgetxt;
        private System.Windows.Forms.TextBox employeeLastnametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox employeeNametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}