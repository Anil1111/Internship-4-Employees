﻿namespace EmployeesApp.Presentation
{
    partial class ProjectCreateForm
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
            this.projectSaveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.employeesLabel = new System.Windows.Forms.Label();
            this.addEmployeeOnProjectSaveButton = new System.Windows.Forms.Button();
            this.employeesWorkingOnProjectListBox = new System.Windows.Forms.ListBox();
            this.allEmployeesListBox = new System.Windows.Forms.ListBox();
            this.employeeWorkingTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.workingTimeLabel = new System.Windows.Forms.Label();
            this.projectDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.projectEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.projectStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeWorkingTimeNumericUpDown)).BeginInit();
            this.projectDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectSaveButton
            // 
            this.projectSaveButton.Location = new System.Drawing.Point(382, 469);
            this.projectSaveButton.Name = "projectSaveButton";
            this.projectSaveButton.Size = new System.Drawing.Size(178, 65);
            this.projectSaveButton.TabIndex = 15;
            this.projectSaveButton.Text = "save";
            this.projectSaveButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.employeesLabel);
            this.groupBox1.Controls.Add(this.addEmployeeOnProjectSaveButton);
            this.groupBox1.Controls.Add(this.employeesWorkingOnProjectListBox);
            this.groupBox1.Controls.Add(this.allEmployeesListBox);
            this.groupBox1.Controls.Add(this.employeeWorkingTimeNumericUpDown);
            this.groupBox1.Controls.Add(this.workingTimeLabel);
            this.groupBox1.Location = new System.Drawing.Point(59, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 222);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zaposlenici na projektu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Zaposlenici na projektu:";
            // 
            // employeesLabel
            // 
            this.employeesLabel.AutoSize = true;
            this.employeesLabel.Location = new System.Drawing.Point(6, 43);
            this.employeesLabel.Name = "employeesLabel";
            this.employeesLabel.Size = new System.Drawing.Size(105, 17);
            this.employeesLabel.TabIndex = 13;
            this.employeesLabel.Text = "Svi zaposlenici:";
            // 
            // addEmployeeOnProjectSaveButton
            // 
            this.addEmployeeOnProjectSaveButton.Location = new System.Drawing.Point(326, 151);
            this.addEmployeeOnProjectSaveButton.Name = "addEmployeeOnProjectSaveButton";
            this.addEmployeeOnProjectSaveButton.Size = new System.Drawing.Size(153, 65);
            this.addEmployeeOnProjectSaveButton.TabIndex = 9;
            this.addEmployeeOnProjectSaveButton.Text = "ubaci zaposlenika na projekt";
            this.addEmployeeOnProjectSaveButton.UseVisualStyleBackColor = true;
            // 
            // employeesWorkingOnProjectListBox
            // 
            this.employeesWorkingOnProjectListBox.FormattingEnabled = true;
            this.employeesWorkingOnProjectListBox.ItemHeight = 16;
            this.employeesWorkingOnProjectListBox.Location = new System.Drawing.Point(529, 68);
            this.employeesWorkingOnProjectListBox.Name = "employeesWorkingOnProjectListBox";
            this.employeesWorkingOnProjectListBox.Size = new System.Drawing.Size(258, 148);
            this.employeesWorkingOnProjectListBox.TabIndex = 7;
            // 
            // allEmployeesListBox
            // 
            this.allEmployeesListBox.FormattingEnabled = true;
            this.allEmployeesListBox.ItemHeight = 16;
            this.allEmployeesListBox.Location = new System.Drawing.Point(6, 68);
            this.allEmployeesListBox.Name = "allEmployeesListBox";
            this.allEmployeesListBox.Size = new System.Drawing.Size(258, 148);
            this.allEmployeesListBox.TabIndex = 6;
            // 
            // employeeWorkingTimeNumericUpDown
            // 
            this.employeeWorkingTimeNumericUpDown.Location = new System.Drawing.Point(341, 93);
            this.employeeWorkingTimeNumericUpDown.Maximum = new decimal(new int[] {
            56,
            0,
            0,
            0});
            this.employeeWorkingTimeNumericUpDown.Name = "employeeWorkingTimeNumericUpDown";
            this.employeeWorkingTimeNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.employeeWorkingTimeNumericUpDown.TabIndex = 12;
            // 
            // workingTimeLabel
            // 
            this.workingTimeLabel.AutoSize = true;
            this.workingTimeLabel.Location = new System.Drawing.Point(327, 68);
            this.workingTimeLabel.Name = "workingTimeLabel";
            this.workingTimeLabel.Size = new System.Drawing.Size(146, 17);
            this.workingTimeLabel.TabIndex = 11;
            this.workingTimeLabel.Text = "Tjedno radno vrijeme:";
            // 
            // projectDetailsGroupBox
            // 
            this.projectDetailsGroupBox.Controls.Add(this.endDateLabel);
            this.projectDetailsGroupBox.Controls.Add(this.projectEndDateDateTimePicker);
            this.projectDetailsGroupBox.Controls.Add(this.projectStartDateDateTimePicker);
            this.projectDetailsGroupBox.Controls.Add(this.projectNameTextBox);
            this.projectDetailsGroupBox.Controls.Add(this.startDateLabel);
            this.projectDetailsGroupBox.Controls.Add(this.nameLabel);
            this.projectDetailsGroupBox.Location = new System.Drawing.Point(59, 53);
            this.projectDetailsGroupBox.Name = "projectDetailsGroupBox";
            this.projectDetailsGroupBox.Size = new System.Drawing.Size(793, 121);
            this.projectDetailsGroupBox.TabIndex = 16;
            this.projectDetailsGroupBox.TabStop = false;
            this.projectDetailsGroupBox.Text = "Detalji o projektu";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(573, 41);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(118, 17);
            this.endDateLabel.TabIndex = 5;
            this.endDateLabel.Text = "Datum završetka:";
            // 
            // projectEndDateDateTimePicker
            // 
            this.projectEndDateDateTimePicker.Location = new System.Drawing.Point(558, 72);
            this.projectEndDateDateTimePicker.Name = "projectEndDateDateTimePicker";
            this.projectEndDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.projectEndDateDateTimePicker.TabIndex = 4;
            // 
            // projectStartDateDateTimePicker
            // 
            this.projectStartDateDateTimePicker.Location = new System.Drawing.Point(299, 72);
            this.projectStartDateDateTimePicker.Name = "projectStartDateDateTimePicker";
            this.projectStartDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.projectStartDateDateTimePicker.TabIndex = 3;
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Location = new System.Drawing.Point(28, 72);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.projectNameTextBox.TabIndex = 2;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(296, 41);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(107, 17);
            this.startDateLabel.TabIndex = 1;
            this.startDateLabel.Text = "Datum početka:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(25, 41);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(34, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Ime:";
            // 
            // ProjectCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(911, 577);
            this.Controls.Add(this.projectSaveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.projectDetailsGroupBox);
            this.Name = "ProjectCreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectCreateForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeWorkingTimeNumericUpDown)).EndInit();
            this.projectDetailsGroupBox.ResumeLayout(false);
            this.projectDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button projectSaveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label employeesLabel;
        private System.Windows.Forms.Button addEmployeeOnProjectSaveButton;
        private System.Windows.Forms.ListBox employeesWorkingOnProjectListBox;
        private System.Windows.Forms.ListBox allEmployeesListBox;
        private System.Windows.Forms.NumericUpDown employeeWorkingTimeNumericUpDown;
        private System.Windows.Forms.Label workingTimeLabel;
        private System.Windows.Forms.GroupBox projectDetailsGroupBox;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker projectEndDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker projectStartDateDateTimePicker;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}