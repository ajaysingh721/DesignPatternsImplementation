using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    class Employee
    {
        public int ID { get; set; }
        public string EmpName { get; set; }
        public Address EmpAddress { get; set; }


        #region "Copy Methods"
        public Employee ShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }

        public Employee DeepCopy()
        {
            Employee employee = (Employee)this.MemberwiseClone();
            employee.EmpAddress = new Address(EmpAddress.DoorNumber,
            this.EmpAddress.StreetNumber, this.EmpAddress.Zipcode,
            this.EmpAddress.Country);

            return employee;
        }

        public override string ToString()
        {
            return string.Format("Emp ID :{0}, Emp Name : {1}, {2}",
                this.ID, this.EmpName, this.EmpAddress.ToString());
        }
        #endregion
    }
}
