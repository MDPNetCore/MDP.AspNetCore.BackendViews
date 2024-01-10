using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Cryptography;

namespace MDP.AspNetCore.BackendViews.Lab
{
    public partial class AuthController : Controller
    {
        // Methods
        public ActionResult Index()
        {
            // Return
            return RedirectToAction("Login");
        }
    }

    public partial class AuthController : Controller
    {
        // Methods
        public ActionResult Login()
        {
            // ViewBage
            this.ViewBag.HeaderHidden = true;

            // Return
            return View();
        }

        public ActionResult Register()
        {
            // ViewBage
            this.ViewBag.HeaderHidden = true;

            // Return
            return View();
        }
    }

    public partial class AuthController : Controller
    {
        // Methods
        public ActionResult NotFound404()
        {
            // ViewBage
            this.ViewBag.HeaderHidden = true;

            // Return
            return View();
        }

        public ActionResult ServerError500()
        {
            // ViewBage
            this.ViewBag.HeaderHidden = true;

            // Return
            return View();
        }

        public ActionResult AccessDenied403()
        {
            // ViewBage
            this.ViewBag.HeaderHidden = true;

            // Return
            return View();
        }
    }
}
