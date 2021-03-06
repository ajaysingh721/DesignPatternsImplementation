﻿using System;
using DesignPatterns.Creational.FactoryMethod.Factory;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Creational.FactoryMethod.EmployeeManagerFactory
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(IEmployee emp)
        {
            BaseEmployeeFactory returnValue = null;
            if (emp.EmployeeTypeID == 1)
            {
                returnValue = new PermanentEmployeeFactory(emp);
            }
            else if (emp.EmployeeTypeID == 2)
            {
                returnValue = new ContractEmployeeFactory(emp);
            }
            return returnValue;
        }
        
    }
}
