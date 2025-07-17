using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class Module2DepartamentForm : Form
    {
        MySqlConnection connection = new MySqlConnection(Program.ConnectionString);
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command;
        public static DataTable dtDepartament = new DataTable();
        public static DataTable dtZaiazka = new DataTable();
        public static DataTable dtComboBox = new DataTable();
        DepartamentForm departamentForm = new DepartamentForm();
        string selectedDepartament;
        string selectedZaiavka;
        public Module2DepartamentForm()
        {
            InitializeComponent();
        }

        private void LoadComboBoxDepartments()
        {
            command = new MySqlCommand("SELECT * FROM Отдел", connection);
            dtComboBox.Clear();
            adapter.SelectCommand = command;
            adapter.Fill(dtComboBox);
            //comboBox1.DataSource = DepartamentForm.dtDepartament2;
            comboBox1.DataSource = dtComboBox;
            comboBox1.DisplayMember = "ИмяОтдела"; // Изменить имя
            comboBox1.ValueMember = "КодОтдела";

        }
        public void LoadComboBoxZaiacka()
        {
            command = new MySqlCommand("SELECT * FROM Заявка", connection);
            dtZaiazka.Clear();
            adapter.SelectCommand = command;
            adapter.Fill(dtZaiazka);

            comboBox2.DataSource = dtZaiazka;
            comboBox2.DisplayMember = "КодЗаявки"; // Изменить имя
            comboBox2.ValueMember = "КодЗаявки";

        }

        private void Module2DepartamentForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxDepartments();
            //UpdateDepartament();
            LoadComboBoxZaiacka();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDepartament = comboBox1.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Module3OrderDepartament module3OrderDepartament = new Module3OrderDepartament(selectedDepartament);
            module3OrderDepartament.ShowDialog();
        }
        void UpdateDepartament()
        {
            command = new MySqlCommand("SELECT ИмяОтдела,ИмяТовара,ТекущееКоличество FROM Отдел_Товар " +
                "INNER JOIN Отдел ON Отдел_Товар.КодОтдела=Отдел.КодОтдела " +
                "INNER JOIN Товар ON Отдел_Товар.КодТовара=Товар.КодТовара WHERE ИмяОтдела=@DepartmentName", connection);
            command.Parameters.AddWithValue("@DepartmentName", selectedDepartament);
            dtDepartament.Clear();
            adapter.SelectCommand = command;
            adapter.Fill(dtDepartament);
            dataGridView1.DataSource = dtDepartament;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDepartament();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedZaiavka = comboBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            string insertOrderQQuery = "UPDATE Заявка SET Статус='Успешно' WHERE КодЗаявки=@IDZaiazka";
            command = new MySqlCommand(insertOrderQQuery, connection);
            command.Parameters.AddWithValue("@IDZaiazka", selectedZaiavka);
            command.ExecuteNonQuery();
            UpdateDepartament();
            MessageBox.Show("Заявка успешно подтверждена на статус 'Успешно'","Успешно",MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm adminForm = new AdminForm();
           //Autorization autorization = new Autorization();
            adminForm.Show();
        }
    }
}
