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

    public class ApplicationContextSeedInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            Employee_Type type1 = new Employee_Type()
            {
                EmployeeType = "Peremanent Employee"
            };

            Employee_Type type2 = new Employee_Type()
            {
                EmployeeType = "Contract Employee"
            };

            context.EmployeeTypes.Add(type1);
            context.EmployeeTypes.Add(type2);
            context.SaveChanges();
        }
    }
}
