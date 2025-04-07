using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ex3_ASPNETWebAppMVCStudentApp.Models;

namespace Ex3_ASPNETWebAppMVCStudentApp.Controllers
{
    public class AccountController : Controller
    {
        private Lab6_Ex3Entities db = new Lab6_Ex3Entities();
        public ActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var user = db.tblUsers.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null && user.IsActive == true)
            {
                Session["Username"] = user.Username;
                return RedirectToAction("Index", "Students"); // Redirect to your main page
            }

            ViewBag.Error = "Invalid username or password.";
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}