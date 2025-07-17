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
    public partial class VendorsForms : Form
    {
        MySqlConnection connection = new MySqlConnection(Program.ConnectionString);
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command;
        public static DataTable dtVendor = new DataTable();
        public static DataTable dtVendor2= new DataTable();
        public VendorsForms()
        {
            InitializeComponent();
        }

        private void btnAddVendors_Click(object sender, EventArgs e)
        {
            ModuleVendorsForm moduleVendorsForm = new ModuleVendorsForm();
            moduleVendorsForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string value1 = dgvVendors.CurrentRow.Cells[2].Value.ToString();
                string value2 = dgvVendors.CurrentRow.Cells[3].Value.ToString();
                string value3 = dgvVendors.CurrentRow.Cells[4].Value.ToString();
                string value4 = dgvVendors.CurrentRow.Cells[5].Value.ToString();

                ModuleOrderForm moduleOrderForm = new ModuleOrderForm(value1,value2,value3,value4);
                moduleOrderForm.ShowDialog();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm adminForm = new AdminForm();
           //Autorization autorization = new Autorization();
            adminForm.Show();
        }
        public void UpdateVendors()
        {

            command = new MySqlCommand("SELECT ИмяПоставщика,Адрес,ИмяТовара,ЦенаЕдТовара FROM Поставщик_Товар " +
                "INNER JOIN Поставщик ON Поставщик_Товар.КодПоставщика=Поставщик.КодПоставщика " +
                "INNER JOIN Товар ON Поставщик_Товар.КодТовара=Товар.КодТовара " +
                "ORDER BY ЦенаЕдТовара", connection);
            dtVendor.Clear();
            adapter.SelectCommand = command;
            adapter.Fill(dtVendor);
            dgvVendors.DataSource = dtVendor;
            command = new MySqlCommand("SELECT * FROM Поставщик",connection);
            dtVendor2.Clear();
            adapter.SelectCommand = command;
            adapter.Fill(dtVendor2);
            dataGridView1.DataSource = dtVendor2;
        }

        private void VendorsForms_Load(object sender, EventArgs e)
        {
            connection.Open();
            UpdateVendors();
            connection.Close();
        }
    }
}
