using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    /// <summary>
    /// This is the definition
    /// of an account for a bank
    /// </summary>
    class Account
    {
        #region Properties
        /// <summary>
        /// Name of the account
        /// </summary>
        public String AccountName { get; set; }
        public decimal Balance { get; set; }
        public string EmailAddress { get; set; }
        public string AccountType { get; set; }
        public int AccountNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        #endregion

    }
}

