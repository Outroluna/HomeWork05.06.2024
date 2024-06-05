using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acc.TaskAccount;

namespace CheckAcc.TaskAccount
{
    public class ChekingAccount : Account
    {
        public int Limit { get; set; }
        public ChekingAccount(int limit, string firstname,string lastname, decimal balance) : base(firstname, lastname, balance)
        {
            Limit = limit;
        }
        public void Overdraft(int amount)
        {
            if (Balance + Limit >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"{amount} выведена со счета: {FullName}. Баланс: {Balance}");
            }
            else
                Console.WriteLine($"Недостаточно средств для выведения суммы: {amount}");
        }
    }
}
