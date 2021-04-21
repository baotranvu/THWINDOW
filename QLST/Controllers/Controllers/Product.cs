using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace QLST
{
    class Product
    {
       
        public string Name { get; set; }
        public string Type { get; set; }
        public string Unit { get; set; }
        public string UnitPrice { get; set; }
        public SqlDateTime MFG { get; set; }
        public SqlDateTime EXP { get; set; }
       

        public Product(string Name, string Type, string Unit, string UnitPrice, SqlDateTime MFG, SqlDateTime EXP)
        {
            
            this.Name = Name;
            this.Type = Type;
            this.Unit = Unit;
            this.UnitPrice = UnitPrice;
            this.MFG = MFG;
            this.EXP = EXP;
           

        }

    }
}
