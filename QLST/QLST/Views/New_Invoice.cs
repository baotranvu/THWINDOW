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
    public partial class New_Invoice : DevExpress.XtraEditors.XtraForm
    {
        Login login;
        public New_Invoice()
        {
            InitializeComponent();
            
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

            }
        }

        private void Employee1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Curent user:" + "\n" + Login.name);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Customers cus = new Customers();
            cus.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Products product = new Products();
            product.ShowDialog();
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New_Customer cus = new New_Customer();
            cus.ShowDialog();
        }
    }
}