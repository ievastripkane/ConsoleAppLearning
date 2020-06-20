using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLearning
{
    class BankAccount
    {
        public string Number { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get; set; }
        public DateTime Created { get; set; }
        public BankAccount()
        {

        }

        public void PrintInfo()
        {
            Console.WriteLine($"Account number {this.Number} Created on {this.Created.ToShortDateString()} beongs to {this.Owner} and has a balance {this.Balance}");
        }
    }
}
