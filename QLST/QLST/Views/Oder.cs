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
    public partial class Oder : DevExpress.XtraEditors.XtraForm
    {
        public Oder()
        {
            InitializeComponent();
        }

        private void Oder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'order_ds.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.order_ds.Orders);

        }
    }
}