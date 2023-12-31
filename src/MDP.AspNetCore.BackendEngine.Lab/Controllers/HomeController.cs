using Microsoft.AspNetCore.Mvc;
using System;

namespace MDP.AspNetCore.BackendEngine.Lab
{
    public class HomeController : Controller
    {
        // Methods
        public ActionResult Index()
        {
            // Return
            return View();
        }
    }
}
