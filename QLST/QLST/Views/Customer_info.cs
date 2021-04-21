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
using System.Data.SqlClient;

namespace QLST
{
    public partial class Customer_Info : DevExpress.XtraEditors.XtraForm
    {
        public Customer_Info()
        {
            InitializeComponent();
        }

        private void Customer_info_Load(object sender, EventArgs e)
        {
            try
            {
                string ID = Customers.ID;
                string query = "select* from Customer_info where CusID = '"+ID+"'";
                SqlCommand cmd = new SqlCommand(query, Connect.connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                       
                        CusID.Text = reader.GetString(0);
                        CusName.Text = reader.GetString(1);
                        CusGender.Text = reader.GetString(2);
                        CusBirth.Text = reader.GetSqlValue(3).ToString();
                        CusAdd.Text = reader.GetString(4);
                        CusPhone.Text = reader.GetString(5);
                        CusMail.Text = reader.GetString(6);
                        Rank.Text = reader.GetValue(7).ToString();
                        Point.Text = reader.GetValue(8).ToString();
                    }

                }
                reader.Close();

            }
            catch(Exception er)
            {
                XtraMessageBox.Show(er.Message);
            }


        }

        private void textEdit8_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}