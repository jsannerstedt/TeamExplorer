using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamExplorer.Models;
using TeamExplorer.Queries;

namespace TeamExplorer.Controllers
{
    public class HomeController : DocumentController
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            /* Create the first charter if it doensn't exists */
            var charter = DocumentSession.Load<Charter>(1);
            if (charter == null)
            {
                DocumentSession.Store(new Charter {Title = "Raven charter..."});
                DocumentSession.SaveChanges();
            }

            // IEnumerable<Charter> charters = DocumentSession.Query<Charter>();
            IEnumerable<Charter> charters = Query(new ActiveCharters());
            return View(charters);
        }

    }
}
