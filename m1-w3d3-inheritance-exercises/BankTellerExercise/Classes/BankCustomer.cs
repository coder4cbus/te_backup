using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankTellerExercise.Classes;

namespace BankTellerExercise.Classes
{
    public class BankCustomer : BankAccount
    {
        //variables
        //private decimal totalBalance;
        private bool isVip;
        //private string name;
        //private string address;
        //private string phoneNumber;
        //private BankAccount[] accounts;

        private List<BankAccount> listCustomerAccounts = new List<BankAccount>();

        //properties
        public string Name
        { get; set; }

        public string Address
        { get; set; }

        public string PhoneNumber
        { get; set; }

        public BankAccount[] Accounts
        {
            get
            {
                return listCustomerAccounts.ToArray();
                //derived property not associated with a specific instance of variable.
            }
        }
        public bool IsVip
        {
            get
            {
                if (GetTotalBalance() >= (decimal)25000.00)
                {
                    isVip = true;
                }
                else
                {
                    isVip = false;
                }
                return isVip;
            }
            set
            {
                isVip = value;
            }
        }

        //constructor
        public BankCustomer(string name, string address, string phoneNumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            //IsVip = isVip;
            isVip = false;
            //if always the same, do not pass as arg.

            //List<BankAccount> listCustomerAccounts = new List<BankAccount>();
            //above contain by constructor and isolated from the class 
            
        }
        //methods
        public void AddAccount(BankAccount newAccount)
        {
            listCustomerAccounts.Add(newAccount);
        }

        public decimal GetTotalBalance()
        {
            decimal totalBalance = 0.00M;
            foreach (BankAccount account in listCustomerAccounts)
            {
                totalBalance += account.Balance;
                //should return something, ex. values for balances, 
            }
            return totalBalance;
        }
    }
}



