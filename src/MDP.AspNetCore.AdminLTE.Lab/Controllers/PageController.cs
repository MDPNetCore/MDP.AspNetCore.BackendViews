using Microsoft.AspNetCore.Mvc;

namespace MDP.AspNetCore.AdminLTE.Lab
{
    public partial class PageController : Controller
    {
        // Methods
        public ActionResult Index()
        {
            // Return
            return RedirectToAction("Chat");
        }
    }

    public partial class PageController : Controller
    {
        // Methods
        public ActionResult Chat()
        {
            // Return
            return View();
        }
    }
}
