using Implementation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Implementation
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer<ApplicationDbContext>(new ApplicationContextSeedInitializer());
        }
    }

    public class ApplicationContextSeedInitializer :  DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            EmployeeType type1 = new EmployeeType()
            {
                TypeOfEmployee = "Peremanent Employee"
            };

            EmployeeType type2 = new EmployeeType()
            {
                TypeOfEmployee = "Contract Employee"
            };

            context.EmployeeTypes.Add(type1);
            context.EmployeeTypes.Add(type2);
            context.SaveChanges();
        }
    }
}
