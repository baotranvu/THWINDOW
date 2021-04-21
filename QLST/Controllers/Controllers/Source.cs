
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using DevExpress.XtraGrid.Views.Grid;

namespace QLST
{
    class Source
    {
       public static List<OrderDetail> ord_detail = new List<OrderDetail>();
       public void OpenNewForm(Form close,Form open)
        {
            close.Hide();
            open.ShowDialog();
            close.Close();
        } 

        
        public void AddProduct(Product prd)
        {

            try
            {

                SqlCommand cmd = new SqlCommand("dbo.sp_AddProduct", Connect.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", prd.Name);
                cmd.Parameters.AddWithValue("@type", prd.Type);
                cmd.Parameters.AddWithValue("@unit", prd.Unit);
                cmd.Parameters.AddWithValue("@unitprice", prd.UnitPrice);
                cmd.Parameters.AddWithValue("@mfg", prd.MFG);
                cmd.Parameters.AddWithValue("@exp", prd.EXP);
                int a = cmd.ExecuteNonQuery();
                if (a != 0)
                {
                    XtraMessageBox.Show("Sucess!");
                }
                else
                {
                    XtraMessageBox.Show("Fault!");
                }


            }
            catch (SqlException e)
            {
                XtraMessageBox.Show(e.Message);
                throw;
            }
        }
        public void AddCustomer(Customer cus)
        {
            SqlCommand cmd = new SqlCommand("dbo.sp_AddCustomer", Connect.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
               
                cmd.Parameters.AddWithValue("@name", cus.Name);
                cmd.Parameters.AddWithValue("@gender", cus.Gender);
                cmd.Parameters.AddWithValue("@birth", cus.Birthday);
                cmd.Parameters.AddWithValue("@address", cus.Address);
                cmd.Parameters.AddWithValue("@phone", cus.Phone);
                cmd.Parameters.AddWithValue("@mail", cus.Email);
                cmd.Parameters.AddWithValue("@temp", cus.Password);
                int a = cmd.ExecuteNonQuery();
                if (a != 0)
                {
                    XtraMessageBox.Show("Sucess!");
                }
                else
                {
                    XtraMessageBox.Show("Fault!");
                }
            }
            catch (SqlException e)
            {
                XtraMessageBox.Show(e.Message);
                throw;
                cmd.Cancel();
            }
        }
        public void AddEmployee(Employee emp)
        {
            SqlCommand cmd = new SqlCommand("dbo.sp_AddEmployee", Connect.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                
                cmd.Parameters.AddWithValue("@name", emp.Name);
                cmd.Parameters.AddWithValue("@gender", emp.Gender);
                cmd.Parameters.AddWithValue("@birth", emp.Birthday);
                cmd.Parameters.AddWithValue("@address", emp.Address);
                cmd.Parameters.AddWithValue("@phone", emp.Phone);
                cmd.Parameters.AddWithValue("@pass", emp.Password);
                int a = cmd.ExecuteNonQuery();
                if (a != 0)
                {
                    XtraMessageBox.Show("Sucess!");
                }
                else
                {
                    XtraMessageBox.Show("Fault!");
                }
            }
            catch (SqlException e)
            {
                XtraMessageBox.Show(e.Message);
                throw;
                cmd.Cancel();
            }

        }
        public string TrimFromZero(string input)
        {
            int index = input.IndexOf('\0');
            if (index < 0)
                return input;

            return input.Substring(0, index);

        }
        public void AddItem(ComboBoxEdit cb,string query)
        {
            SqlCommand cmd = new SqlCommand(query, Connect.connection);
            try
            {
                
                
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cb.Properties.Items.Add(reader.GetString(0));
                    }
                }
                reader.Close();

            }
            catch (SqlException e)
            {
                XtraMessageBox.Show(e.Message);
               
                cmd.Cancel();
            }   
        }
        public List<string> GetProductInfo(string SKU)
        {
            List<string> info = new List<string>();
            string query = "select SKU, Product, Unit, UnitPrice  from Products where SKU='" + SKU + "'";
            SqlCommand cmd = new SqlCommand(query, Connect.connection);
            try
            {
                
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        info.Add(reader.GetString(0));
                        info.Add(reader.GetString(1));
                        info.Add(reader.GetString(2));
                        info.Add(reader.GetValue(3).ToString());
                                         
                    }
                }
            }
            catch(SqlException e)
            {
                XtraMessageBox.Show(e.Message);
                cmd.Cancel();
            }
            return info;

        }
        public string GetProductName(string SKU)
        {
            string name = null;
            try
            {

                
                string query = "select Product from Products where SKU='" + SKU + "'";
                SqlCommand cmd = new SqlCommand(query, Connect.connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        name = reader.GetString(0);
                    }
                }
                
            }
            catch(SqlException e)
            {
                XtraMessageBox.Show(e.Message);
            }
            return name;
        }
        public string GetProviderName(string ProID)
        {
            string name = null;
            try
            {
                string query = "select Name from Providers where ProID='" + ProID + "'";
                SqlCommand cmd = new SqlCommand(query, Connect.connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        name = reader.GetString(0);
                    }
                }

            }
            catch (SqlException e)
            {
                XtraMessageBox.Show(e.Message);
            }
            return name;
        }
        public void CreatNewRow_NewOrder(GridView gridView,string SKU,int val)
        {
            try
            {
                List<string> info = GetProductInfo(SKU);
                int amount = (val * int.Parse(info[3]));
                gridView.AddNewRow();
                int rowHandle = gridView.GetRowHandle(gridView.DataRowCount);
                if (gridView.IsNewItemRow(rowHandle))
                {
                                      
                            gridView.SetRowCellValue(rowHandle, gridView.Columns["SKU"], info[0]);
                            gridView.SetRowCellValue(rowHandle, gridView.Columns["Product"], info[1]);
                            gridView.SetRowCellValue(rowHandle, gridView.Columns["Quantity"], val);
                            gridView.SetRowCellValue(rowHandle, gridView.Columns["Unit"], info[2]);
                            gridView.SetRowCellValue(rowHandle, gridView.Columns["UnitPrice"], float.Parse(info[3]));
                            gridView.SetRowCellValue(rowHandle, gridView.Columns["Amount"], amount);
                            OrderDetail ord = new OrderDetail(info[0], info[1], val, info[2], float.Parse(info[3]), amount);
                            ord_detail.Add(ord);
                }
            }
            catch(Exception e)
            {
                XtraMessageBox.Show(e.Message);
            }
        }
        public DataTable BindingToGridview()
        {
            
            DataTable dt = new DataTable();
            try
            {
                dt.Columns.Add("SKU");
                dt.Columns.Add("Product");
                dt.Columns.Add("Quantity");
                dt.Columns.Add("Unit");
                dt.Columns.Add("UnitPrice");
                dt.Columns.Add("Amount");
                foreach(OrderDetail ord in ord_detail)
                {
                    DataRow row = dt.NewRow();
                    dt.Rows.Add(ord);
                }
            }catch(Exception e)
            {
                XtraMessageBox.Show(e.Message);
            }
            return dt;

        }
        public int GetTotal()
        {
            int total = 0;
            foreach(OrderDetail det in ord_detail)
            try
            {
                    total += det.Amount;
            }
            catch(Exception e)
            {
                XtraMessageBox.Show(e.Message);
            }
            return total;
        }
        public void SendOrder(Order ord)
        {
            int b = 0;
            SqlCommand cmd = new SqlCommand("dbo.sp_NewOrder", Connect.connection);
            SqlCommand cmd1 = new SqlCommand("dbo.sp_OrderDetail", Connect.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd1.CommandType = CommandType.StoredProcedure;
            List<OrderDetail> temp = ord_detail;
            temp.Select(x => x.SKU).Distinct();
            try
            {
                cmd.Parameters.AddWithValue("@EmID", ord.EmpID);
                cmd.Parameters.AddWithValue("@ProID", ord.ProID);
                foreach(OrderDetail det in temp)
                {
                    cmd1.Parameters.AddWithValue("@sku",det.SKU);
                    cmd1.Parameters.AddWithValue("@quantity", det.Quantity);
                    b = cmd1.ExecuteNonQuery();
                }
                 
                ord_detail.Clear();
                int a = cmd.ExecuteNonQuery();
               
                if (a != 0 && b!=0)
                {
                    XtraMessageBox.Show("Sucess!");
                }
                else
                {
                    XtraMessageBox.Show("Fault!");
                }
            }
            catch (SqlException e)
            {
                XtraMessageBox.Show(e.Message);
                cmd.Cancel();
                cmd1.Cancel();
            }
        }
        public string GetEmpID()
        {
            string id=null;
            string name = Login.name;
            string query = "select EmpID from Employees where Name=' " + name + "'";
            try
            {
                SqlCommand cmd = new SqlCommand(query, Connect.connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                         id = reader.GetString(0);
                    }
                }

            }
            
            catch (SqlException e)
            {
                XtraMessageBox.Show(e.Message);
            }
            return id;
        }
        



    }
}

