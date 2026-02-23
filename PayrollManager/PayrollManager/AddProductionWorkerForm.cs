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
    public partial class AddProductionWorkerForm : AddEmployeeForm
    {
        protected List<Employee> employeeList;
        public AddProductionWorkerForm(List<Employee> employeeList)
        {
            InitializeComponent();
            this.employeeList = employeeList;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        protected virtual void clearButton_Click(object sender, EventArgs e)
        {
            shiftTextBox.Clear();
            hourlyPayRateTextBox.Clear();
            monthlyHoursWorkedTextBox.Clear();

            employeeIDTextBox.Focus();

        }

        protected virtual void addButton_Click(object sender, EventArgs e)
        {
            int employeeID;
            string employeeName;
            int shift;
            double hourlyPay;
            double monthlyHoursWorked;

            if (int.TryParse(employeeIDTextBox.Text.Trim(), out employeeID) &&
                employeeNameTextBox.Text.Trim().Length > 0 &&
                int.TryParse(shiftTextBox.Text.Trim(), out shift) &&
                double.TryParse(hourlyPayRateTextBox.Text.Trim(), out hourlyPay) &&
                double.TryParse(monthlyHoursWorkedTextBox.Text.Trim(), out monthlyHoursWorked))
            {
                employeeName = employeeNameTextBox.Text.Trim();
                employeeList.Add(new ProductionWorker(employeeName, employeeID, shift, hourlyPay, monthlyHoursWorked));
            }
        }
    }
}
