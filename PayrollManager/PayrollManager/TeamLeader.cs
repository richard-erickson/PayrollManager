using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManager
{
    public class TeamLeader : ProductionWorker
    {
        private double _monthlyBonus;
        private double _requiredTrainingHours;
        private double _completedTrainingHours;

        public TeamLeader(string employeeName, int employeeID, int Shift, double hourlyPayRate
                          ,double monthlyHoursWorked, double monthlyBonus, double requiredTrainingHours,
                           double completedTrainingHours) : 
                            base(employeeName, employeeID, Shift, hourlyPayRate, monthlyHoursWorked)
        {
            if (monthlyBonus > 0 && requiredTrainingHours > 0 && completedTrainingHours >= 0)
            {
                _monthlyBonus = monthlyBonus;
                _requiredTrainingHours = requiredTrainingHours;
                _completedTrainingHours = completedTrainingHours;
            }
        }

        public double MonthlyBonus
        {
            get { return _monthlyBonus; }
            set
            {
                if (value > 0)
                {
                    _monthlyBonus = value;
                }
            }
        }

        public double requiredTrainingHours
        {
            get { return _requiredTrainingHours; }
            set
            {
                if (value > 0)
                {
                    _requiredTrainingHours = value;
                }
            }
        }

        public double completedTrainingHours
        {
            get { return _completedTrainingHours; }
            set
            {
                if (value > 0)
                {
                    _completedTrainingHours = value;
                }
            }
        }

        public override string ToString()
        {
            string teamLeaderString;

            teamLeaderString = base.ToString() + ", Monthly bonus: " + _monthlyBonus.ToString("c") +
                                        " Required training hours: " + _requiredTrainingHours +
                                        " Completed training hours: " + _completedTrainingHours;

            return teamLeaderString;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj) && (obj is TeamLeader);
        }

        public override double GetMonthlyPay()
        {
            return base.GetMonthlyPay() + _monthlyBonus;
        }

    }
}
