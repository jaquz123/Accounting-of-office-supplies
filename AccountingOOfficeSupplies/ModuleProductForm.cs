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
    public partial class ModuleProductForm : Form
    {
        MySqlConnection con = new MySqlConnection(Program.ConnectionString);
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        ProductForm productForm = new ProductForm();
        public ModuleProductForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("INSERT INTO Товар(ИмяТовара,СрокГодности)VALUES(@Name,@ShelfLife)", con);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@ShelfLife", textBox2.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Введенный продукт добавлен!");

            cmd = new MySqlCommand("SELECT * FROM Товар", con);
            ProductForm.dtProduct.Clear();
            productForm.UpdateProduct();
            con.Close();

        }
    }
}
