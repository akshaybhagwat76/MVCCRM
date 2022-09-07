//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Web.Optimization;
using System.Web.Optimization;

namespace MVCCRM.App_Start
{
        public class BundleConfig
        {
            // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
            public static void RegisterBundles(BundleCollection bundles)
            {
                bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery.min.js"));
                bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
        "~/Scripts/jquery.js"));
                bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
        "~/Scripts/bootstrap.js"));
                bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/site.css")
                .Include("~/Content/bootstrap.css"));
            //bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
            //    "~/Scripts/jquery-ui.min.js",
            //    "~/Scripts/bootstrap.bundle.min.js",
            //    "~/Scripts/metismenu.min.js",
            //    "~/Scripts/waves.js",
            //    "~/Scripts/feather.min.js",
            //    "~/Scripts/jquery.slimscroll.min.js",
            //    "~/plugins/apexcharts/apexcharts.min.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //        "~/Content/bootstrap.min.css",
            //        "~/Content/jquery-ui.min.css",
            //        "~/Content/icons.min.css",
            //        "~/Content/metisMenu.min.css",
            //        "~/Content/app.min.css"));
            }
        }
}
