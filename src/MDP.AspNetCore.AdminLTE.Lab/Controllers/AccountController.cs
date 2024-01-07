using Microsoft.AspNetCore.Mvc;

namespace MDP.AspNetCore.AdminLTE.Lab
{
    public partial class AccountController : Controller
    {
        // Methods
        public ActionResult Index()
        {
            // Return
            return RedirectToAction("Login");
        }
    }

    public partial class AccountController : Controller
    {
        // Methods
        public ActionResult Login()
        {
            // Return
            return View();
        }

        public ActionResult Logout()
        {
            // Return
            return RedirectToAction("Login");
        }

        public ActionResult Register()
        {
            // Return
            return View();
        }
    }
}
