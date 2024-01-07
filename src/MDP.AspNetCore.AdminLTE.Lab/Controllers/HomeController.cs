using Microsoft.AspNetCore.Mvc;

namespace MDP.AspNetCore.AdminLTE.Lab
{
    public partial class HomeController : Controller
    {
        // Methods
        public ActionResult Index()
        {
            // Return
            return RedirectToAction("List", "Crud");
        }
    }

    public partial class HomeController : Controller
    {
        // Methods
        
    }
}
