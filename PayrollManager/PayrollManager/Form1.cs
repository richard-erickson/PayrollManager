using System.Numerics;

namespace PayrollManager
{
    public partial class Form1 : Form
    {
        private AddProductionWorkerForm addProductionWorkerForm;
        private AddShiftSupervisorForm addShiftSupervisorForm;
        private AddTeamLeaderForm addTeamLeaderForm;
        private List<Employee> employeeList;
        public Form1()
        {
            InitializeComponent();
            employeeList = new List<Employee>();
            addProductionWorkerForm = new AddProductionWorkerForm(employeeList);
            addShiftSupervisorForm = new AddShiftSupervisorForm(employeeList);
            addTeamLeaderForm = new AddTeamLeaderForm(employeeList);           
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            /*
            Employee[] employees = new Employee[5]; //this is a polymorphic array -- it can store objects of all derived classes
                                                    //of Employee in this array
            employees[0] = new ProductionWorker("Jordan", 100, 1, 30.95, 100);
            employees[1] = new ShiftSupervisor("Jarred", 200, 100_000, 20_000);
            employees[2] = new TeamLeader("Richard", 300, 3, 40.95, 1_000, 15, 5, 100);
            employees[3] = new ProductionWorker("Navin", 101, 2, 29.95, 98.7);
            employees[4] = new ShiftSupervisor("Jarred", 200, 100_000, 20_000);
            //writing polymorphic code that accesses properties of all objects in the polymorphic array
            for (int i = 0; i < 4; i++)
            {
                outputListBox.Items.Add(employees[i].EmployeeName);
                outputListBox.Items.Add(employees[i].EmployeeID);
                //This if statement is required to make the typecast work
                if (employees[i] is ProductionWorker)
                {   //The  "()" around "(ProductionWorker)employees[i]" ensures that the typecast to array happens first
                    outputListBox.Items.Add("Shift: " + ((ProductionWorker)employees[i]).Shift);
                }

                outputListBox.Items.Add(employees[i].ToString());
                outputListBox.Items.Add("Monthly pay: " + employees[i].GetMonthlyPay().ToString("c"));
                //if you add another class for another employee type, as long as you override the "ToString()"
                //and "GetMonthlyPay()" methods, it work for those as well
            }

            if (employees[1].Equals(employees[4]))
            {
                outputListBox.Items.Add("Identical employees!");
            }
            else
            {
                outputListBox.Items.Add("Not identical employees!");
            }
            */
            //above code commented out and replace by the following for loop

            for (int i = 0;i < employeeList.Count;i++)
            {
                outputListBox.Items.Add(employeeList[i].ToString());
            }

            if (employeeList.Contains(new ShiftSupervisor("Jarred", 200, 100_000, 200_000)))
            {
                outputListBox.Items.Add("Found that shift supervisor!");
            }
            else
            {
                outputListBox.Items.Add("Did not find that shift supervisor!");
            }
        }

        private void addProductionWorkerButton_Click(object sender, EventArgs e)
        {
            addProductionWorkerForm.ShowDialog();
        }

        private void addShiftSupervisorButton_Click(object sender, EventArgs e)
        {
            addShiftSupervisorForm.ShowDialog();
        }

        private void addTeamLeaderButton_Click(object sender, EventArgs e)
        {
            addTeamLeaderForm.ShowDialog();
        }
    }
}
