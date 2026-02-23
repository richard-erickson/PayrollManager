namespace PayrollManager
{
    partial class AddShiftSupervisorForm
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
            label6 = new Label();
            annualSalaryTextBox = new TextBox();
            label3 = new Label();
            annualBonusTextBox = new TextBox();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.TabIndex = 8;
            addButton.Click += addButton_Click;
            // 
            // clearButton
            // 
            clearButton.TabIndex = 9;
            clearButton.Click += clearButton_Click;
            // 
            // returnButton
            // 
            returnButton.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 67);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 4;
            label6.Text = "Annual Salary";
            // 
            // annualSalaryTextBox
            // 
            annualSalaryTextBox.Location = new Point(112, 64);
            annualSalaryTextBox.Name = "annualSalaryTextBox";
            annualSalaryTextBox.Size = new Size(141, 23);
            annualSalaryTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 6;
            label3.Text = "Annual Bonus";
            // 
            // annualBonusTextBox
            // 
            annualBonusTextBox.Location = new Point(112, 93);
            annualBonusTextBox.Name = "annualBonusTextBox";
            annualBonusTextBox.Size = new Size(141, 23);
            annualBonusTextBox.TabIndex = 7;
            // 
            // AddShiftSupervisorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 128);
            Controls.Add(label3);
            Controls.Add(annualBonusTextBox);
            Controls.Add(label6);
            Controls.Add(annualSalaryTextBox);
            Name = "AddShiftSupervisorForm";
            Text = "Add Shift Supervisor";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(employeeIDTextBox, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(employeeNameTextBox, 0);
            Controls.SetChildIndex(addButton, 0);
            Controls.SetChildIndex(clearButton, 0);
            Controls.SetChildIndex(returnButton, 0);
            Controls.SetChildIndex(annualSalaryTextBox, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(annualBonusTextBox, 0);
            Controls.SetChildIndex(label3, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox annualSalaryTextBox;
        private Label label3;
        private TextBox annualBonusTextBox;
    }
}