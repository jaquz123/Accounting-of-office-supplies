using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALBD
{
    public partial class Module3OrderDepartament : Form
    {
        MySqlConnection connection = new MySqlConnection(Program.ConnectionString);
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command;
        public static DataTable dt = new DataTable();
        string selectedIdDepartmanet;
        string selectedProduct;
        public Module3OrderDepartament(string valueDepartament)
        {
            InitializeComponent();
            lblSelectedDepartament.Text = valueDepartament;
        }
        private void LoadComboBoxProduct()
        {

            command = new MySqlCommand("SELECT * FROM Товар", connection);
            dt.Clear();
            adapter.SelectCommand = command;
            adapter.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ИмяТовара"; // Изменить имя
            comboBox1.ValueMember = "КодТовара";

        }

        private void Module3OrderDepartament_Load(object sender, EventArgs e)
        {
            LoadComboBoxProduct();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct=comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new MySqlCommand("SELECT КодОтдела FROM Отдел WHERE ИмяОтдела=@DepartmaneName", connection);
            command.Parameters.AddWithValue("@DepartmaneName", lblSelectedDepartament.Text);
            var selectedIdDepartmanet= command.ExecuteScalar();

            command = new MySqlCommand("SELECT КодТовара FROM Товар WHERE ИмяТовара=@ProductName", connection);
            command.Parameters.AddWithValue("@ProductName", selectedProduct);
            var selectedIdProduct = command.ExecuteScalar();

            string insertOrderQuery = "INSERT INTO Заявка (КодОтдела,ДатаЗаказа,Статус) VALUES (@DepartmaneID,@OrderDate,'В обработке')";
            command = new MySqlCommand(insertOrderQuery, connection);
            command.Parameters.AddWithValue("@DepartmaneID", selectedIdDepartmanet);
            command.Parameters.AddWithValue("@OrderDate", DateTime.Now);
            command.ExecuteNonQuery();
            int orderId = Convert.ToInt32(command.LastInsertedId);

            string insertOrderDetails = "INSERT INTO СодержимоеЗаявки (КодЗаявки,КодТовара,ТребуемоеКоличество) VALUES (@IdZaiavka,@IdProduct,@QuantityProduct)";
            command = new MySqlCommand(insertOrderDetails, connection);
            command.Parameters.AddWithValue("@IdZaiavka", orderId);
            command.Parameters.AddWithValue("@IdProduct", selectedIdProduct);
            command.Parameters.AddWithValue("@QuantityProduct", numericUpDown1.Value);
            command.ExecuteNonQuery();
            Module2DepartamentForm module2=new Module2DepartamentForm();
            module2.LoadComboBoxZaiacka();
            connection.Close();
            MessageBox.Show("Вы успешно создали заявку","Успешно",MessageBoxButtons.OK,MessageBoxIcon.Question);


        }

    }
}
