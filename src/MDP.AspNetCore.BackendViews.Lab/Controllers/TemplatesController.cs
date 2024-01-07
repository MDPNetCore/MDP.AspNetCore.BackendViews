using Microsoft.AspNetCore.Mvc;
using System;

namespace MDP.AspNetCore.BackendViews.Lab
{
    public partial class TemplatesController : Controller
    {
        // Methods
        public ActionResult Index()
        {
            // Return
            return RedirectToAction("Default");
        }
    }

    public partial class TemplatesController : Controller
    {
        // Methods
        public ActionResult Default()
        {
            // Return
            return View();
        }

        public ActionResult Blank()
        {
            // ViewBage
            this.ViewBag.HeaderHidden = true;

            // Return
            return View();
        }
    }
}
