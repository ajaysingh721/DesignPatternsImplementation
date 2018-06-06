using DesignPatterns.Creational.Singleton;
using System.Web.Mvc;

namespace Implementation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILog _ILog;

        public HomeController()
        {
            _ILog = Log.GetInstance;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            _ILog.Error(filterContext.Exception.ToString());
            filterContext.ExceptionHandled = true;
            this.View("Error").ExecuteResult(this.ControllerContext);
        }
    }
}