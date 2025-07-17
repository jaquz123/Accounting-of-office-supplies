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
    public partial class Autorization : Form
    {
        MySqlConnection connection = new MySqlConnection(Program.ConnectionString);
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command;
        public Autorization()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login=textBox1.Text;
            string password=textBox2.Text;
            connection.Open();
            string query = "SELECT Роль FROM Пользователи WHERE Логин=@Login and Пароль=@Password";
            command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Login", login);
            command.Parameters.AddWithValue("@Password", password);
            object role=command.ExecuteScalar();
            connection.Close();
            if (role != null)
            {
                switch(role.ToString())
                {
                    case "Админ":
                        new AdminForm().Show();
                        break;
                    case "МенеджерПоЗакупкам":
                        new VendorsForms().Show();
                        break;
                    case "СотрудникСклада":
                        new InventoryForm().Show();
                        break;
                    case "РуководительОтдела":
                        new Module2DepartamentForm().Show();
                        break;
                    case "Бухгалтер":
                        new AdminForm().Show();
                        break;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
