using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewCoreApplication.Controllers
{
    public class FeedbackFormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
