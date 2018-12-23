using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BankTellerExercise.Classes;


namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class BankCustomerTests
    {
        BankCustomer testBankCustomer;
       [TestInitialize]
       public void Initialize()
        {
           testBankCustomer = new BankCustomer("Name", "Address", "PhoneNumber", false);
        }
        [TestMethod]
        public void AddBankCustomerTest()
        {
            //Arrange
            string expectedName = "First.Last Name";
            string expectedAddress = "1234 MadeUp Street Cbus, OH 43231";
            string expectedPhoneNumber = "614-FOR-HELP";
            bool expectedIsVip = false;
            
            //Act
            BankCustomer actualBankCustomer = new BankCustomer(expectedName, expectedAddress, expectedPhoneNumber, expectedIsVip);

            BankCustomer newCustomer = actualBankCustomer;
            newCustomer.Name = "First.Last Name";
            newCustomer.Address = "1234 MadeUp Street Cbus, OH 43231";
            newCustomer.PhoneNumber = "614-FOR-HELP";
            newCustomer.IsVip = false;

            string nameResult = actualBankCustomer.Name;
            string addressResult = actualBankCustomer.Address;
            string phoneNumberResult = actualBankCustomer.PhoneNumber;
            BankCustomer isVipBankCustomer = new BankCustomer(expectedName, expectedAddress, expectedPhoneNumber, true); 

            //Assert
            Assert.AreEqual(expectedName, newCustomer.Name);
            Assert.AreEqual(expectedAddress, newCustomer.Address);
            Assert.AreEqual(expectedPhoneNumber, newCustomer.PhoneNumber);
            Assert.ReferenceEquals(actualBankCustomer, newCustomer);
            Assert.AreEqual(actualBankCustomer.IsVip, newCustomer.IsVip);
            ReferenceEquals(actualBankCustomer, testBankCustomer);
        }


        [TestMethod]
        public void Customer_AddNewAccountTest()
        {
            //Arrange
            CheckingAccount c1 = new CheckingAccount();          
            SavingsAccount s1 = new SavingsAccount();
            BankAccount bankaccountNewA = new BankAccount();
            BankAccount bankaccountNewB = new BankAccount();
            BankAccount bankaccountNewC = new BankAccount();
            BankAccount bankaccountNewD = new BankAccount();

            List<BankAccount> expectedListOfAccounts = new List<BankAccount>();
            expectedListOfAccounts.Add(c1);
            expectedListOfAccounts.Add(s1);
            expectedListOfAccounts.Add(bankaccountNewA);
            expectedListOfAccounts.Add(bankaccountNewC);

            List<BankAccount> listCustomerAccounts = new List<BankAccount>();
            expectedListOfAccounts.Add(c1);
            expectedListOfAccounts.Add(s1);
            expectedListOfAccounts.Add(bankaccountNewA);

            BankAccount newAccount = bankaccountNewC;
            testBankCustomer.AddAccount(bankaccountNewC);

            string expectedName = "First.Last Name";
            string expectedAddress = "1234 MadeUp Street Cbus, OH 43231";
            string expectedPhoneNumber = "614-FOR-HELP";
            BankCustomer isVipBankCustomer = new BankCustomer(expectedName, expectedAddress, expectedPhoneNumber, true);
            BankCustomer hasFourAccountsBankCustomer = new BankCustomer("Name", "Address", "PhoneNumber", false);
            //Act
            isVipBankCustomer.AddAccount(bankaccountNewC);
            hasFourAccountsBankCustomer.AddAccount(bankaccountNewC);

            ////Assert 
            Assert.AreEqual(1, testBankCustomer.Accounts.Length);
            CollectionAssert.AreEqual(isVipBankCustomer.Accounts, hasFourAccountsBankCustomer.Accounts);

        }

    }
}
