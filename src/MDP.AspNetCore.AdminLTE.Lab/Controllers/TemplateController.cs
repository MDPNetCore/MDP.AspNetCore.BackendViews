using Microsoft.AspNetCore.Mvc;

namespace MDP.AspNetCore.AdminLTE.Lab
{
    public partial class TemplateController : Controller
    {
        // Methods
        public ActionResult Index()
        {
            // Return
            return RedirectToAction("Template_Default");
        }
    }

    public partial class TemplateController : Controller
    {
        // Methods
        public ActionResult Template_Default()
        {
            // Return
            return View("Template_Default");
        }

        public ActionResult Template_Basic()
        {
            // Return
            return View("Template_Basic");
        }
    }
}
