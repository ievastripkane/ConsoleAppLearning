﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLearning
{
    class BankAccount
    {
        private List<Transaction> transactions = new List<Transaction>();
        private static int accountNumber = 123;
        public string Number { get; }
        public string Owner { get; }
        public decimal Balance { get; }
        public DateTime Created { get; }
        public string Currency { get; }

        public BankAccount(string owner, decimal balance, string currency)
        {
            this.Number = accountNumber.ToString();
            accountNumber++;
            this.Owner = owner;
            this.Balance = balance;
            this.Currency = currency;
            this.Created = DateTime.Now;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Account number {this.Number} Created on {this.Created.ToShortDateString()} belongs to {this.Owner} with a balance {this.Balance} {this.Currency}");
        }

        public void MakeDeposit(decimal amount, string note)
        {
            Transaction deposit = new Transaction(amount, note);
            transactions.Add(deposit);
        }
    }

}
