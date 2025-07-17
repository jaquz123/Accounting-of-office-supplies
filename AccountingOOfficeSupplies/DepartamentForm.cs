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
    public partial class DepartamentForm : Form
    {
        MySqlConnection connection = new MySqlConnection(Program.ConnectionString);
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command;
        public static DataTable dtDepartament2 = new DataTable();
        public DepartamentForm()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ModuleDepartmentForm moduleDepartmentForm = new ModuleDepartmentForm();
            moduleDepartmentForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Module2DepartamentForm module2Departament = new Module2DepartamentForm();
            module2Departament.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm adminForm = new AdminForm();
            //Autorization autorization = new Autorization();
            adminForm.Show();
        }
        public void UpdateDepartament()
        {
            command = new MySqlCommand("SELECT * FROM Отдел", connection);
            dtDepartament2.Clear();
            adapter.SelectCommand = command;
            adapter.Fill(dtDepartament2);
            dgvProduct.DataSource = dtDepartament2;
        }
        private void DepartamentForm_Load(object sender, EventArgs e)
        {
            connection.Open();
            UpdateDepartament();
            connection.Close();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                EditModuleDepartament editModuleDepartament = new EditModuleDepartament();
                editModuleDepartament.lblId.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                editModuleDepartament.textBox1.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                editModuleDepartament.textBox2.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                editModuleDepartament.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Вы точно хотите удалить данный отдел?", "Удаление отдела", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("DELETE FROM Отдел WHERE КодОтдела LIKE '" + dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    DepartamentForm departamentForm = new DepartamentForm();
                    departamentForm.UpdateDepartament();
                    MessageBox.Show("Успешно удалено!");
                }
            }
        }
    }
}
