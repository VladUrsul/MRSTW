using System.Security.Cryptography;
using System.Web;
using System.Web.Optimization;
using System.Web.UI.WebControls;

namespace ElectronicsShop.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // Template integration
            bundles.Add(new StyleBundle("~/Content/style").Include(
                        "~/Content/css/style.css"));

            bundles.Add(new StyleBundle("~/Content/materialDesignIcons").Include(
                        "~/Content/vendors/mdi/css/materialdesignicons.min.css"));

            bundles.Add(new StyleBundle("~/Content/base").Include(
                        "~/Content/vendors/css/vendor.bundle.base.css"));

            bundles.Add(new Bundle("~/Content/js/base").Include(
                        "~/Content/vendors/js/vendor.bundle.base.js"));

            bundles.Add(new Bundle("~/Content/js/misc").Include(
                        "~/Content/js/misc.js"));
        }
    }
}