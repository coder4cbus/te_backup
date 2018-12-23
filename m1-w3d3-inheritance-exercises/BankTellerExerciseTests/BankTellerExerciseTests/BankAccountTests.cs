using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class BankAccountTests 
    {
        [TestMethod]
        public void DepositGetBalance()
        {
            //Arrange
            BankAccount b1 = new BankAccount();
            BankAccount b2 = new BankAccount();
            BankAccount b3 = new BankAccount();

            //Assert & Act
            decimal b1DepositAmt = b1.Deposit(100.00M);
            //100.00M
            decimal b2DepositAmt = b2.Deposit(23.14M);
            //23.14M
            decimal b3DepositAmt = b3.Deposit(-123.00M);
            //-123.00M

            Assert.AreEqual(100.00M, b1DepositAmt);
            Assert.AreEqual(23.14M, b2DepositAmt);
            Assert.AreEqual(-123.00M, b3DepositAmt);
        }

        [TestMethod]
        public void WithdrawGetBalance()
        {
            //Arrange
            BankAccount b1 = new BankAccount();
            BankAccount b2 = new BankAccount();
            BankAccount b3 = new BankAccount();

            //Assert & Act
            decimal b1WithdrawAmt = b1.Withdraw(-25.00M);
            //+25.00
            decimal b2WithdrawAmt = b2.Withdraw(10.00M);
            //0-10.00 = -10.00
            decimal b3WithdrawAmt = b3.Withdraw(0.00M);
            //0

            Assert.AreEqual(25.00M, b1WithdrawAmt);
            Assert.AreEqual(-10.00M, b2WithdrawAmt);
            Assert.AreEqual(0.00M, b3WithdrawAmt);
        }

        [TestMethod]
        public void VerifyTransfer()
        {
            //Arrange
            BankAccount b8 = new BankAccount();
            BankAccount b9 = new BankAccount();
            
            //Act
            decimal amountToDeposit = 100.00M;
            decimal newBalance = b8.Deposit(amountToDeposit);
            decimal amountToTransfer = 50.0M;

            //Assert 
            b8.Transfer(b9, amountToTransfer); 
        }
    }
}
