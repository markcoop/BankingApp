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
            var account = new Account {
                AccountType = TypeOfAccount.Checking,
                EmailAddress = "test@test.com"
            };
            //account.AccountName = "Fred Checking";
            //account.AccountType = TypeOfAccount.Checking;
            //account.EmailAddress = "test@test.com";

            account.Deposit(1023.45M);
            Console.WriteLine($"AN: {account.AccountNumber}, EA: {account.EmailAddress}, B: {account.Balance:C}, AT: {account.AccountType}, CD: {account.CreatedDate}");


            var account2 = new Account();
            account2.AccountName = "Tony Checking";
            account2.AccountType = TypeOfAccount.Checking;
            account2.EmailAddress = "tony@test.com";

            Console.WriteLine($"AN: {account2.AccountNumber}, EA: {account2.EmailAddress}, B: {account2.Balance:C}, AT: {account2.AccountType}, CD: {account2.CreatedDate}");



        }
    }
}
