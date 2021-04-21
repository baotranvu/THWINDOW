using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLST
{
    public partial class Products : DevExpress.XtraEditors.XtraForm
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'product_ds.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.product_ds.Products);
            // TODO: This line of code loads data into the 'product1.Products' table. You can move, or remove it, as needed.


        }

        private void Product_Click(object sender, EventArgs e)
        {

        }
    }
}