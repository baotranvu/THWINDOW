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
    
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Login login;
        public Main()
        {
            InitializeComponent();
            Current.Caption = "Welcome:"+ "\n" + Login.name;
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void Main_Load(object sender, EventArgs e)
        {

            

        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.AutoCloseOptions.Delay = 5000;
            args.Caption = "WARNING!";
            args.Text = "Log out ? This message closes automatically after 5 seconds.";
            args.Buttons = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };
            if (XtraMessageBox.Show(args) == DialogResult.OK)
            {
                this.Hide();
                login = new Login();
                login.ShowDialog();
                this.Close();
                Connect.connection.Close();

            }
            
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.ShowDialog();

        }

        private void barButtonItem4_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Customers customer = new Customers();
            customer.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Employees employee = new Employees();
            employee.ShowDialog();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Providers provider = new Providers();
            provider.ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Products product = new Products();
            product.ShowDialog();
            
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New_Employee emp = new New_Employee();
            emp.ShowDialog();
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void Employee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Curent user:" + "\n" + Login.name);
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New_Product newproduct = new New_Product();
            newproduct.ShowDialog();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New_Provider newprovider = new New_Provider();
            newprovider.ShowDialog();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New_Order neworder = new New_Order();
            neworder.ShowDialog();
        }

        private void barButtonItem27_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New_Customer cus = new New_Customer();
            cus.ShowDialog();
        }

        private void Current_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Current user:\n"+Login.name);
        }

        private void barButtonItem26_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New_Invoice newinvoice = new New_Invoice();
            newinvoice.ShowDialog();

        }
    }
}