using System.Web.Mvc;
using TeamExplorer.Models;

namespace TeamExplorer.Controllers
{
    public class CharterController : Controller
    {
        public ActionResult Index(int id)
        {

            return View(new Charter());
        }
    }
}