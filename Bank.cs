using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    class Bank
    {

        #region Methods

        public Account CreateAccount(string accountName, string emailAddress, TypeOfAccount accountType, decimal initialDeposit)
        {
            var account = new Account
            {
                AccountName = accountName,
                EmailAddress = emailAddress,
                AccountType = accountType
            };
            
            if (initialDeposit > 0)
            {
                account.Deposit(initialDeposit);
            }

            return account;
        }

        

        #endregion
        
    }
}
