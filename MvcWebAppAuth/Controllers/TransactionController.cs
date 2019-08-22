using Microsoft.AspNet.Identity;
using MvcWebAppAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebAppAuth.Controllers
{
    //[Authorize]
    public class TransactionController : Controller
    {
        // GET: Transaction
        //public ActionResult Index()
        //{
        //    List<Transaction> transactions = new List<Transaction>();
        //    var Id = User.Identity.GetUserId();

        //    var db = new ApplicationDbContext();
        //    var user =db.Users.Find(Id);

        //    //var checkingAccount = db.CheckingAccounts.Find(user.);

        //    var Trans = db.Transactions.Find(checkingAccount.Id);
        //    return View(Trans);
        //}

        // GET: Transaction/Details/5
        //public ActionResult Deposit(int checkingAccountid)
        //{
        //    return View();
        //}

        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Transaction/Create
        public ActionResult Create(int checkingAccountId)
        {
            
            return View();
        }

        // POST: Transaction/Create
        [HttpPost]
        public ActionResult Create(Transaction transaction)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    if(Request.IsAuthenticated)
                    {
                        Transaction tran = new Transaction {  Amount=transaction.Amount, CheckingAccountId=transaction.CheckingAccountId};
                        db.Transactions.Add(tran);
                        db.SaveChanges();
                    }
                }
                ViewBag.CheckingAccountid = transaction.CheckingAccountId;
                    return RedirectToAction("Index","Home");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Transaction/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Transaction/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Transaction/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Transaction/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
