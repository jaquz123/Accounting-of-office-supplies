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
    public partial class ModuleVendorsForm : Form
    {
        MySqlConnection con = new MySqlConnection(Program.ConnectionString);
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        VendorsForms vendorsForms = new VendorsForms();
        public ModuleVendorsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("INSERT INTO Поставщик(ИмяПоставщика,Адрес)VALUES(@Name,@ShelfLife)", con);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@ShelfLife", textBox2.Text);
            con.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Введенный поставщик добавлен!");

            cmd = new MySqlCommand("SELECT ИмяПоставщика,Адрес,ИмяТовара,ЦенаЕдТовара FROM Поставщик_Товар " +
                 "INNER JOIN Поставщик ON Поставщик_Товар.КодПоставщика=Поставщик.КодПоставщика " +
                 "INNER JOIN Товар ON Поставщик_Товар.КодТовара=Товар.КодТовара " +
                 "ORDER BY ЦенаЕдТовара", con);
            VendorsForms.dtVendor.Clear();
            vendorsForms.UpdateVendors();
            con.Close();
        }
    }
}
