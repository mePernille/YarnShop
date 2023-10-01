using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace YarnShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // den returnerer den index fil som ligger i views mappen
        }
    }
}
