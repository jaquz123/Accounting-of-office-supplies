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
    public partial class Module2AddPriceAndProductVendorsForm : Form
    {
        MySqlConnection connection = new MySqlConnection("server=MySql-8.2;username=root;password=;database=VavilovBD");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command;
        static public DataTable dtStorageLocation = new DataTable();
        string selectedProduct;
        ModuleVendorsForm moduleVendors;
        string selectedVendor;
        VendorsForms vendors;
        public Module2AddPriceAndProductVendorsForm(string value1,string value2)
        {
            InitializeComponent();
            lblVendor.Text = value1;
            lblVendorAdress.Text = value2;
        }
        private void LoadComboBoxProduct()
        {
            command = new MySqlCommand("SELECT * FROM Товар", connection);
            dtStorageLocation.Clear();
            adapter.SelectCommand = command;
            adapter.Fill(dtStorageLocation);

            comboBox1.DataSource = dtStorageLocation;
            comboBox1.DisplayMember = "ИмяТовара"; // Изменить имя
            comboBox1.ValueMember = "КодТовара";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct=comboBox1.SelectedIndex.ToString();
        }

        private void Module2AddPriceAndProductVendorsForm_Load(object sender, EventArgs e)
        {
            lblVendor.Text = moduleVendors.textBox1.ToString();
            lblVendorAdress.Text= moduleVendors.textBox2.ToString();
            LoadComboBoxProduct();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand($"SELECT КодПоставщика FROM Поставщик \r\nWHERE ИмяПоставщика="+lblVendor.Text+"");
            object idVendor = command.ExecuteScalar();
            command = new MySqlCommand("INSERT INTO Поставщик_Товар VALUE(@КодПоставщика,@КодТовара,@ЦенаЕдТовара)", connection);
            connection.Open();
            //command =new MySqlCommand(query, connection);
            // command.Parameters.AddWithValue("@DepartmentName", "%" + selectedDepartment + "%");

            
            command.Parameters.AddWithValue("@КодПоставщика", idVendor);
            command.Parameters.AddWithValue("@КодТовара", selectedProduct);
            command.Parameters.AddWithValue("@КодТовара", txtBoxPrice.Text);
            MessageBox.Show("Введенный поставщик с его заданной ценой добавлен!");

            command = new MySqlCommand("SELECT ИмяПоставщика,Адрес,ИмяТовара,ЦенаЕдТовара FROM Поставщик_Товар " +
               "INNER JOIN Поставщик ON Поставщик_Товар.КодПоставщика=Поставщик.КодПоставщика" +
               "INNER JOIN Товар ON Поставщик_Товар.КодТовара=Товар.КодТовара " +
               "ORDER BY ЦенаЕдТовара", connection);
            VendorsForms.dtVendor.Clear();
            vendors.UpdateVendors();
            connection.Close();
        }
    }
}
