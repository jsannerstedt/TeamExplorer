using System.Web.Mvc;
using Raven.Client;
using TeamExplorer.Queries;

namespace TeamExplorer.Controllers
{
    public abstract class DocumentController : Controller
    {
        public static IDocumentStore DocumentStore
        {
            get { return MvcApplication.DocumentStore; }
        }

        public IDocumentSession DocumentSession { get; protected set; }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            DocumentSession = DocumentStore.OpenSession();
        }

        protected TResult Query<TResult>(Query<TResult> query)
        {
            query.Session = DocumentSession;
            return query.Execute();
        }


        // TODO: Consider re-applying https://github.com/ayende/RaccoonBlog/commit/ff954e563e6996d44eb59a28f0abb2d3d9305ffe
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.IsChildAction)
                return;

            CompleteSessionHandler(filterContext);
        }

        protected void CompleteSessionHandler(ActionExecutedContext filterContext)
        {
            using (DocumentSession)
            {
                if (filterContext.Exception != null)
                    return;

                if (DocumentSession != null)
                    DocumentSession.SaveChanges();
            }

            //TaskExecutor.StartExecuting();
        }
    }
}