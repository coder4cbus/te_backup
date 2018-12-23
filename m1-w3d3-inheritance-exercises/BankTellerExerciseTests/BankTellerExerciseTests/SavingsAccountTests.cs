using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.BankTellerExerciseTests
{
    [TestClass]
    public class SavingsAccountTests : BankAccount
    {
        [TestMethod]
        public void SavingsWithdraw()
        {
            //Arrange
            SavingsAccount b1 = new SavingsAccount();
            SavingsAccount b2 = new SavingsAccount();

            decimal balance = 0.00M;//Start balance of $0
            decimal amountWithdraw = 25.00M;
            //Act
            decimal balanceTest = b1.Withdraw(amountWithdraw);
            //Assert
            Assert.AreEqual(balance, balanceTest);
            //If a withdrawal is requested for more than the current balance, the withdrawal fails and balance remains the same. 


            //Arrange
            decimal deposit = 140.00M;
            decimal amount2Withdraw = 20.00M;
            //Act
            decimal newBalance = b2.Deposit(deposit);
            newBalance = b2.Withdraw(amount2Withdraw);
            //Assert
            Assert.AreEqual(118.00M, newBalance); // $118 is 140 -20 plus the $2 fee
            // If the current balance is less than $150.00 when a withdrawal is made, an additional $2.00 service charge is withdrawn from the account.
        }
    }
}


