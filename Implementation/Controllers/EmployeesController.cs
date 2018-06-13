namespace Implementation.Controllers
{
    using System.Data.Entity;
    using System.Linq;
    using System.Net;
    using System.Web.Mvc;
    using Models;
    using DesignPatterns.Creational.FactoryMethod.Factory;
    using DesignPatterns.Creational.FactoryMethod.EmployeeManagerFactory;
    using DesignPatterns.Creational.AbstractFactory;
    using DesignPatterns.Creational.AbstractFactory.Manager;
    using DesignPatterns.Creational.AbstractFactory.ConcreteFactory;
    using DesignPatterns.Creational.Builder.IBuilder;
    using DesignPatterns.Creational.Builder.Director;
    using System;
    using DesignPatterns.Creational.Builder.Product;
    using DesignPatterns.Creational.Builder;
    using Services.Factory;

    public class EmployeesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ConfigureSystem
        [HttpGet]
        public ActionResult ConfigureSystem(int? id)
        {
            Employee employee = db.Employees.Find(id);
            ViewBag.JobDescription = employee.JobDescription;

            return View(id);
        }


        // POST: ConfigureSystem
        [HttpPost]
        public ActionResult ConfigureSystem(FormCollection formCollection)
        {
            //Step 1
            Employee employee = db.Employees.Find(Convert.ToInt32(formCollection["id"]));
            //Step 2 Concrete Builder
            ISystemBuilder systemBuilder = new SystemConfigutarionManagerFactory().GetSystemConfiguration(employee);
            //Step 3 Director
            SystemConfigurationBuilder builder = new SystemConfigurationBuilder();
            builder.BuildSystem(systemBuilder, formCollection);
            //Step 4 return the system
            ComputerSystem system = systemBuilder.GetSystem();
            employee.SystemConfigurationDetails = string.Format("RAM : {0}, HDDSize : {1}, Keyboard: {2}, Mouse : {3}", system.RAM, system.HDD, system.Keyboard, system.Mouse);
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Employees
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            ViewBag.TypeOfEmployees = db.EmployeeTypes.ToList();
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,JobDescription,Number,Department,HourlyPay,Bonus,EmployeeTypeID,HouseAllowance,MedicalAllowance")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                BaseEmployeeFactory empFactory = new EmployeeManagerFactory().CreateFactory(employee);
                empFactory.ApplySalary();
                IComputerFactory factory = new EmployeeSystemFactory().Create(employee);
                EmployeeSystemManager manager = new EmployeeSystemManager(factory);
                employee.ComputerDetails = manager.GetSystemDetails();

                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,JobDescription,Number,Department,HourlyPay,Bonus,EmployeeTypeID,HouseAllowance,MedicalAllowance")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                BaseEmployeeFactory empFactory = new EmployeeManagerFactory().CreateFactory(employee);
                empFactory.ApplySalary();
                IComputerFactory factory = new EmployeeSystemFactory().Create(employee);
                EmployeeSystemManager manager = new EmployeeSystemManager(factory);
                employee.ComputerDetails = manager.GetSystemDetails();

                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
