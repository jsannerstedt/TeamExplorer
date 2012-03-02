using System;
using System.Collections.Generic;
using System.Linq;
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
            // Create the first session if it doensn't exists 
            var session = DocumentSession.Load<Session>(1);
            if (session == null)
            {
                DocumentSession.Store(new Session { Date = DateTime.Now });
                DocumentSession.SaveChanges();
                session = DocumentSession.Query<Session>().FirstOrDefault(x => x.Id == 1);

            }
            // Create the first charter if it doensn't exists 
            var charter = DocumentSession.Load<Charter>(1);
            if (charter == null)
            {
                DocumentSession.Store(new Charter { Title = "Raven charter...", Session = session,IsActive = true});
                DocumentSession.SaveChanges();
            }

            //IEnumerable<Charter> charters = DocumentSession.Query<Charter>();
            IEnumerable<Charter> charters = Query(new ActiveCharters());
            return View(charters);
        }
    }
}
