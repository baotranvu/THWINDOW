using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace QLST
{
    class Customer : User 
    {
        internal string Password { get; set; }
        public  Customer(string Name, string Gender, string Birthday, string Address, string Phone, string Email,string Password )
        {
            
            this.Name = Name;
            this.Gender = Gender;
            this.Birthday = Birthday;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            Account acc = new Account();
            this.Password = ComputeHash(Password, new SHA256CryptoServiceProvider() );
            
        }
        public string ComputeHash(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }
    }
}
