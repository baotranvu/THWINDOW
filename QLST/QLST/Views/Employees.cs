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
    public partial class Employees : DevExpress.XtraEditors.XtraForm
    {
        public static string ID;
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_ds.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employee_ds.Employees);


        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            var cellvalue = emp_info.GetRowCellValue(emp_info.FocusedRowHandle, EmpID);
            ID = cellvalue.ToString();
            Employee_info Emp = new Employee_info();
            Emp.ShowDialog();
        }
    }
}