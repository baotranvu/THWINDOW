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
using DevExpress.XtraEditors.Mask;

namespace QLST
{
    public partial class New_Customer : DevExpress.XtraEditors.XtraForm
    {
         
         
        public New_Customer()
        {
            InitializeComponent();
            
            

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void New_Customer_Load(object sender, EventArgs e)
        {
            
        }

        private void textEdit8_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Source con = new Source();
                if (!this.Password.Text.Equals(this.Confirm.Text))
                {
                    XtraMessageBox.Show("Password not matching !");
                    this.Confirm.Focus();

                }
                else
                {
                    if (FirstName.Text.Equals("") || LastName.Text.Equals(""))
                    {
                        XtraMessageBox.Show("Invalid Name!");
                    }
                    else
                    {
                        string firstname = this.FirstName.Text;
                        string lastname = this.LastName.Text;
                        string name = firstname + lastname;
                        string date = this.Date.Text;
                        string address = con.TrimFromZero(this.Address.Text);
                        string phone = con.TrimFromZero(this.Phone.Text);
                        string mail = con.TrimFromZero(this.Mail.Text);
                        string gender = this.Gender.SelectedItem.ToString();
                        string pass = this.Password.Text;
                        Customer cus = new Customer(name, gender, date, address, phone, mail, pass);
                        con.AddCustomer(cus);
                    }
                }
                
            }
            catch(Exception er)
            {
                XtraMessageBox.Show(er.Message);
               
            }
                
        }
    }
}