using System.Web.Mvc;
using TeamExplorer.Models;
using TeamExplorer.Queries;

namespace TeamExplorer.Controllers
{
    public class ChromeController : DocumentController
    {
        public ActionResult Index()
        {
            var charters = Query(new ActiveCharters());
            return View(charters);
        }

        public ActionResult Explore(string id)
        {
            var charter = DocumentSession.Load<Charter>(id);
            return View(charter);
        }
    }
}
