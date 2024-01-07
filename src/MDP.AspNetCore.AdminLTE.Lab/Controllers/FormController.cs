using Microsoft.AspNetCore.Mvc;

namespace MDP.AspNetCore.AdminLTE.Lab
{
    public partial class FormController : Controller
    {
        // Methods
        public ActionResult Index()
        {
            // Return
            return RedirectToAction("Form_1_1");
        }
    }

    public partial class FormController : Controller
    {
        // Methods
        public ActionResult Form_1_1()
        {
            // Return
            return View();
        }

        public ActionResult Form_1_2()
        {
            // Return
            return View();
        }

        public ActionResult Form_2_1()
        {
            // Return
            return View();
        }

        public ActionResult Form_2_2()
        {
            // Return
            return View();
        }
    }
}
