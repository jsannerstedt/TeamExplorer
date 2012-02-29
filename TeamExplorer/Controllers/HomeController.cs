using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamExplorer.Models;

namespace TeamExplorer.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            IEnumerable<Charter> charters = new[] {new Charter{Title = "My charter", Id = 1}};

            return View(charters);
        }

    }
}
