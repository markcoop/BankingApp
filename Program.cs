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
            account.AccountName = "Fred Checking";
            account.AccountNumber = 8675309;
            account.AccountType = "Checking";
            account.EmailAddress = "test@test.com";
            account.Balance = 1165.55m;

            var account2 = new Account();
            account2.AccountName = "Tony Checking";
            account2.AccountNumber = 8675310;
            account2.AccountType = "Checking";
            account2.EmailAddress = "tony@test.com";
            account2.Balance = 0.20m;
            

        }
    }
}
