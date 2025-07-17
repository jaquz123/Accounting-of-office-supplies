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
    public partial class LoginForm : Form
    {
        //"server=MySql-8.2;username=root;password=;database=AccounitgProduct";
        MySqlConnection conn;
        MySqlCommand cmd;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        public bool Autorization(string username, string password)
        {
            try
            {
                string connectionString = $"server=MySql-8.2;username={username};password={password};database=AccounitgProduct;";
                conn = new MySqlConnection(connectionString);
                conn.Open();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }
        public void button1_Click(object sender, EventArgs e)
        {
            if(Autorization(textBox1.Text, textBox2.Text))
            {
                
                string login = textBox1.Text;
                string password = textBox2.Text;
                string query = "SELECT Роль FROM Пользователи WHERE Логин=@Login and Пароль=@Password";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Login", login);
                cmd.Parameters.AddWithValue("@Password", password);
                object role = cmd.ExecuteScalar();
                conn.Close();
                if (role != null)
                {
                    switch (role.ToString())
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
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует или неправильный пароль");
            }
            

        }
    }
}
