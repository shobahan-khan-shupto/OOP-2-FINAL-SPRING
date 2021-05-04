using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLab1
{
    class Account
    {
        string accId;
        string accName;
        string accBalance;


        private Transaction[] listOfTransaction;

        public void addTransaction(params Transaction[] transaction)
        {
            foreach (Transaction t in transaction)
            {
                listOfTransaction[totalNumberOfTransaction++] = t;
                t.Acc = this;
            }

        }

        private int totalNumberOfTransaction;
        public int TotalNumberOfTransaction
        {
            get { return totalNumberOfTransaction; }
            set { totalNumberOfTransaction = value; }
        }

        public string AccName { get; set; }
        public string AccNo { get; }
        public double Balance { get; set; }

        public Account()
        {
            listOfTransaction = new Transaction[60];
        }
        public Account(string AccName, string AccNo, double Balance)
        {
            this.AccName = AccName;
            this.AccNo = AccNo;
            this.Balance = Balance;
            listOfTransaction = new Transaction[60];
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Acc Name: " + AccName);
            Console.WriteLine("Acc No: " + AccNo);
            Console.WriteLine("Balance: " + Balance);

        }
        public void showAllTranscation()
        {
            for (int i = 0; i < totalNumberOfTransaction; i++)
            {
                listOfTransaction[i].ShowInfo();
            }
        }

        public void Withdraw(double amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                Console.WriteLine("Balance after withdraw: " + Balance);
            }

        }
        public void Transfer(Account acc, double amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                Console.WriteLine("Balance after Transfer: " + Balance);
            }

        }

    }
}