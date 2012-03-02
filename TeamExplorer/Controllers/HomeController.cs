using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TeamExplorer.Models;

namespace TeamExplorer.Controllers
{
    public class HomeController : DocumentController
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            // Create the first session if it doensn't exists 
            //var session = DocumentSession.Load<Session>(1);
            //if (session == null)
            //{
            //    DocumentSession.Store(new Session { Date = DateTime.Now, Id = 1337});
            //    DocumentSession.SaveChanges();
            //}
            //var session = DocumentSession.Query<Session>().FirstOrDefault(x => x.Id == 1337);
            //// Create the first charter if it doensn't exists 
            //var charter = DocumentSession.Load<Charter>(1);
            //if (charter == null)
            //{
            //    DocumentSession.Store(new Charter {Title = "Raven charter...", Session = session});
            //    DocumentSession.SaveChanges();
            //}

            IEnumerable<Charter> charters = DocumentSession.Query<Charter>();
            return View(charters);
        }
    }
}