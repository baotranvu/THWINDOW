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
    public partial class New_Employee : DevExpress.XtraEditors.XtraForm
    {
        public New_Employee()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
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
                        string name = FirstName.Text + LastName.Text;
                        string gender = Gender.SelectedItem.ToString();
                        string address = con.TrimFromZero(Address.Text);
                        string phone = con.TrimFromZero(Phone.Text);
                        string date = Date.Text;
                        string pass = Password.Text;
                        Employee emp = new Employee(name, gender, phone, address, date, pass);
                        con.AddEmployee(emp);
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