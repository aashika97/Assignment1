using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
   public class BankAccount
    {
        // Properties
        private string accountNumber;
        private decimal balance;

        // Constructor
        public BankAccount(string accountNumber)
        {
            this.accountNumber = accountNumber;
            this.balance = 0;
        }

        // Method to deposit money
        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        // Method to withdraw money
        public void Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
        }

        // Method to get the current balance
        public decimal GetBalance()
        {
            return balance;
        }
    }

}
