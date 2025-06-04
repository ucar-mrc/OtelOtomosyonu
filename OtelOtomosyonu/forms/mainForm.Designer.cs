
namespace OtelOtomosyonu.forms
{
    partial class mainForm
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
            this.btnemployee = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnemployee
            // 
            this.btnemployee.Location = new System.Drawing.Point(175, 178);
            this.btnemployee.Name = "btnemployee";
            this.btnemployee.Size = new System.Drawing.Size(126, 63);
            this.btnemployee.TabIndex = 0;
            this.btnemployee.Text = "Çalışan";
            this.btnemployee.UseVisualStyleBackColor = true;
            this.btnemployee.Click += new System.EventHandler(this.btnemployee_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.Location = new System.Drawing.Point(446, 178);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(126, 63);
            this.btncustomer.TabIndex = 1;
            this.btncustomer.Text = "Müşteri";
            this.btncustomer.UseVisualStyleBackColor = true;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncustomer);
            this.Controls.Add(this.btnemployee);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnemployee;
        private System.Windows.Forms.Button btncustomer;
    }
}