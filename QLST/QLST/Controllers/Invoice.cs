using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST.Models
{
    class Invoice 
    {
        public string CusID { get; set; }
        public string EmpID { get; set; }
        
        public Invoice(string CusID, string EmpID)
        {
            
            this.CusID = CusID;
            this.EmpID = EmpID;
            
        }
    }
}
