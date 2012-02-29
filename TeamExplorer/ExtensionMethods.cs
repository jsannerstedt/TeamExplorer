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
            

            bundles.Add(bootstrapCss);

            //var bootstrapJs = new Bundle("~/bootstrap/js", new JsMinify());
            //bootstrapJs.AddFile("~/js/jquery-1.7.1.js");
            //bootstrapJs.AddFile("~/js/bootstrap.js");
            //bootstrapJs.AddFile("~/js/prettify.js");

            //bundles.Add(bootstrapJs);
        }
    }
}