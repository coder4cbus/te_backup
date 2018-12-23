using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankTellerExercise.Classes;

namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            decimal withdrawBalance = 0.00M;
            if (amountToWithdraw > Balance)
            {
                withdrawBalance = this.Balance;
                //If a withdrawal is requested for more than the current balance, the withdrawal fails and balance remains the same. 
            }
            else if (Balance < 150.00M)
            {
                withdrawBalance = base.Withdraw(amountToWithdraw + 2.00M);
                // If the current balance is less than $150.00 when a withdrawal is made, an additional $2.00 service charge is withdrawn from the account.
            }
            return withdrawBalance;
        }
    }
}

