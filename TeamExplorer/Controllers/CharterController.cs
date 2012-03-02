using System.Web.Mvc;
using TeamExplorer.Models;

namespace TeamExplorer.Controllers
{
    public class CharterController : DocumentController
    {
        public ActionResult Index(int id)
        {
            var charter = DocumentSession.Load<Charter>(id);
            return View(charter);
        }
    }
}