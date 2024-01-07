using Microsoft.AspNetCore.Mvc;

namespace MDP.AspNetCore.AdminLTE.Lab
{
    public partial class LayoutController : Controller
    {
        // Methods
        public ActionResult Index()
        {
            // Return
            return RedirectToAction("Layout_3_1");
        }
    }

    public partial class LayoutController : Controller
    {
        // Methods
        public ActionResult Layout_3_1()
        {
            // Return
            return View();
        }

        public ActionResult Layout_3_2()
        {
            // Return
            return View();
        }

        public ActionResult Layout_3_3()
        {
            // Return
            return View();
        }

        public ActionResult Layout_3_4()
        {
            // Return
            return View();
        }
    }

    public partial class LayoutController : Controller
    {
        // Methods
        public ActionResult Layout_2_1()
        {
            // Return
            return View();
        }

        public ActionResult Layout_2_2()
        {
            // Return
            return View();
        }
    }

    public partial class LayoutController : Controller
    {
        // Methods
        public ActionResult Layout_1_1()
        {
            // Return
            return View();
        }

        public ActionResult Layout_1_2()
        {
            // Return
            return View();
        }
    }

    public partial class LayoutController : Controller
    {
        // Methods
        public ActionResult Layout_Flex()
        {
            // Return
            return View();
        }
    }
}
