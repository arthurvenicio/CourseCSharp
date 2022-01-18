using System;
using System.Collections.Generic;

namespace Course
{
    internal class Account
    {
        private double _balance;

        public int Number { get; set; }

        public string Owner { get; set; }

        public Account()
        { }

        public Account(int number, string owner)
        { 
            this.Number = number;
            this.Owner = owner;
            this._balance = 0.00;
        }

        public Account(int number, string owner, double value)
        {
            this.Number = number;
            this.Owner = owner;
            this._balance = value;
        }

        public double Balance
        {
            set { _balance = value; }
        }


        public double GetBalance()
        {
            return this._balance;
        }

        public void AddBalance (double price)
        {
            this.Balance = this._balance + price;
        }

        public void RemoveBalance(double price)
        {
            this.Balance = this._balance - (price + 5.0);
        }

    }
}
