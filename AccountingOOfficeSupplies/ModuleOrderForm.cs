using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALBD
{
    public partial class ModuleOrderForm : Form
    {
        MySqlConnection connection = new MySqlConnection(Program.ConnectionString);
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command;
        public static DataTable dt = new DataTable();
        string selectedId;
        string selectedPrice;
        public ModuleOrderForm(string value1,string value2,string value3,string value4)
        {
            InitializeComponent();
            //Ид

            textBox3.Text = value1;//Поставщик
            textBox1.Text = value3;//Товар
            selectedPrice = value4;
            textBox2.Text = value4;//Цена
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new MySqlCommand(
             "SELECT КодПоставщика FROM Поставщик WHERE ИмяПоставщика = @vendorName",
            connection);
            command.Parameters.AddWithValue("@vendorName", textBox3.Text);
            var idVendor = command.ExecuteScalar();
            command = new MySqlCommand("SELECT КодТовара FROM Товар WHERE ИмяТовара=@productName", connection);
            command.Parameters.AddWithValue("@productName", textBox1.Text);
            var idProduct = command.ExecuteScalar();
            // 1) Сначала вставляем сам заказ
            string insertOrderQuery = "INSERT INTO Заказ (КодПоставщика,ДатаЗаказа,Статус) VALUES (@VendorID,@OrderDate,'В обработке')";
            command = new MySqlCommand(insertOrderQuery, connection);
            command.Parameters.AddWithValue("@VendorID", idVendor);
            command.Parameters.AddWithValue("@OrderDate", DateTime.Now);
            command.ExecuteNonQuery();
            int orderId = Convert.ToInt32(command.LastInsertedId);

            // 2) Узнаём ид в таблице Поставщик_Товар
            // Предположим, selectedVendorId вы взяли ранее (например, из ComboBox):
            int vendorProductId;
            using (var cmd2 = new MySqlCommand(
                 "SELECT КодПоставщикаТовар FROM Поставщик_Товар " +
                 "WHERE КодТовара = @ProductID AND КодПоставщика = @VendorID", connection))
            {
                cmd2.Parameters.AddWithValue("@ProductID", idProduct);
                cmd2.Parameters.AddWithValue("@VendorID", idVendor);
                var result = cmd2.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Позиция «товар–поставщик» не найдена!",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    return;
                }
                vendorProductId = Convert.ToInt32(result);
            }

            // 3) Теперь вставляем детали заказа
            string insertDetailQuery = @"
         INSERT INTO ДеталиЗаказа
            (КодЗаказа,КодПоставщикаТовар,КоличествоТовара)
         VALUES
            (@OrderID,@VendorProductID,@Quantity)";
            using (var cmd3 = new MySqlCommand(insertDetailQuery, connection))
            {
                cmd3.Parameters.AddWithValue("@OrderID", orderId);
                cmd3.Parameters.AddWithValue("@VendorProductID", vendorProductId);
                cmd3.Parameters.AddWithValue("@Quantity", (int)numericUpDown1.Value);

                // Нормализуем строку цены
                string normalizedInput = selectedPrice.Replace(',', '.');
                decimal unitPrice = decimal.Parse(normalizedInput, CultureInfo.InvariantCulture);
                cmd3.Parameters.AddWithValue("@UnitPrice", unitPrice);

                cmd3.ExecuteNonQuery();
            }
            connection.Close();
            MessageBox.Show("Заказ успешно создан и сохранён в деталях!",
                            "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
