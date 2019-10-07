using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //An object = an instance of a class
            var account = new Account();
            account.AccountName = "My Checking";
            account.AccountNumber = 1234;
            account.AccountType = "Checking";
            account.EmailAddress = "test@test.com";
            account.Balance = 10000;

            var account2 = new Account();
            account2.AccountName = "Tony Checking";
            account2.AccountNumber = 0020;
            account2.AccountType = "Checking";
            account2.EmailAddress = "tony@test.com";
            account2.Balance = 100000000;
            

        }
    }
}
