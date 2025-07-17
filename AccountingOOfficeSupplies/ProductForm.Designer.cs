namespace FINALBD
{
    partial class ProductForm
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
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.КодТовара2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ИмяТовара2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShelfLifeProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.КодТовара2,
            this.ИмяТовара2,
            this.ShelfLifeProduct,
            this.Edit,
            this.Delete});
            this.dgvProduct.Location = new System.Drawing.Point(12, 12);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(739, 364);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // КодТовара2
            // 
            this.КодТовара2.DataPropertyName = "КодТовара";
            this.КодТовара2.HeaderText = "КодТовара";
            this.КодТовара2.MinimumWidth = 6;
            this.КодТовара2.Name = "КодТовара2";
            this.КодТовара2.ReadOnly = true;
            this.КодТовара2.Visible = false;
            this.КодТовара2.Width = 125;
            // 
            // ИмяТовара2
            // 
            this.ИмяТовара2.DataPropertyName = "ИмяТовара";
            this.ИмяТовара2.HeaderText = "ИмяТовара";
            this.ИмяТовара2.MinimumWidth = 6;
            this.ИмяТовара2.Name = "ИмяТовара2";
            this.ИмяТовара2.ReadOnly = true;
            this.ИмяТовара2.Width = 125;
            // 
            // ShelfLifeProduct
            // 
            this.ShelfLifeProduct.DataPropertyName = "СрокГодности";
            this.ShelfLifeProduct.HeaderText = "Срок годности продукта";
            this.ShelfLifeProduct.MinimumWidth = 6;
            this.ShelfLifeProduct.Name = "ShelfLifeProduct";
            this.ShelfLifeProduct.ReadOnly = true;
            this.ShelfLifeProduct.Width = 125;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Изменить";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Удалить";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 125;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(262, 439);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(164, 42);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Добавить товар";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.dgvProduct);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn КодТовара2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ИмяТовара2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShelfLifeProduct;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}