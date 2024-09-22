using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Encapsulation.Banking
{
    public class BankAccount
    {
        private string _accountNumber;
        private string _accountHolder;
        private double _balance;
        public string AccountNumber
        {
            get { return _accountNumber; }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    _accountNumber = "Unknown";
                }
                else
                {
                    _accountNumber = value;
                }

            }
        }
        public string AccountHolder
        {
            get { return _accountHolder; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _accountHolder = "Unknown";
                }
                else
                {
                    _accountHolder = value;
                }
            }
        }
        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value < 0)
                {
                    _balance = 0.0;
                }
                else
                {
                    _balance = value;
                }
            }
        }

        public BankAccount(string a, string b, double c)
        {
            AccountNumber = a; AccountHolder = b; Balance = c;
        }

        public void Deposit(double amount)
        {
            if (amount >= 0)
            {
                Balance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (amount >= 0 && (Balance - amount) >= 0)
            {
                Balance -= amount;
            }
        }

        public double GetBalance()
        {
            return Balance;
        }
    }

    //public class Program
    //{
    //    static void Main()
    //    {
    //        BankAccount test = new BankAccount("", "", 1000);
    //        BankAccount test1 = new BankAccount("Te", "Test", 1000);
    //        Console.WriteLine(test.AccountNumber);
    //        Console.WriteLine(test.AccountHolder);
    //        Console.WriteLine(test1.AccountHolder);
    //        Console.WriteLine(test1.AccountNumber);

    //        test.Withdraw(100);
    //        test1.Deposit(100);


    //        Console.WriteLine(test.GetBalance());
    //        Console.WriteLine(test1.GetBalance());

    //    }
    //}
}
