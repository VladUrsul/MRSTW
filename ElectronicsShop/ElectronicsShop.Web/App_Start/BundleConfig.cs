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
            bundles.Add(new ScriptBundle("~/Areas/AdminPanel/bundles/jquery").Include(
                        "~/Areas/AdminPanel/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/Areas/AdminPanel/bundles/jqueryval").Include(
                        "~/Areas/AdminPanel/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/Areas/AdminPanel/bundles/modernizr").Include(
                        "~/Areas/AdminPanel/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/Areas/AdminPanel/bundles/bootstrap").Include(
                      "~/Areas/AdminPanel/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Areas/AdminPanel/Content/bootstrap.css",
                      "~/Areas/AdminPanel/Content/site.css"));

            // Template integration
            bundles.Add(new StyleBundle("~/Areas/AdminPanel/Content/style").Include(
                        "~/Areas/AdminPanel/Content/css/style.css"));

            bundles.Add(new StyleBundle("~/Areas/AdminPanel/Content/materialDesignIcons").Include(
                        "~/Areas/AdminPanel/Content/vendors/mdi/css/materialdesignicons.min.css"));

            bundles.Add(new StyleBundle("~/Areas/AdminPanel/Content/base").Include(
                        "~/Areas/AdminPanel/Content/vendors/css/vendor.bundle.base.css"));

            bundles.Add(new Bundle("~/Areas/AdminPanel/Content/js/base").Include(
                        "~/Areas/AdminPanel/Content/vendors/js/vendor.bundle.base.js"));

            bundles.Add(new Bundle("~/Areas/AdminPanel/Content/js/misc").Include(
                        "~/Areas/AdminPanel/Content/js/misc.js"));
        }
    }
}