using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLST
{
    class OrderDetail
    {
        public string SKU { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public float UnitPrice { get; set; }
        public int Amount { get; set; }

        public OrderDetail(string SKU, string product, int quantity, string unit, float unitprice, int amount)
        {
            this.SKU = SKU;
            this.Product = product;
            this.Quantity = quantity;
            this.Unit = unit;
            this.UnitPrice = unitprice;
            this.Amount = amount;
        }
        
    }
}
