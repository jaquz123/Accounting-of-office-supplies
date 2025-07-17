namespace FINALBD
{
    partial class AdminForm
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
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnDepart = new System.Windows.Forms.Button();
            this.btnWh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(12, 12);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(122, 37);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "Товары";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnVendors
            // 
            this.btnVendors.Location = new System.Drawing.Point(12, 68);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Size = new System.Drawing.Size(122, 37);
            this.btnVendors.TabIndex = 1;
            this.btnVendors.Text = "Поставщики";
            this.btnVendors.UseVisualStyleBackColor = true;
            this.btnVendors.Click += new System.EventHandler(this.btnVendors_Click);
            // 
            // btnDepart
            // 
            this.btnDepart.Location = new System.Drawing.Point(12, 128);
            this.btnDepart.Name = "btnDepart";
            this.btnDepart.Size = new System.Drawing.Size(122, 37);
            this.btnDepart.TabIndex = 2;
            this.btnDepart.Text = "Отделы";
            this.btnDepart.UseVisualStyleBackColor = true;
            this.btnDepart.Click += new System.EventHandler(this.btnDepart_Click);
            // 
            // btnWh
            // 
            this.btnWh.Location = new System.Drawing.Point(12, 195);
            this.btnWh.Name = "btnWh";
            this.btnWh.Size = new System.Drawing.Size(122, 37);
            this.btnWh.TabIndex = 3;
            this.btnWh.Text = "Склад";
            this.btnWh.UseVisualStyleBackColor = true;
            this.btnWh.Click += new System.EventHandler(this.btnWh_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnWh);
            this.Controls.Add(this.btnDepart);
            this.Controls.Add(this.btnVendors);
            this.Controls.Add(this.btnProduct);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnVendors;
        private System.Windows.Forms.Button btnDepart;
        private System.Windows.Forms.Button btnWh;
        private System.Windows.Forms.Button button1;
    }
}