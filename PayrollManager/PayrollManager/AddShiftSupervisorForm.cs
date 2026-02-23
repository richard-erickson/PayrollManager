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
    public partial class AddShiftSupervisorForm : AddEmployeeForm
    {
        private List<Employee> employeeList;
        public AddShiftSupervisorForm(List<Employee> employeeList)
        {
            InitializeComponent();
            this.employeeList = employeeList;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            annualSalaryTextBox.Clear();
            annualBonusTextBox.Clear();

            employeeIDTextBox.Focus();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int employeeID;
            string employeeName;
            double annualSalary;
            double annualBonus;

            if (int.TryParse(employeeIDTextBox.Text.Trim(), out employeeID) &&
                employeeNameTextBox.Text.Trim().Length > 0 &&
                double.TryParse(annualSalaryTextBox.Text.Trim(), out annualSalary) &&
                double.TryParse(annualBonusTextBox.Text.Trim(), out annualBonus))
            {
                employeeName = employeeNameTextBox.Text.Trim();
                employeeList.Add(new ShiftSupervisor(employeeName, employeeID, annualSalary, annualBonus));
            }
            
        }
    }
}
