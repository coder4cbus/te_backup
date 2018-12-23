using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankTellerExercise.Classes;

namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            decimal withdrawBalance = 0.00M;
            if (amountToWithdraw >= Balance + 90.00M)
            {
                withdrawBalance = this.Balance;
                //Checking account cannot be more than $100.00 overdrawn. If a withdrawal is requested leaving the account more than $100.00, it fails and the balance remains the same. 
            }
            else if (amountToWithdraw > Balance)
            {
                withdrawBalance= base.Withdraw(amountToWithdraw + 10.00M);
                //base.Withdrawl means calling parent method of Withdraw() and making a slight tweak of adding 10 to the final result;
                //If the balance falls below $0.00 a $10.00 overdraft fee is also withdrawn from the account.
            }
            else
            {
                withdrawBalance = base.Withdraw(amountToWithdraw);
            }  
            return withdrawBalance;
        }
    }
}
