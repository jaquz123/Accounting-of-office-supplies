using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALBD
{
    public partial class EditProductForm : Form
    {
        MySqlConnection connection = new MySqlConnection(Program.ConnectionString);
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command;
        public EditProductForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand("UPDATE Товар SET ИмяТовара=@Name,СрокГодности=@ShelfLife WHERE КодТовара LIKE '" + lblId.Text + "'", connection);

            command.Parameters.AddWithValue("@Name", textBox1.Text);
            command.Parameters.AddWithValue("@ShelfLife", textBox2.Text);
            // cm.Parameters.AddWithValue("@CategoryID", textBoxCategorieProduct.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            ProductForm departamentForm = new ProductForm();
            departamentForm.UpdateProduct();
            MessageBox.Show("Введеные данные изменены!");
        }
    }
}
