using System;

namespace Exercises
{
    public class BookExercises
    {
        public void Run()
        {
            new BankOperations().Main();
        }
        public class BankAccount
        {
            public string owner;
            public double balance;

            public void ShowInfo()
            {
                Console.WriteLine($"Owner: {owner}, Balance: {balance}");
            }

            public void Deposit(double amount)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
            }

            // public void Withdraw(double amount)
            // {
            //     if (amount <= balance)
            //     {
            //         balance -= amount;
            //         Console.WriteLine($"Withdrew: {amount}, New Balance: {balance}");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Insufficient funds.");
            //     }
            // }
            
            public bool Withdraw (double amount)
            {
                bool success = amount <= balance;
                if (!success)
                {
                    Console.WriteLine("Insufficient funds.");
                }
                else
                {
                    balance -= amount;
                    Console.WriteLine($"Withdraw: {amount}, New Balance: {balance}");
                }
                return success;
            }
        }

        public class BankOperations
        {
            public void Main()
            {
                BankAccount account = new BankAccount();
                account.owner = "John Doe";
                account.balance = 500.0;

                account.ShowInfo();
                account.Deposit(200.0);

                // account.Withdraw(100.0);
                // account.Withdraw(1000.0);
                // account.ShowInfo();

                bool firstWithdrawal = account.Withdraw(100.0);
                if (firstWithdrawal)
                {
                    Console.WriteLine("First withdrawal successful.");
                }
                else
                {
                    Console.WriteLine("First withdrawal failed.");
                }

                bool secondWithdrawal = account.Withdraw(1000.0);
                if (secondWithdrawal)
                {
                    Console.WriteLine("Second withdrawal successful.");
                }
                else
                {
                    Console.WriteLine("Second withdrawal failed.");
                }

                account.ShowInfo();
            }
        }
    }
}
