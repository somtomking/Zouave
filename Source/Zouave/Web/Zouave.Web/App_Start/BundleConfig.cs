using System.Web;
using System.Web.Optimization;

namespace Zouave.Web
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            /*admin bundles start */

            //ScriptBundle

     

            bundles.Add(new ScriptBundle("~/bundles/admin_jq").Include(
                     "~/Areas/Admin/Content/AceAmdin/assets/js/jquery.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/admin_jq_ie").Include(
                     "~/Areas/Admin/Content/AceAmdin/assets/js/jquery1x.min.js"));


             bundles.Add(new ScriptBundle("~/bundles/admin_js_ie").Include(
                     "~/Areas/Admin/Content/AceAmdin/assets/js/html5shiv.js",
                     "~/Areas/Admin/Content/AceAmdin/assets/js/respond.min.js"
                     ));

             bundles.Add(new ScriptBundle("~/bundles/admin_jq_mobile").Include(
            "~/Areas/Admin/Content/AceAmdin/assets/js/jquery.mobile.custom.min.js"));

            //StyleBundle
            bundles.Add(new StyleBundle("~/Content/admin_css").Include(
              "~/Areas/Admin/Content/AceAmdin/assets/css/bootstrap.min.css",
              "~/Areas/Admin/Content/AceAmdin/assets/css/font-awesome.min.css",
              "~/Areas/Admin/Content/AceAmdin/assets/css/ace-fonts.css",
              "~/Areas/Admin/Content/AceAmdin/assets/css/ace.min.css",
              "~/Areas/Admin/Content/AceAmdin/assets/css/ace-rtl.min.css",
              "~/Areas/Admin/Content/AceAmdin/assets/css/ace.onpage-help.css"
              ));
                bundles.Add(new StyleBundle("~/Content/admin_css_ie").Include(
              "~/Areas/Admin/Content/AceAmdin/assets/css/ace-part2.min.css",
              "~/Areas/Admin/Content/AceAmdin/assets/css/ace-ie.min.css"
           
            
              ));

            /*admin bundles end! */


            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // 将 EnableOptimizations 设为 false 以进行调试。有关详细信息，
            // 请访问 http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }
    }
}
