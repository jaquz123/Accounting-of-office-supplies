namespace FINALBD
{
    partial class DepartamentForm
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.КодОтдела = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDepartament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdressDepartament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(21, 381);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(164, 42);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Добавить отдел";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.КодОтдела,
            this.NameDepartament,
            this.AdressDepartament,
            this.Edit,
            this.Delete});
            this.dgvProduct.Location = new System.Drawing.Point(21, 2);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(739, 364);
            this.dgvProduct.TabIndex = 3;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // КодОтдела
            // 
            this.КодОтдела.DataPropertyName = "КодОтдела";
            this.КодОтдела.HeaderText = "КодОтдела";
            this.КодОтдела.MinimumWidth = 6;
            this.КодОтдела.Name = "КодОтдела";
            this.КодОтдела.ReadOnly = true;
            this.КодОтдела.Visible = false;
            this.КодОтдела.Width = 125;
            // 
            // NameDepartament
            // 
            this.NameDepartament.DataPropertyName = "ИмяОтдела";
            this.NameDepartament.HeaderText = "Имя отдела";
            this.NameDepartament.MinimumWidth = 6;
            this.NameDepartament.Name = "NameDepartament";
            this.NameDepartament.ReadOnly = true;
            this.NameDepartament.Width = 125;
            // 
            // AdressDepartament
            // 
            this.AdressDepartament.DataPropertyName = "Адрес";
            this.AdressDepartament.HeaderText = "Адрес отдела";
            this.AdressDepartament.MinimumWidth = 6;
            this.AdressDepartament.Name = "AdressDepartament";
            this.AdressDepartament.ReadOnly = true;
            this.AdressDepartament.Width = 125;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "Посмотреть остатки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DepartamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.button1);
            this.Name = "DepartamentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartamentForm";
            this.Load += new System.EventHandler(this.DepartamentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn КодОтдела;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDepartament;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdressDepartament;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}