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
    public partial class Invoice : DevExpress.XtraEditors.XtraForm
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void Inv_Click(object sender, EventArgs e)
        {
            Invoice_detal invoice_d = new Invoice_detal();
            invoice_d.ShowDialog();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invoice_ds.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.invoice_ds.Invoices);
            // TODO: This line of code loads data into the 'superMarketDataSet1.Invoices' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'superMarketDataSet3.Invoices' table. You can move, or remove it, as needed.


        }
    }
}