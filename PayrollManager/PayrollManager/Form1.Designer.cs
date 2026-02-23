namespace PayrollManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            outputListBox = new ListBox();
            displayButton = new Button();
            addProductionWorkerButton = new Button();
            addShiftSupervisorButton = new Button();
            addTeamLeaderButton = new Button();
            SuspendLayout();
            // 
            // outputListBox
            // 
            outputListBox.FormattingEnabled = true;
            outputListBox.ItemHeight = 15;
            outputListBox.Location = new Point(12, 10);
            outputListBox.Name = "outputListBox";
            outputListBox.Size = new Size(927, 229);
            outputListBox.TabIndex = 0;
            // 
            // displayButton
            // 
            displayButton.Location = new Point(189, 246);
            displayButton.Name = "displayButton";
            displayButton.Size = new Size(129, 57);
            displayButton.TabIndex = 4;
            displayButton.Text = "&Display";
            displayButton.UseVisualStyleBackColor = true;
            displayButton.Click += displayButton_Click;
            // 
            // addProductionWorkerButton
            // 
            addProductionWorkerButton.Location = new Point(12, 246);
            addProductionWorkerButton.Name = "addProductionWorkerButton";
            addProductionWorkerButton.Size = new Size(171, 57);
            addProductionWorkerButton.TabIndex = 1;
            addProductionWorkerButton.Text = "Add &Production Worker";
            addProductionWorkerButton.UseVisualStyleBackColor = true;
            addProductionWorkerButton.Click += addProductionWorkerButton_Click;
            // 
            // addShiftSupervisorButton
            // 
            addShiftSupervisorButton.Location = new Point(12, 309);
            addShiftSupervisorButton.Name = "addShiftSupervisorButton";
            addShiftSupervisorButton.Size = new Size(171, 57);
            addShiftSupervisorButton.TabIndex = 2;
            addShiftSupervisorButton.Text = "Add &Shift Supervisor";
            addShiftSupervisorButton.UseVisualStyleBackColor = true;
            addShiftSupervisorButton.Click += addShiftSupervisorButton_Click;
            // 
            // addTeamLeaderButton
            // 
            addTeamLeaderButton.Location = new Point(12, 372);
            addTeamLeaderButton.Name = "addTeamLeaderButton";
            addTeamLeaderButton.Size = new Size(171, 57);
            addTeamLeaderButton.TabIndex = 3;
            addTeamLeaderButton.Text = "Add &Team Leader";
            addTeamLeaderButton.UseVisualStyleBackColor = true;
            addTeamLeaderButton.Click += addTeamLeaderButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 446);
            Controls.Add(addTeamLeaderButton);
            Controls.Add(addShiftSupervisorButton);
            Controls.Add(addProductionWorkerButton);
            Controls.Add(displayButton);
            Controls.Add(outputListBox);
            Name = "Form1";
            Text = "Payroll Manager";
            ResumeLayout(false);
        }

        #endregion

        private ListBox outputListBox;
        private Button displayButton;
        private Button addProductionWorkerButton;
        private Button addShiftSupervisorButton;
        private Button addTeamLeaderButton;
    }
}
