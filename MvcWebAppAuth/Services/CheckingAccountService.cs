using MvcWebAppAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebAppAuth.Services
{
    public class CheckingAccountService
    {
        private ApplicationDbContext db;
        public CheckingAccountService(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        public void CreateCheckingAccount(string firstName, string lastName, string userid, decimal balance)
        {
            var accountNumber = (123456 + db.CheckingAccounts.Count()).ToString().PadLeft(10, '0');
            var checkingAccount = new CheckingAccount { FirstName = firstName, LastName = lastName, ApplicationUserId = userid, Balance = balance, AccountNumber = accountNumber };
            db.CheckingAccounts.Add(checkingAccount);
            db.SaveChanges();

        }
    }
}