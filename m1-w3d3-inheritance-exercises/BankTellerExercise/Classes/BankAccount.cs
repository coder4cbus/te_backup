using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BankTellerExercise.Classes
{
    //The BankAccount class represents a simple checking or savings account at a bank. 
    //The balance is represented in USD using the DollarAmount type.
    public class BankAccount
    {
        ////variables
        //private string accountNumber;
        ////not being accessed due to line 22;
        ////set values from inside of the class and here is appropriate
        //private decimal balance;
        ////place to hold value; 
        

        //properties - block of code like method without argument or parameter;
        public string AccountNumber
        { get; set; }
        //default form of property used here and hidden access variable is generated as a result
        //get for return value and set to associated with value.
        //use for derived property when changed to assign a return ; 

        //public string AccountNumber
        //{ get
        //    {
            //    return - derived value; return private instance variable from above

            //}
            //     set; }


        public decimal Balance
        {
            get;
            private set;
            //anywhere - only in class
            //cannot be accessed from checking / savings or Bank Customer class; 
            //cannot be accessed no matter what - no other modifier to use.
        }
        //use on left hand side to assign value of the instance variable or other code to the set aspect of the property;
        //use on right hand side to assoc. with get.


        //constructor
        //public BankAccount()
        //{
        //    AccountNumber = accountNumber;
        //    //above not doing anything; 
        //    Balance = 0;
        //}
        public BankAccount()
        {
            //AccountNumber = accountNumber;
            //above not doing anything;
            Balance = 0;

        }

        //methods
        public decimal Deposit(decimal amountToDeposit)
        {
            Balance += amountToDeposit;
            return Balance;

            //Adds amountToDeposit to the current balance, and returns the new balance of the bank account. 
        }
        
        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            Balance -= amountToWithdraw;
            return Balance;

            //Subtracts amountToWithdraw from the current balance, and returns the new balance of the bank account. 
        }

        public void Transfer(BankAccount destinationAccount, decimal transferAmount)
        {
            Balance -= transferAmount;
            destinationAccount.Balance += transferAmount;
            //Withdraws `transferAmount` from this account and deposits it into `destinationAccount`. 
        }
    }
}
