/*
 * Class name: Employee
 * This class defines the Employee data-type
 * last modified September 23, 2025
 * author: Richard Erickson
 * rerickson0003@kctcs.edu
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManager
{
    //only an abstract class may contain an abstract method and it must be overwritten in any derived class following
    public abstract class Employee
    {
        protected string _employeeName;
        protected int _employeeID;

        public Employee(string employeeName, int employeeID)
        {
            if (employeeName.Trim().Length > 0 && employeeID > 0)
            {
                _employeeName = employeeName.Trim();
                _employeeID = employeeID;
            }
        }

        public string EmployeeName
        {
            get { return _employeeName; }
            set
            {
                if (value.Trim().Length > 0)
                { 
                    _employeeName = value.Trim();
                }
            }
        }

        public int EmployeeID
        {
            get 
            {  
                return _employeeID; 
            }
        }

        public override string ToString()
        {
            string employeeString;

            employeeString = "ID: " + _employeeID + " Name: " + _employeeName;

            return employeeString;
        }

        public override bool Equals(object? obj)
        {
            bool equalEmployees;
            //initialized as false
            equalEmployees = false;

            if (obj != null)
            {//This gives the method its own memory address
                if (obj == this)
                {
                    equalEmployees = true;
                }
                else
                {
                    if (obj is Employee)
                    {
                        if (_employeeID == ((Employee)obj)._employeeID)
                        {
                            equalEmployees = true;
                        }
                    }
                }
            }
            return equalEmployees;
        }

        public abstract double GetMonthlyPay();
    }
}
