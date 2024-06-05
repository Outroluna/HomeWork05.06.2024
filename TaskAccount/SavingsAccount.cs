using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveAcc.TaskAccount
{
    public class SavingsAccount :Account //Сберегательный счет
    {
        protected decimal InterestRate { get; set; } //Процентная ставка
        public SavingsAccount(string firstname, string lastname, decimal balance, decimal interestRate) : base (firstname, lastname,balance)
        {
            InterestRate = interestRate;
        }
        public void InterestAccrual() //Начисление процентов по процентной ставке
        {
            decimal percent = Balance * InterestRate / 100;
            Balance += percent; //Новый баланс
            Console.WriteLine($"По ставке {InterestRate} - начисленно {percent} процентов. Баланс: {Balance}");
        }
    }
}
