using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account rony = new Savings("Shupto", "01", 3000.0f);
            Account ahmed = new Current("Khan", "02", 2000f);
            Account md = new Fixed("MD", "03", 1000f, 2016, 10);

            Account a1 = new SuperSavings("Raima", "04", 100f);
            a1.Withdraw(80);
            a1.ShowInfo();

            Account overdraft = new Overdraft("Khan", "05", 1000f, 7000);
            overdraft.Transfer(a1, 5000);
            overdraft.ShowInfo();

            Customer customer = new Customer("Shupto khan");

        }
    }
}