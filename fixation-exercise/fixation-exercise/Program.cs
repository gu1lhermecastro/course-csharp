using System;

namespace fixation_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numberAccount = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string holder = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char option = char.Parse(Console.ReadLine());

            BankAccount bankAccount;

            if (option == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double initialDepositAmount = double.Parse(Console.ReadLine());
                bankAccount = new BankAccount(numberAccount, holder, initialDepositAmount);
            }
            else
            {
                bankAccount = new BankAccount(numberAccount, holder);
            }

            Console.Write(bankAccount.ToString());

            Console.Write("Entre um valor para depósito: ");
            double depositAmount = double.Parse(Console.ReadLine());
            bankAccount.AddCharge(depositAmount);
            Console.Write(bankAccount.ToString());

            Console.Write("Entre um valor para saque: ");
            double withdrawalAmount = double.Parse(Console.ReadLine());
            bankAccount.BankWithdrawal(withdrawalAmount);
            Console.Write(bankAccount.ToString());
        }
    }
}
