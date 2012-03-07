using System.Web.Mvc;
using TeamExplorer.Models;

namespace TeamExplorer.Controllers
{
    public class IssueController : DocumentController
    {
       
        [HttpPost]
        public ActionResult Create(Issue issue)
        {
            string imageData = Request.Form.Get("image");
            issue.Images.Add(imageData);
            DocumentSession.Store(issue);
            DocumentSession.SaveChanges();
            return RedirectToRoute("Charter", new {id = issue.CharterId});
        }

        public ActionResult Show(string id)
        {
            var issue = DocumentSession.Include<Issue>(x => x.CharterId).Load<Issue>(id);
            var charter = DocumentSession.Load<Charter>(issue.CharterId);
            return View(issue);
        }

        public ActionResult Form(string charterId)
        {
            return PartialView(new Issue { CharterId = charterId });
        }
    }
}