
namespace OtelOtomosyonu.forms.customers
{
    partial class frmCustomerDelete
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
            this.label5 = new System.Windows.Forms.Label();
            this.dayOfEntry = new System.Windows.Forms.DateTimePicker();
            this.customerAgetxt = new System.Windows.Forms.TextBox();
            this.customerLastnametxt = new System.Windows.Forms.TextBox();
            this.customerNametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbcustomerRoomtype = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "Giriş Yapılan Tarih";
            // 
            // dayOfEntry
            // 
            this.dayOfEntry.Enabled = false;
            this.dayOfEntry.Location = new System.Drawing.Point(166, 226);
            this.dayOfEntry.Name = "dayOfEntry";
            this.dayOfEntry.Size = new System.Drawing.Size(200, 22);
            this.dayOfEntry.TabIndex = 54;
            // 
            // customerAgetxt
            // 
            this.customerAgetxt.Enabled = false;
            this.customerAgetxt.Location = new System.Drawing.Point(166, 147);
            this.customerAgetxt.Name = "customerAgetxt";
            this.customerAgetxt.Size = new System.Drawing.Size(100, 22);
            this.customerAgetxt.TabIndex = 53;
            // 
            // customerLastnametxt
            // 
            this.customerLastnametxt.Enabled = false;
            this.customerLastnametxt.Location = new System.Drawing.Point(166, 119);
            this.customerLastnametxt.Name = "customerLastnametxt";
            this.customerLastnametxt.Size = new System.Drawing.Size(100, 22);
            this.customerLastnametxt.TabIndex = 52;
            // 
            // customerNametxt
            // 
            this.customerNametxt.Enabled = false;
            this.customerNametxt.Location = new System.Drawing.Point(166, 76);
            this.customerNametxt.Name = "customerNametxt";
            this.customerNametxt.Size = new System.Drawing.Size(100, 22);
            this.customerNametxt.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "İstenilen Oda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Müşteri Yaş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Müşteri Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Müşteri Ad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 43);
            this.button1.TabIndex = 46;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbcustomerRoomtype
            // 
            this.cmbcustomerRoomtype.Enabled = false;
            this.cmbcustomerRoomtype.FormattingEnabled = true;
            this.cmbcustomerRoomtype.Items.AddRange(new object[] {
            "Kat Görevlisi",
            "Resepsyon",
            "Mutfak"});
            this.cmbcustomerRoomtype.Location = new System.Drawing.Point(166, 188);
            this.cmbcustomerRoomtype.Name = "cmbcustomerRoomtype";
            this.cmbcustomerRoomtype.Size = new System.Drawing.Size(121, 24);
            this.cmbcustomerRoomtype.TabIndex = 45;
            // 
            // frmCustomerDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 407);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dayOfEntry);
            this.Controls.Add(this.customerAgetxt);
            this.Controls.Add(this.customerLastnametxt);
            this.Controls.Add(this.customerNametxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbcustomerRoomtype);
            this.Name = "frmCustomerDelete";
            this.Text = "frmCustomerDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dayOfEntry;
        private System.Windows.Forms.TextBox customerAgetxt;
        private System.Windows.Forms.TextBox customerLastnametxt;
        private System.Windows.Forms.TextBox customerNametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbcustomerRoomtype;
    }
}