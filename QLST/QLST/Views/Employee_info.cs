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
    public partial class Employee_info : DevExpress.XtraEditors.XtraForm
    {
        public Employee_info()
        {
            InitializeComponent();
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employee_info_Load(object sender, EventArgs e)
        {
            try
            {
                string ID = Employees.ID;
                string query = "select* from Employees where EmpID = '" + ID + "'";
                SqlCommand cmd = new SqlCommand(query, Connect.connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {

                        EmpID.Text = reader.GetString(1);
                        EmpName.Text = reader.GetString(2);
                        EmpGender.Text = reader.GetString(3);
                        EmpBirth.Text = reader.GetSqlValue(4).ToString();
                        EmpAdd.Text = reader.GetString(5);
                        EmpPhone.Text = reader.GetString(6);
                        
                    }

                }
                reader.Close();

            }
            catch (Exception er)
            {
                XtraMessageBox.Show(er.Message);
            }
        }
    }
}