﻿namespace EmployeesApp.Presentation
{
    partial class EmployeeCreateForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.employeeSurnameTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.employeeDateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.jobLabel = new System.Windows.Forms.Label();
            this.employeeJobComboBox = new System.Windows.Forms.ComboBox();
            this.projectsLabel = new System.Windows.Forms.Label();
            this.employeeProjectsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.employeeSaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.oibLabel = new System.Windows.Forms.Label();
            this.employeeOibTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(52, 118);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(34, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Ime:";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(55, 138);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(155, 22);
            this.employeeNameTextBox.TabIndex = 1;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(52, 173);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(63, 17);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Prezime:";
            // 
            // employeeSurnameTextBox
            // 
            this.employeeSurnameTextBox.Location = new System.Drawing.Point(55, 193);
            this.employeeSurnameTextBox.Name = "employeeSurnameTextBox";
            this.employeeSurnameTextBox.Size = new System.Drawing.Size(155, 22);
            this.employeeSurnameTextBox.TabIndex = 3;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(52, 280);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(105, 17);
            this.dateOfBirthLabel.TabIndex = 4;
            this.dateOfBirthLabel.Text = "Datum rođenja:";
            // 
            // employeeDateOfBirthDateTimePicker
            // 
            this.employeeDateOfBirthDateTimePicker.Location = new System.Drawing.Point(55, 308);
            this.employeeDateOfBirthDateTimePicker.Name = "employeeDateOfBirthDateTimePicker";
            this.employeeDateOfBirthDateTimePicker.Size = new System.Drawing.Size(155, 22);
            this.employeeDateOfBirthDateTimePicker.TabIndex = 5;
            // 
            // jobLabel
            // 
            this.jobLabel.AutoSize = true;
            this.jobLabel.Location = new System.Drawing.Point(343, 116);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(60, 17);
            this.jobLabel.TabIndex = 6;
            this.jobLabel.Text = "Pozicija:";
            // 
            // employeeJobComboBox
            // 
            this.employeeJobComboBox.FormattingEnabled = true;
            this.employeeJobComboBox.Location = new System.Drawing.Point(346, 136);
            this.employeeJobComboBox.Name = "employeeJobComboBox";
            this.employeeJobComboBox.Size = new System.Drawing.Size(148, 24);
            this.employeeJobComboBox.TabIndex = 7;
            // 
            // projectsLabel
            // 
            this.projectsLabel.AutoSize = true;
            this.projectsLabel.Location = new System.Drawing.Point(343, 173);
            this.projectsLabel.Name = "projectsLabel";
            this.projectsLabel.Size = new System.Drawing.Size(59, 17);
            this.projectsLabel.TabIndex = 8;
            this.projectsLabel.Text = "Projekti:";
            // 
            // employeeProjectsCheckedListBox
            // 
            this.employeeProjectsCheckedListBox.FormattingEnabled = true;
            this.employeeProjectsCheckedListBox.Location = new System.Drawing.Point(346, 193);
            this.employeeProjectsCheckedListBox.Name = "employeeProjectsCheckedListBox";
            this.employeeProjectsCheckedListBox.Size = new System.Drawing.Size(428, 140);
            this.employeeProjectsCheckedListBox.TabIndex = 9;
            // 
            // employeeSaveButton
            // 
            this.employeeSaveButton.Location = new System.Drawing.Point(314, 376);
            this.employeeSaveButton.Name = "employeeSaveButton";
            this.employeeSaveButton.Size = new System.Drawing.Size(156, 50);
            this.employeeSaveButton.TabIndex = 10;
            this.employeeSaveButton.Text = "Spremi";
            this.employeeSaveButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(233, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dodavanje novog radnika:";
            // 
            // oibLabel
            // 
            this.oibLabel.AutoSize = true;
            this.oibLabel.Location = new System.Drawing.Point(52, 227);
            this.oibLabel.Name = "oibLabel";
            this.oibLabel.Size = new System.Drawing.Size(35, 17);
            this.oibLabel.TabIndex = 12;
            this.oibLabel.Text = "OIB:";
            // 
            // employeeOibTextBox
            // 
            this.employeeOibTextBox.Location = new System.Drawing.Point(55, 249);
            this.employeeOibTextBox.Name = "employeeOibTextBox";
            this.employeeOibTextBox.Size = new System.Drawing.Size(155, 22);
            this.employeeOibTextBox.TabIndex = 13;
            // 
            // EmployeeCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeeOibTextBox);
            this.Controls.Add(this.oibLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeSaveButton);
            this.Controls.Add(this.employeeProjectsCheckedListBox);
            this.Controls.Add(this.projectsLabel);
            this.Controls.Add(this.employeeJobComboBox);
            this.Controls.Add(this.jobLabel);
            this.Controls.Add(this.employeeDateOfBirthDateTimePicker);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.employeeSurnameTextBox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmployeeCreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeeCreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox employeeSurnameTextBox;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.DateTimePicker employeeDateOfBirthDateTimePicker;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.ComboBox employeeJobComboBox;
        private System.Windows.Forms.Label projectsLabel;
        private System.Windows.Forms.CheckedListBox employeeProjectsCheckedListBox;
        private System.Windows.Forms.Button employeeSaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label oibLabel;
        private System.Windows.Forms.TextBox employeeOibTextBox;
    }
}