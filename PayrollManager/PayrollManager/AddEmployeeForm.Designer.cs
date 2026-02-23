namespace PayrollManager
{
    partial class AddEmployeeForm
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
            label1 = new Label();
            employeeIDTextBox = new TextBox();
            employeeNameTextBox = new TextBox();
            label2 = new Label();
            addButton = new Button();
            clearButton = new Button();
            returnButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Employee &ID";
            // 
            // employeeIDTextBox
            // 
            employeeIDTextBox.Location = new Point(112, 6);
            employeeIDTextBox.Name = "employeeIDTextBox";
            employeeIDTextBox.Size = new Size(139, 23);
            employeeIDTextBox.TabIndex = 1;
            // 
            // employeeNameTextBox
            // 
            employeeNameTextBox.Location = new Point(112, 35);
            employeeNameTextBox.Name = "employeeNameTextBox";
            employeeNameTextBox.Size = new Size(139, 23);
            employeeNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 2;
            label2.Text = "Employee &Name";
            // 
            // addButton
            // 
            addButton.Location = new Point(257, 6);
            addButton.Name = "addButton";
            addButton.Size = new Size(55, 31);
            addButton.TabIndex = 4;
            addButton.Text = "&Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(257, 43);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(55, 31);
            clearButton.TabIndex = 5;
            clearButton.Text = "C&lear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(257, 80);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(55, 31);
            returnButton.TabIndex = 6;
            returnButton.Text = "&Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 120);
            Controls.Add(returnButton);
            Controls.Add(clearButton);
            Controls.Add(addButton);
            Controls.Add(employeeNameTextBox);
            Controls.Add(label2);
            Controls.Add(employeeIDTextBox);
            Controls.Add(label1);
            Name = "AddEmployeeForm";
            Text = "Add Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Label label1;
        protected TextBox employeeIDTextBox;
        protected TextBox employeeNameTextBox;
        protected Label label2;
        protected Button addButton;
        protected Button clearButton;
        protected Button returnButton;
    }
}