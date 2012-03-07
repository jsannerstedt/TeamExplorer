using System.Linq;
using System.Web.Mvc;
using TeamExplorer.Models;

namespace TeamExplorer.Controllers
{
    public class CharterController : DocumentController
    {
        public ActionResult Index(string id)
        {
            var charterViewModel = new CharterViewModel();
        
            var charter = DocumentSession.Load<Charter>(id);
            IQueryable<Issue> issues = DocumentSession.Query<Issue>().Where(i => i.CharterId == charter.Id);

            charterViewModel.Charter = charter;
            charterViewModel.Issues = issues;
            return View(charterViewModel);
        }

        public ActionResult Create(Charter charter)
        {
            DocumentSession.Store(charter);
            DocumentSession.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Form()
        {
            return PartialView("Form", new Charter{IsActive = true});
        }
    }

    public class CharterViewModel
    {
        public Charter Charter { get; set; }

        public IQueryable<Issue> Issues { get; set; }
    }
}