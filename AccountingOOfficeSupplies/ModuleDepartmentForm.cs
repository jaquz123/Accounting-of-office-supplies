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
    public partial class ModuleDepartmentForm : Form
    {
        MySqlConnection con = new MySqlConnection(Program.ConnectionString);
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DepartamentForm departamentForm = new DepartamentForm();
        public ModuleDepartmentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("INSERT INTO Отдел(ИмяОтдела,Адрес)VALUES(@Name,@Adres)", con);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Adres", textBox2.Text);
            con.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Введенный отдел добавлен!");

            cmd = new MySqlCommand("SELECT * FROM Отдел", con);
            ProductForm.dtProduct.Clear();
            departamentForm.UpdateDepartament();
            con.Close();
        }
    }
}
