using System;
using System.IO;
using System.Web;
using System.Web.Optimization;

namespace IAMCandidateTest
{
    public class Global : HttpApplication
    {
        private void Application_Start(object sender, EventArgs e)
        {
            // Override |DataDirectory| to use a location outside of the application directory.
            string dataDirectory = Path.GetFullPath(Path.Combine(Server.MapPath("~/"), @"..\..\data"));
            AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectory);

            // Code that runs on application startup
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
