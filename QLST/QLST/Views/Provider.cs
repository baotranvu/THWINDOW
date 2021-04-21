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
    public partial class Providers : DevExpress.XtraEditors.XtraForm
    {
        public Providers()
        {
            InitializeComponent();
        }

        private void Provider_Click(object sender, EventArgs e)
        {

        }

        private void Providers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'provider_ds.Providers' table. You can move, or remove it, as needed.
            this.providersTableAdapter.Fill(this.provider_ds.Providers);
            // TODO: This line of code loads data into the 'provider_ds.Providers' table. You can move, or remove it, as needed.


            // TODO: This line of code loads data into the 'superMarketDataSet.Providers' table. You can move, or remove it, as needed.


        }
    }
}