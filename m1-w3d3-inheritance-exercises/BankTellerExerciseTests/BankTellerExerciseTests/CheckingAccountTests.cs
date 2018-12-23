using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class CheckingAccountTests 
    {
        [TestMethod]
        public void CheckingWithdraw()
        {
            //Arrange
            CheckingAccount b1 = new CheckingAccount();

            decimal amountWithdraw = 130.00M;
            decimal balance = 0.00M;
            //Act
            decimal balanceTest = b1.Withdraw(amountWithdraw);
            //Assert
            Assert.AreEqual(balance, balanceTest);
            //Checking account cannot be more than $100.00 overdrawn.If a withdrawal is requested leaving the account more than $100.00, it fails and the balance remains the same. 

            //Arrange
            CheckingAccount b2 = new CheckingAccount();
            decimal amount2Withdraw = 90.00M;
            decimal balanceNew = 0.00M;
            //Act
            decimal balance2Test = b2.Withdraw(amount2Withdraw);
            //Assert
            Assert.AreEqual(balanceNew, balance2Test);
            //Checking account cannot be more than $100.00 overdrawn.If a withdrawal is requested leaving the account more than $100.00, it fails and the balance remains the same. 

            //Arrange
            CheckingAccount b3 = new CheckingAccount();
            amountWithdraw = 5.00M;
            balance = -15.00M;
            //Act
            balanceTest = b3.Withdraw(amountWithdraw);
            //If the balance falls below $0.00 a $10.00 overdraft fee is also withdrawn from the account.
        }
    }
}

