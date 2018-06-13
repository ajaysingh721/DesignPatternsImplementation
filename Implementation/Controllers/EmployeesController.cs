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
    using Services.Builder;

    public class EmployeesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BuildSystem
        [HttpGet]
        public ActionResult BuildSystem(int? id)
        {
            return View(id);
        }


        // GET: BuildSystem
        [HttpPost]
        public ActionResult BuildSystem(int id, string RAM, string HDD)
        {
            Employee employee = db.Employees.Find(id);
            ComputerSystem computerSystem = new ComputerSystem(RAM, HDD);
            employee.SystemConfigurationDetails = computerSystem.Build();
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
