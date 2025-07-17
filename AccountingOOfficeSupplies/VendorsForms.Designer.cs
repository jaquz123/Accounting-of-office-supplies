namespace FINALBD
{
    partial class VendorsForms
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
            this.btnAddVendors = new System.Windows.Forms.Button();
            this.dgvVendors = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameVendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdressVendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ИмяТовара = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.КодПоставщика2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ИмяПоставщика = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.АдресПоставщика = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddVendors
            // 
            this.btnAddVendors.Location = new System.Drawing.Point(916, 398);
            this.btnAddVendors.Name = "btnAddVendors";
            this.btnAddVendors.Size = new System.Drawing.Size(164, 42);
            this.btnAddVendors.TabIndex = 4;
            this.btnAddVendors.Text = "Добавить поставщика";
            this.btnAddVendors.UseVisualStyleBackColor = true;
            this.btnAddVendors.Click += new System.EventHandler(this.btnAddVendors_Click);
            // 
            // dgvVendors
            // 
            this.dgvVendors.AllowUserToAddRows = false;
            this.dgvVendors.AllowUserToDeleteRows = false;
            this.dgvVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameVendor,
            this.AdressVendor,
            this.ИмяТовара,
            this.PriceProduct,
            this.Edit,
            this.Delete});
            this.dgvVendors.Location = new System.Drawing.Point(23, 12);
            this.dgvVendors.Name = "dgvVendors";
            this.dgvVendors.ReadOnly = true;
            this.dgvVendors.RowHeadersWidth = 51;
            this.dgvVendors.RowTemplate.Height = 24;
            this.dgvVendors.Size = new System.Drawing.Size(851, 364);
            this.dgvVendors.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1287, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "Заказать выбранный товар";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.КодПоставщика2,
            this.ИмяПоставщика,
            this.АдресПоставщика});
            this.dataGridView1.Location = new System.Drawing.Point(916, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(382, 364);
            this.dataGridView1.TabIndex = 7;
            // 
            // NameVendor
            // 
            this.NameVendor.DataPropertyName = "ИмяПоставщика";
            this.NameVendor.HeaderText = "Имя поставщика";
            this.NameVendor.MinimumWidth = 6;
            this.NameVendor.Name = "NameVendor";
            this.NameVendor.ReadOnly = true;
            this.NameVendor.Width = 125;
            // 
            // AdressVendor
            // 
            this.AdressVendor.DataPropertyName = "Адрес";
            this.AdressVendor.HeaderText = "Адрес";
            this.AdressVendor.MinimumWidth = 6;
            this.AdressVendor.Name = "AdressVendor";
            this.AdressVendor.ReadOnly = true;
            this.AdressVendor.Width = 125;
            // 
            // ИмяТовара
            // 
            this.ИмяТовара.DataPropertyName = "ИмяТовара";
            this.ИмяТовара.HeaderText = "ИмяТовара";
            this.ИмяТовара.MinimumWidth = 6;
            this.ИмяТовара.Name = "ИмяТовара";
            this.ИмяТовара.ReadOnly = true;
            this.ИмяТовара.Width = 125;
            // 
            // PriceProduct
            // 
            this.PriceProduct.DataPropertyName = "ЦенаЕдТовара";
            this.PriceProduct.HeaderText = "Цена товара";
            this.PriceProduct.MinimumWidth = 6;
            this.PriceProduct.Name = "PriceProduct";
            this.PriceProduct.ReadOnly = true;
            this.PriceProduct.Width = 125;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Изменить";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Visible = false;
            this.Edit.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Удалить";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Visible = false;
            this.Delete.Width = 125;
            // 
            // КодПоставщика2
            // 
            this.КодПоставщика2.DataPropertyName = "КодПоставщика";
            this.КодПоставщика2.HeaderText = "КодПоставщика";
            this.КодПоставщика2.MinimumWidth = 6;
            this.КодПоставщика2.Name = "КодПоставщика2";
            this.КодПоставщика2.ReadOnly = true;
            this.КодПоставщика2.Visible = false;
            this.КодПоставщика2.Width = 125;
            // 
            // ИмяПоставщика
            // 
            this.ИмяПоставщика.DataPropertyName = "ИмяПоставщика";
            this.ИмяПоставщика.HeaderText = "Имя поставщика";
            this.ИмяПоставщика.MinimumWidth = 6;
            this.ИмяПоставщика.Name = "ИмяПоставщика";
            this.ИмяПоставщика.ReadOnly = true;
            this.ИмяПоставщика.Width = 125;
            // 
            // АдресПоставщика
            // 
            this.АдресПоставщика.DataPropertyName = "Адрес";
            this.АдресПоставщика.HeaderText = "Адрес поставщика";
            this.АдресПоставщика.MinimumWidth = 6;
            this.АдресПоставщика.Name = "АдресПоставщика";
            this.АдресПоставщика.ReadOnly = true;
            this.АдресПоставщика.Width = 125;
            // 
            // VendorsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 485);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddVendors);
            this.Controls.Add(this.dgvVendors);
            this.Controls.Add(this.button1);
            this.Name = "VendorsForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VendorsForms";
            this.Load += new System.EventHandler(this.VendorsForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddVendors;
        private System.Windows.Forms.DataGridView dgvVendors;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameVendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdressVendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ИмяТовара;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceProduct;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn КодПоставщика2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ИмяПоставщика;
        private System.Windows.Forms.DataGridViewTextBoxColumn АдресПоставщика;
    }
}