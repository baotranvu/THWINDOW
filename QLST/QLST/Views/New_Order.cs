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
using DevExpress.XtraGrid;

namespace QLST
{
    public partial class New_Order : DevExpress.XtraEditors.XtraForm
    {
        Source source;
        public New_Order()
        {
            InitializeComponent();
            source = new Source();
            
            
        }

       

        private void New_Order_Load(object sender, EventArgs e)
        {


            DataTable dt = source.BindingToGridview();
            gridControl1.DataSource = dt;
            source.AddItem(provider_txt,"select ProID from Providers");
            source.AddItem(product_txt, "select SKU from Products");
        }

        private void product_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProName.Text = source.GetProductName(product_txt.SelectedItem.ToString());
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            
            source.CreatNewRow_NewOrder(gridView1, product_txt.Text,int.Parse(quantity_txt.Text));
            List<OrderDetail> detail = Source.ord_detail;
            int total = source.GetTotal();
            Total.Text = total.ToString();
            
        }

        private void provider_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProVName.Text = source.GetProviderName(provider_txt.SelectedItem.ToString());
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string id = source.GetEmpID();
            string ProId = provider_txt.Text;
            Order ord = new Order(id, ProId);
            source.SendOrder(ord);
            this.Close();
        }
    }
}