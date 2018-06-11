using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Manager
{
    public class ContractEmployeeManager :IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 5;
        }

        public decimal GetMedicalAllowance()
        {
            return 1200;
        }

        public decimal GetPay()
        {
            return 12;
        }
    }
}
