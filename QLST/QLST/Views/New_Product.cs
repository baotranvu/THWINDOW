using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using DevExpress.XtraEditors;

namespace QLST
{
    public partial class New_Product : DevExpress.XtraEditors.XtraForm
    {
        public New_Product()
        {
            InitializeComponent();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            { 
                Source source = new Source();
                string mfg0 = null;
                string exp0 = null;
                string name = this.Name.Text;
                string type = this.Type.Text;
                string unit = this.Unit.Text;
                string unitprice = this.UnitPrice.Text;
                if (this.MFG.Text.Equals("") && this.EXP.Text.Equals(""))
                {
                     mfg0 = null;
                     exp0 = null;
                }
                else
                {
                     mfg0 = this.MFG.Text;
                     exp0 = this.EXP.Text;
                }
                SqlDateTime mfg = SqlDateTime.Parse(mfg0.ToString());
                SqlDateTime exp = SqlDateTime.Parse(exp0.ToString());
                Product prt = new Product(name, type, unit, unitprice, mfg, exp);
                source.AddProduct(prt);
                
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                throw;
            }
            

        }
    }
}