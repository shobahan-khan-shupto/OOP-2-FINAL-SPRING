using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flab1
{
    class Transaction
    {
        private Account sender;
        public Account Sender
        {
            get { return sender; }
            set { sender = value; }
        }

        private Account receiver;
        public Account Receiver
        {
            get { return Receiver; }
            set { Receiver = value; }
        }


        private int amount;
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private String additionalInfo;

        public String AdditionalInfo
        {
            get { return additionalInfo; }
            set { additionalInfo = value; }
        }

        private Account acc;
        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }


        public Transaction()
        {
        }
        public Transaction(Account sender, Account receiver, int amount)
        {
            this.Sender = sender;
            this.Receiver = receiver;
            this.Amount = amount;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Sender: " + sender);
            Console.WriteLine("Receiver: " + receiver);
            Console.WriteLine("Amount: " + amount);
        }
        public void ShowDetails()
        {
            ShowInfo();
            acc.ShowInfo();
        }
    }
}