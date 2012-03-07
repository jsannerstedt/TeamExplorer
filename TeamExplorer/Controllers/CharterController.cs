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
    }

    public class CharterViewModel
    {
        public Charter Charter { get; set; }

        public IQueryable<Issue> Issues { get; set; }
    }
}