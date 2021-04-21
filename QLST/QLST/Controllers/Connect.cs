using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace QLST
{
    class Connect 
    {
        public static SqlConnection connection;
        public static string connectionString;
        public string Createconnect(Account acount)
        {
            SqlConnectionStringBuilder b = new SqlConnectionStringBuilder();
            b.DataSource = @"ADMIN\SUPERMARKET";
            b.InitialCatalog = "SuperMarket";
            b.IntegratedSecurity = false;
            b.UserID = acount.Login;
            b.MultipleActiveResultSets = true;
            b.Password = acount.Password;
            connectionString = b.ConnectionString;
            return connectionString;
        }
        public  bool IsServerConnected(string connectionString)
        {
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException e)
                {
                     
                    
                    XtraMessageBox.Show(e.Message);
                    return false;
                    
                }
            
        }
        public void ConnectToServer(Account acc,Form close)
        {
            string name = Login.name;
            string s = "SELECT name FROM master.sys.sql_logins WHERE name ='" + acc.Login + "'";
            Source source = new Source();
            string connectionString = Createconnect(acc);
            bool check = IsServerConnected(connectionString);
            if (check)
            {
                SqlCommand command = new SqlCommand(s, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        name = reader.GetString(0);
                    }
                    close.Hide();
                    Main main = new Main();
                    main.ShowDialog();
                    close.Close();
                }
                else
                {
                    XtraMessageBox.Show("Can not connect to server!");
                }
            }
            
            
        }
        

    }


    }

