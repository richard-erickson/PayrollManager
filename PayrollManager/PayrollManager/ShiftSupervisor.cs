using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManager
{
    public class ShiftSupervisor : Employee
    {
        protected double _annualSalary;
        protected double _annualBonus;

        public ShiftSupervisor(string employeeName, int employeeID, double annualSalary, double annualBonus)
                               : base(employeeName, employeeID)
        {
            if (annualSalary > 0 && annualBonus > 0 )
            {
                _annualSalary = annualSalary;
                _annualBonus = annualBonus;
            }
        }

        public double AnnualSalary
        {
            get { return _annualSalary; }
            set
            {
                if (value > 0)
                {
                    _annualSalary = value;
                }
            }
        }

        public double AnnualBonus
        {
            get { return _annualBonus; }
            set
            {
                if (value > 0)
                {
                    _annualBonus = value;
                }
            }
        }

        public override string ToString()
        {
            string shiftSupervisorString;

            shiftSupervisorString = base.ToString() + " Annual Salary: " + _annualSalary.ToString("c") +
                                        " Annual Bonus: " + _annualBonus.ToString("c");

            return shiftSupervisorString;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj) && (obj is ShiftSupervisor);
        }

        public override double GetMonthlyPay()
        {
            return _annualSalary / 12;
        }
    }
}
