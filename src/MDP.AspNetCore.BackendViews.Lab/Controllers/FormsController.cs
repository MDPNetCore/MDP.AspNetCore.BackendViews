using Microsoft.AspNetCore.Mvc;
using System;

namespace MDP.AspNetCore.BackendViews.Lab
{
    public partial class FormsController : Controller
    {
        // Methods
        public ActionResult Index()
        {
            // Return
            return RedirectToAction("Form_1");
        }
    }

    public partial class FormsController : Controller
    {
        // Methods
        public ActionResult Form_1()
        {
            // Return
            return View();
        }

        public ActionResult Form_2()
        {
            // Return
            return View();
        }
    }
}
