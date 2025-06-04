
namespace OtelOtomosyonu.forms.employees
{
    partial class frmUpdate
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
            this.btnguncelle = new System.Windows.Forms.Button();
            this.employeAgetxt = new System.Windows.Forms.TextBox();
            this.employeeLastnametxt = new System.Windows.Forms.TextBox();
            this.employeeNametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbemployeeSection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(164, 256);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(121, 43);
            this.btnguncelle.TabIndex = 36;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // employeAgetxt
            // 
            this.employeAgetxt.Location = new System.Drawing.Point(164, 149);
            this.employeAgetxt.Name = "employeAgetxt";
            this.employeAgetxt.Size = new System.Drawing.Size(100, 22);
            this.employeAgetxt.TabIndex = 44;
            // 
            // employeeLastnametxt
            // 
            this.employeeLastnametxt.Location = new System.Drawing.Point(164, 121);
            this.employeeLastnametxt.Name = "employeeLastnametxt";
            this.employeeLastnametxt.Size = new System.Drawing.Size(100, 22);
            this.employeeLastnametxt.TabIndex = 43;
            // 
            // employeeNametxt
            // 
            this.employeeNametxt.Location = new System.Drawing.Point(164, 78);
            this.employeeNametxt.Name = "employeeNametxt";
            this.employeeNametxt.Size = new System.Drawing.Size(100, 22);
            this.employeeNametxt.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Çalıştığı Bölüm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Çalışan Yaş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Çalışan Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Çalışan Ad";
            // 
            // cmbemployeeSection
            // 
            this.cmbemployeeSection.FormattingEnabled = true;
            this.cmbemployeeSection.Items.AddRange(new object[] {
            "Kat Görevlisi",
            "Resepsyon",
            "Mutfak"});
            this.cmbemployeeSection.Location = new System.Drawing.Point(164, 190);
            this.cmbemployeeSection.Name = "cmbemployeeSection";
            this.cmbemployeeSection.Size = new System.Drawing.Size(121, 24);
            this.cmbemployeeSection.TabIndex = 37;
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 382);
            this.Controls.Add(this.employeAgetxt);
            this.Controls.Add(this.employeeLastnametxt);
            this.Controls.Add(this.employeeNametxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbemployeeSection);
            this.Controls.Add(this.btnguncelle);
            this.Name = "frmUpdate";
            this.Text = "frmUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.TextBox employeAgetxt;
        private System.Windows.Forms.TextBox employeeLastnametxt;
        private System.Windows.Forms.TextBox employeeNametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbemployeeSection;
    }
}