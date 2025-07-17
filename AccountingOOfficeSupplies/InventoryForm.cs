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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FINALBD
{
    public partial class InventoryForm : Form
    {
        MySqlConnection connection = new MySqlConnection(Program.ConnectionString);
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command;
        public static DataTable dtInventory = new DataTable();
        public static DataTable dtOrder = new DataTable();
        string selectedOrder;
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm adminForm = new AdminForm();
            //Autorization autorization = new Autorization();
            adminForm.Show();
        }
        private void LoadComboBoxOrder()
        {
            command = new MySqlCommand("SELECT * FROM Заказ", connection);
            dtOrder.Clear();
            adapter.SelectCommand = command;
            adapter.Fill(dtOrder);

            comboBox1.DataSource = dtOrder;
            comboBox1.DisplayMember = "КодЗаказа"; // Изменить имя
            comboBox1.ValueMember = "КодЗаказа";

        }
        public void UpdateVendors()
        {
            command = new MySqlCommand("SELECT ИмяТовара,КоличествоТовара FROM ОстаткиНаСкладе " +
                "INNER JOIN Товар ON ОстаткиНаСкладе.КодТовара=Товар.КодТовара", connection);
            dtInventory.Clear();
            adapter.SelectCommand = command;
            adapter.Fill(dtInventory);
            dataGridView1.DataSource = dtInventory;
        }
        private void InventoryForm_Load(object sender, EventArgs e)
        {
            UpdateVendors();
            LoadComboBoxOrder();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOrder = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            string insertOrderQQuery = "UPDATE Заказ SET Статус='Успешно' WHERE КодЗаказа=@IDOrder";
            command = new MySqlCommand(insertOrderQQuery, connection);
            command.Parameters.AddWithValue("@IDOrder", selectedOrder);
            command.ExecuteNonQuery();
            UpdateVendors();
            connection.Close();
            MessageBox.Show("Заказ успешно подтверждена на статус 'Успешно'", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
