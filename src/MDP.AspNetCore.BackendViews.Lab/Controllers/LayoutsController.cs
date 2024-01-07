using Microsoft.AspNetCore.Mvc;
using System;

namespace MDP.AspNetCore.BackendViews.Lab
{
    public partial class LayoutsController : Controller
    {
        // Methods
        public ActionResult Index()
        {
            // Return
            return RedirectToAction("Layout_1_1");
        }
    }

    public partial class LayoutsController : Controller
    {
        // Methods
        public ActionResult Layout_1_1()
        {
            // ViewBage
            this.ViewBag.ContentFixed = true;

            // Return
            return View();
        }

        public ActionResult Layout_1_2()
        {
            // ViewBage
            this.ViewBag.ContentFixed = true;

            // Return
            return View();
        }
    }

    public partial class LayoutsController : Controller
    {
        // Methods
        public ActionResult Layout_2_1()
        {
            // ViewBage
            this.ViewBag.ContentFixed = true;

            // Return
            return View();
        }

        public ActionResult Layout_2_2()
        {
            // ViewBage
            this.ViewBag.ContentFixed = true;

            // Return
            return View();
        }
    }

    public partial class LayoutsController : Controller
    {
        // Methods
        public ActionResult Layout_3_1()
        {
            // ViewBage
            this.ViewBag.ContentFixed = true;

            // Return
            return View();
        }

        public ActionResult Layout_3_2()
        {
            // ViewBage
            this.ViewBag.ContentFixed = true;

            // Return
            return View();
        }

        public ActionResult Layout_3_3()
        {
            // ViewBage
            this.ViewBag.ContentFixed = true;

            // Return
            return View();
        }

        public ActionResult Layout_3_4()
        {
            // ViewBage
            this.ViewBag.ContentFixed = true;

            // Return
            return View();
        }
    }

    public partial class LayoutsController : Controller
    {
        // Methods
        public ActionResult Layout_Flex()
        {
            // ViewBage
            this.ViewBag.ContentFixed = true;

            // Return
            return View();
        }
    }
}
