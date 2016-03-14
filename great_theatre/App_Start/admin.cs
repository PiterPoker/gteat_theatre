using System.Web.Optimization;

namespace great_theatre
{
    public class Admin
    {
         
        //Дополнительные сведения об объединении см. по адресу: http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection admins)
        {
            admins.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            admins.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Используйте версию Modernizr для разработчиков, чтобы учиться работать. Когда вы будете готовы перейти к работе,
            // используйте средство сборки на сайте http://modernizr.com, чтобы выбрать только нужные тесты.
            admins.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            admins.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            admins.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/admin.css",
                      "~/Content/lines.css",
                      "~/Content/clndr.css",
                      "~/Content/custom.css",
                      "~/Content/font-awesome.css",
                      "~/Content/jqvmap.css"));
        }
    }
}