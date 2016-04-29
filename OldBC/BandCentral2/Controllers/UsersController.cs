using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BandCentral.DAL;
using BandCentral.Models;

namespace BandCentral.Controllers
{
    public class UsersController : Controller
    {
        //private BandCentralContext db = new BandCentralContext();

        private IUserRepository userRepository;

        public UsersController()
        {
            this.userRepository = new UserRepository(new BandCentralContext());
        }
        // GET: Users
        public ActionResult Index()
        {
            return View(userRepository.GetUsers());
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            User user = userRepository.GetUserByID(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FirstName,LastName,Email")] User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    userRepository.InsertUser(user);
                    userRepository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                ModelState.AddModelError("", "Unable to save changes at this time. Please try again. If the problem persists, please contact an administrator");
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            User user = userRepository.GetUserByID(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = ("LastName,FirstName,Email"))]  User user)
        {
            //try
            //{
                userRepository.UpdateUser(user);
                userRepository.Save();
                return RedirectToAction("Index");
            //}
            //catch (DataException)
            //{
            //    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            //}
            //return View(user);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id = 0, bool? saveChangesError = false)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.errorMessage = "Delete Failed. Try again, and if the problem persists, see your system administrator.";
            }
            User user = userRepository.GetUserByID(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                userRepository.DeleteUser(id);
                userRepository.Save();
            }
            catch
            {
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                userRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
