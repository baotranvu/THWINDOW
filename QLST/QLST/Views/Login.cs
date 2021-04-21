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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public static string name;
        public Login()
        {
            InitializeComponent();
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            Connect connect = new Connect();
            Account account = new Account();
            account.Login = user_edt.Text;
            name = account.Login;
            account.Password = pass_edt.Text;
            connect.ConnectToServer(account,this);
          
        }
    }

       
    
}