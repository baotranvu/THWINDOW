using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST
{
    class Order 
    {
        public string ProID { get; set; }
        public string EmpID { get; set; }
       

        public Order(string EmpID, string ProID)
        {
            
            this.EmpID = EmpID;
            this.ProID = ProID;
           
        }
    }
}
