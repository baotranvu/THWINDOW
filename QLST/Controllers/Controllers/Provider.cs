using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST
{
    class Provider : User
    {
        private string Bank { get; set; }
        private string Account { get; set; }
        
        public Provider(string Name, string Address, string Email, string Bank , string Account )
        {
            
            this.Name = Name;
            this.Address = Address;
            this.Email = Email;
            this.Bank = Bank;
            this.Account = Account;
        }

    }
}
