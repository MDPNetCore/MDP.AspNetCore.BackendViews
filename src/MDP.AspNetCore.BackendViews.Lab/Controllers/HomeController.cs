﻿using Microsoft.AspNetCore.Mvc;
using System;

namespace MDP.AspNetCore.BackendViews.Lab
{
    public partial class HomeController : Controller
    {
        // Methods
        public ActionResult Index()
        {
            // Return
            return RedirectToAction("Form_1", "Forms");
        }
    }
}
