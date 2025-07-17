using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALBD
{
    public partial class ProductForm : Form
    {
        MySqlConnection connection = new MySqlConnection(Program.ConnectionString);
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command;
        public static DataTable dtProduct = new DataTable();
        public ProductForm()
        {
            InitializeComponent();
        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ModuleProductForm productForm = new ModuleProductForm();
            productForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }
        public void UpdateProduct()
        {
            command = new MySqlCommand("SELECT * FROM Товар", connection);
            dtProduct.Clear();
            adapter.SelectCommand = command;
            adapter.Fill(dtProduct);
            dgvProduct.DataSource = dtProduct;
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            connection.Open();
            UpdateProduct();
            connection.Close();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                EditProductForm editModuleProduct = new EditProductForm();
                editModuleProduct.lblId.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                editModuleProduct.textBox1.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                editModuleProduct.textBox2.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                editModuleProduct.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Вы точно хотите удалить данный товар?", "Удаление товара", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("DELETE FROM Товар WHERE КодТовара LIKE '" + dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    ProductForm departamentForm = new ProductForm();
                    departamentForm.UpdateProduct();
                    MessageBox.Show("Успешно удалено!");
                }
            }
        }
    }
}
