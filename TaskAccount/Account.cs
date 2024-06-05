using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.TaskAccount
{
    public class Account
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public decimal Balance { get;  set; }
        protected string FullName => $"{FirstName} {LastName}";
        public Account(string firstname, string lastname, decimal balance)
        {
            FirstName = firstname ;
            LastName = lastname ;
            Balance = balance;
        }
    }
}
