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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            employeeIDTextBox.Clear();
            employeeNameTextBox.Clear();
        }
    }
}
