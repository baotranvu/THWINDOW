
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST
{
    class Employee :User
    {
        internal string Password { get; set; }
        public Employee(string Name, string Gender, string Phone ,string Address , string Date, string pass )
        {
            
            this.Name = Name;
            this.Gender = Gender;
            this.Phone = Phone;
            this.Address = Address;
            this.Birthday = Date;
            this.Password = pass;
        }
    }
}
