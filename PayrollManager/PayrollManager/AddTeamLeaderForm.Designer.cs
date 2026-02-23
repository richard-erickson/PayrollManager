namespace PayrollManager
{
    partial class AddTeamLeaderForm : AddProductionWorkerForm
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
            monthlyBonusTextBoxButton = new TextBox();
            label6 = new Label();
            label7 = new Label();
            requiredHoursTextBox = new TextBox();
            label8 = new Label();
            completedHoursTextBox = new TextBox();
            SuspendLayout();
            // 
            // shiftTextBox
            // 
            shiftTextBox.Location = new Point(165, 64);
            shiftTextBox.TabIndex = 5;
            // 
            // hourlyPayRateTextBox
            // 
            hourlyPayRateTextBox.Location = new Point(165, 93);
            hourlyPayRateTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.TabIndex = 4;
            // 
            // label4
            // 
            label4.TabIndex = 6;
            // 
            // label5
            // 
            label5.TabIndex = 8;
            // 
            // monthlyHoursWorkedTextBox
            // 
            monthlyHoursWorkedTextBox.Location = new Point(165, 122);
            monthlyHoursWorkedTextBox.TabIndex = 9;
            // 
            // employeeIDTextBox
            // 
            employeeIDTextBox.Location = new Point(165, 6);
            // 
            // employeeNameTextBox
            // 
            employeeNameTextBox.Location = new Point(165, 35);
            // 
            // addButton
            // 
            addButton.Location = new Point(312, 1);
            addButton.TabIndex = 16;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(312, 38);
            clearButton.TabIndex = 17;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(312, 75);
            returnButton.TabIndex = 18;
            // 
            // monthlyBonusTextBoxButton
            // 
            monthlyBonusTextBoxButton.Location = new Point(165, 151);
            monthlyBonusTextBoxButton.Name = "monthlyBonusTextBoxButton";
            monthlyBonusTextBoxButton.Size = new Size(141, 23);
            monthlyBonusTextBoxButton.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 154);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 10;
            label6.Text = "Monthly &Bonus";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 183);
            label7.Name = "label7";
            label7.Size = new Size(135, 15);
            label7.TabIndex = 12;
            label7.Text = "&Required Training Hours";
            // 
            // requiredHoursTextBox
            // 
            requiredHoursTextBox.Location = new Point(165, 180);
            requiredHoursTextBox.Name = "requiredHoursTextBox";
            requiredHoursTextBox.Size = new Size(141, 23);
            requiredHoursTextBox.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 212);
            label8.Name = "label8";
            label8.Size = new Size(147, 15);
            label8.TabIndex = 14;
            label8.Text = "&Completed Training Hours";
            // 
            // completedHoursTextBox
            // 
            completedHoursTextBox.Location = new Point(165, 209);
            completedHoursTextBox.Name = "completedHoursTextBox";
            completedHoursTextBox.Size = new Size(141, 23);
            completedHoursTextBox.TabIndex = 15;
            // 
            // AddTeamLeaderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 244);
            Controls.Add(label8);
            Controls.Add(completedHoursTextBox);
            Controls.Add(label7);
            Controls.Add(requiredHoursTextBox);
            Controls.Add(label6);
            Controls.Add(monthlyBonusTextBoxButton);
            Name = "AddTeamLeaderForm";
            Text = "Add Team Leader";
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
            Controls.SetChildIndex(monthlyBonusTextBoxButton, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(requiredHoursTextBox, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(completedHoursTextBox, 0);
            Controls.SetChildIndex(label8, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox monthlyBonusTextBoxButton;
        private Label label6;
        private Label label7;
        private TextBox requiredHoursTextBox;
        private Label label8;
        private TextBox completedHoursTextBox;
    }
}