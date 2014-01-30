using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace TodoMVCKoDurandalBreeze
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                "~/Scripts/knockout-{version}.js",
                "~/Scripts/knockout.validation.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/app/ajaxPrefilters.js",
                "~/app/app.bindings.js",
                "~/app/app.datamodel.js",
                "~/app/app.viewmodel.js",
                "~/app/home.viewmodel.js",
                "~/app/login.viewmodel.js",
                "~/app/register.viewmodel.js",
                "~/app/registerExternal.viewmodel.js",
                "~/app/manage.viewmodel.js",
                "~/app/userInfo.viewmodel.js",
                "~/app/_run.js"));
            bundles.Add(new ScriptBundle("~/bundles/todoApp").Include(
                "~/app/todoApp/todoItem.js",
                "~/app/todoApp/todoViewModel.js",
                "~/app/todoApp/_run.js"));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                 "~/Content/bootstrap.css",
                 "~/Content/Site.css"));
            bundles.Add(new StyleBundle("~/Content/todoApp").Include(
                 "~/Content/todoApp.css"));
        }
    }
}
