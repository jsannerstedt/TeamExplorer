using System.Web.Optimization;

namespace TeamExplorer
{
    public static class ExtensionMethods
    {
        public static void EnableBootstrapBundle(this BundleCollection bundles)
        {
            var bootstrapCss = new Bundle("~/bootstrap/css", new CssMinify());
            bootstrapCss.AddFile("~/Content/bootstrap.css");
            bootstrapCss.AddFile("~/Content/bootstrap-responsive.css");
            bootstrapCss.AddFile("~/Content/custom.css");
            bundles.Add(bootstrapCss);

            
            var applicationCss = new Bundle("~/bootstrap/application/css", new CssMinify());
            applicationCss.AddFile("~/Content/application.css");
            bundles.Add(applicationCss);

            var bootstrapJs = new Bundle("~/bootstrap/js", new JsMinify());
            bootstrapJs.AddFile("~/Scripts/jquery-1.7.1.js");
            bootstrapJs.AddFile("~/Scripts/bootstrap-modal.js");
            bootstrapJs.AddFile("~/Scripts/jquery.validate.js");
            bootstrapJs.AddFile("~/Scripts/jquery.unobtrusive-ajax.js");
            bootstrapJs.AddFile("~/Scripts/jquery.validate.unobtrusive.js");
            //bootstrapJs.AddFile("~/js/prettify.js");

            bundles.Add(bootstrapJs);
        }
    }
}