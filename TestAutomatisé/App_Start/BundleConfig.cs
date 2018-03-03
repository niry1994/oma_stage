using System.Web;
using System.Web.Optimization;

namespace TestAutomatisé
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                         "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/w3.js").Include(
                       "~/Scripts/w3.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery-1.9.1.min.js").Include(
                      "~/Scripts/jquery-1.9.1.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery-1.6.3.min.js").Include(
                      "~/Scripts/jquery-1.6.3.min.js"));
          


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/w3.css").Include("~/Content/w3.css"));
            bundles.Add(new StyleBundle("~/Content/Login.css").Include("~/Content/Login.css"));
            bundles.Add(new StyleBundle("~/Content/Registre.css").Include("~/Content/Registre.css"));
            bundles.Add(new StyleBundle("~/Content/w3Pro.css").Include("~/Content/w3Pro.css"));
            bundles.Add(new StyleBundle("~/Content/Start.css").Include("~/Content/Start.css"));
            bundles.Add(new StyleBundle("~/Content/animate.css").Include("~/Content/animate.css"));

        }
    }
}
