
using System;

namespace ATMApp
{
    class ATM
    {
       
        private decimal _balance;
        private double _pin=123;

      
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"{amount} deposited successfully.");
            }
            else
            {
                Console.WriteLine("Enter a valid amount to deposit.");
            }
        }

      
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine($"{amount} withdrawn successfully.");
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid amount.");
            }
        }

       
        public void ShowBalance()
        {
            Console.WriteLine($"Current Balance: {_balance}");
        }
  
    }
}

    
