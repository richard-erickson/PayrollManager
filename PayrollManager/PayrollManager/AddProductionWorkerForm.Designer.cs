namespace PayrollManager
{
    partial class AddProductionWorkerForm : AddEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            shiftTextBox = new TextBox();
            hourlyPayRateTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            monthlyHoursWorkedTextBox = new TextBox();
            SuspendLayout();
            // 
            // employeeIDTextBox
            // 
            employeeIDTextBox.Location = new Point(147, 6);
            employeeIDTextBox.Size = new Size(141, 23);
            // 
            // employeeNameTextBox
            // 
            employeeNameTextBox.Location = new Point(147, 35);
            employeeNameTextBox.Size = new Size(141, 23);
            // 
            // addButton
            // 
            addButton.Location = new Point(294, 6);
            addButton.TabIndex = 10;
            addButton.Click += addButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(294, 43);
            clearButton.TabIndex = 11;
            clearButton.Click += clearButton_Click;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(294, 80);
            returnButton.TabIndex = 12;
            returnButton.Click += returnButton_Click;
            // 
            // shiftTextBox
            // 
            shiftTextBox.Location = new Point(147, 64);
            shiftTextBox.Name = "shiftTextBox";
            shiftTextBox.Size = new Size(141, 23);
            shiftTextBox.TabIndex = 5;
            // 
            // hourlyPayRateTextBox
            // 
            hourlyPayRateTextBox.Location = new Point(147, 93);
            hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            hourlyPayRateTextBox.Size = new Size(141, 23);
            hourlyPayRateTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "&Shift";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 6;
            label4.Text = "Hourly Pay &Rate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 125);
            label5.Name = "label5";
            label5.Size = new Size(131, 15);
            label5.TabIndex = 8;
            label5.Text = "Monthly &Hours Worked";
            // 
            // monthlyHoursWorkedTextBox
            // 
            monthlyHoursWorkedTextBox.Location = new Point(147, 122);
            monthlyHoursWorkedTextBox.Name = "monthlyHoursWorkedTextBox";
            monthlyHoursWorkedTextBox.Size = new Size(141, 23);
            monthlyHoursWorkedTextBox.TabIndex = 9;
            // 
            // AddProductionWorkerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 155);
            Controls.Add(label5);
            Controls.Add(monthlyHoursWorkedTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(hourlyPayRateTextBox);
            Controls.Add(shiftTextBox);
            Name = "AddProductionWorkerForm";
            Text = "Add Production Worker";
            Controls.SetChildIndex(returnButton, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(employeeIDTextBox, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(employeeNameTextBox, 0);
            Controls.SetChildIndex(addButton, 0);
            Controls.SetChildIndex(clearButton, 0);
            Controls.SetChildIndex(shiftTextBox, 0);
            Controls.SetChildIndex(hourlyPayRateTextBox, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(monthlyHoursWorkedTextBox, 0);
            Controls.SetChildIndex(label5, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected TextBox shiftTextBox;
        protected TextBox hourlyPayRateTextBox;
        protected Label label3;
        protected Label label4;
        protected Label label5;
        protected TextBox monthlyHoursWorkedTextBox;
    }
}