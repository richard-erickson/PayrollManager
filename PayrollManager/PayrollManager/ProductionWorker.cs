/*
 * Class name: ProductionWorker
 * This class defines the ProductionWorker data-type.This is a derived class of Employee
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
    public class ProductionWorker : Employee
    {
        protected int _shift;
        protected double _hourlyPayRate;
        protected double _monthlyHoursWorked;

        public ProductionWorker(string employeeName, int employeeID, int Shift, double hourlyPayRate,
                                double monthlyHoursWorked) : 
                                base(employeeName, employeeID)
        {
            if (Shift > 0 && hourlyPayRate > 0 && monthlyHoursWorked > 0)
            {
                _shift = Shift;
                _hourlyPayRate = hourlyPayRate;
                _monthlyHoursWorked = monthlyHoursWorked;
            }
        }

        public int Shift
        {
            get { return _shift; }
            set
            {
                if (value > 0)
                {
                    _shift = value;
                }
            }
        }

        public double HourlyPayRate
        {
            get { return _hourlyPayRate; }
            set
            {
                if (value > 0)
                {
                    _hourlyPayRate = value;
                }
            }
        }

        public double monthlyHoursWorked
        {
            get { return _monthlyHoursWorked; }
            set
            {
                if (value > 0)
                {
                    _monthlyHoursWorked = value;
                }
            }
        }

        public override string ToString()
        {
            string productionWorkerString;

            productionWorkerString = base.ToString() + " Shift: " + _shift +
                                        " Hourly pay rate: " + _hourlyPayRate.ToString("c") +
                                        " Monthly hours worked: " + monthlyHoursWorked;

            return productionWorkerString;
        }

        public override bool Equals(object? obj)
        {//This returns what we did in the Employee class and sets the checked object as the current class'
            return base.Equals(obj) && (obj is ProductionWorker);
        }

        public override double GetMonthlyPay()
        {
            return _monthlyHoursWorked * _hourlyPayRate;
        }

    }
}
