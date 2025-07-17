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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
            

        }

        private void btnVendors_Click(object sender, EventArgs e)
        {
            this.Hide();
            VendorsForms formsVendor = new VendorsForms();
            formsVendor.Show();

        }

        private void btnDepart_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepartamentForm formsDepartament = new DepartamentForm();
            formsDepartament.Show();
        }

        private void btnWh_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Autorization autorization = new Autorization();
            autorization.Show();
        }
    }
}
