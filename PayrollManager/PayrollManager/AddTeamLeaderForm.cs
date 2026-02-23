using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollManager
{
    public partial class AddTeamLeaderForm : AddProductionWorkerForm
    {
        public AddTeamLeaderForm(List<Employee> employeeList) : base(employeeList)
        {
            InitializeComponent();
        }

        protected override void clearButton_Click(object sender, EventArgs e)
        {
            shiftTextBox.Clear();
            hourlyPayRateTextBox.Clear();
            monthlyHoursWorkedTextBox.Clear();
            monthlyBonusTextBoxButton.Clear();
            requiredHoursTextBox.Clear();
            completedHoursTextBox.Clear();

            employeeIDTextBox.Focus();
        }


        protected override void addButton_Click(object sender, EventArgs e)
        {
            int employeeID;
            string employeeName;
            int shift;
            double hourlyPay;
            double monthlyHoursWorked;
            double monthlyBonus;
            double requiredTrainingHours;
            double completedTrainingHours;

            if (int.TryParse(employeeIDTextBox.Text.Trim(), out employeeID) &&
                employeeNameTextBox.Text.Trim().Length > 0 &&
                int.TryParse(shiftTextBox.Text.Trim(), out shift) &&
                double.TryParse(hourlyPayRateTextBox.Text.Trim(), out hourlyPay) &&
                double.TryParse(monthlyHoursWorkedTextBox.Text.Trim(), out monthlyHoursWorked) &&
                double.TryParse(monthlyBonusTextBoxButton.Text.Trim(), out monthlyBonus) &&
                double.TryParse(requiredHoursTextBox.Text.Trim(), out requiredTrainingHours) &&
                double.TryParse(completedHoursTextBox.Text.Trim(), out completedTrainingHours))
            {
                employeeName = employeeNameTextBox.Text.Trim();
                employeeList.Add(new TeamLeader(employeeName, employeeID, shift, hourlyPay, monthlyHoursWorked,
                                    monthlyBonus, requiredTrainingHours, completedTrainingHours));
            }
        }
    }
}
