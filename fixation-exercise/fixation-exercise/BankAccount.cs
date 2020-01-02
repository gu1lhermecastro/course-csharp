using System;
using System.Collections.Generic;
using System.Text;

namespace fixation_exercise
{
    class BankAccount
    {
        public int NumberAccount { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        //TODO: Improve implements tax per withdrawal
        private double TaxPerWithdrawal = 5.0;


        public BankAccount(int NumberAccount, string Holder)
        {
            this.NumberAccount = NumberAccount;
            this.Holder = Holder;
        }

        public BankAccount(int NumberAccount, string Holder, double Balance) : this (NumberAccount, Holder)
        {
            AddCharge(Balance);
        }

        public void AddCharge(double DepositAmount)
        {
            this.Balance += DepositAmount;
        }
        public void BankWithdrawal(double WithdrawalAmount)
        {
            this.Balance -= (WithdrawalAmount + TaxPerWithdrawal);
        }

        public override string ToString()
        {
            return $"\nDados da conta atualizados:\nConta {NumberAccount}, Titular: {Holder}, Saldo: {Balance}";
        }
    }
}
