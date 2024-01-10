using Microsoft.AspNetCore.Mvc;

namespace MDP.AspNetCore.AdminLTE.Lab
{
    public partial class CrudController : Controller
    {
        // Methods
        public ActionResult Index()
        {
            // Return
            return RedirectToAction("List");
        }
    }

    public partial class CrudController : Controller
    {
        // Methods
        public ActionResult List()
        {
            // Return
            return View();
        }

        public ActionResult Add()
        {
            // Return
            return View();
        }

        public ActionResult Update()
        {
            // Return
            return View();
        }

        public ActionResult Remove()
        {
            // Return
            return View();
        }

        public ActionResult Detail()
        {
            // Return
            return View();
        }
    }
}
