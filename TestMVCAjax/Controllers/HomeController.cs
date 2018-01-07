using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVCAjax.Models;

namespace TestMVCAjax.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string filter)
        {
            ViewBag.filter = filter;
            return View();
        }

        public ActionResult GetProgrammers(string filter = null)
        {
            IEnumerable<Programmer> programmers = new []
            {
                new Programmer {Id = 1, Name = "Konstantin" },
                new Programmer {Id = 2, Name = "Alves" },
                new Programmer {Id = 3, Name = "Scott" },
                new Programmer {Id = 4, Name = "Tray" },
                new Programmer {Id = 5, Name = "Vasya" },    
            };

            return View("_TableProgrammer",filter == null ? programmers : programmers.Where(x => x.Name.Contains(filter)));
        }
    }
}