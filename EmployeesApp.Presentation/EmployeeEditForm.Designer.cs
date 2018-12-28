namespace EmployeesApp.Presentation
{
    partial class EmployeeEditForm
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
            this.editLabel = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.employeeSurnameTextBox = new System.Windows.Forms.TextBox();
            this.oibLabel = new System.Windows.Forms.Label();
            this.employeeOibTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.employeeDateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.jobLabel = new System.Windows.Forms.Label();
            this.employeeJobComboBox = new System.Windows.Forms.ComboBox();
            this.projectsLabel = new System.Windows.Forms.Label();
            this.employeeProjectsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(47, 109);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(34, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Ime:";
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editLabel.Location = new System.Drawing.Point(247, 34);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(311, 29);
            this.editLabel.TabIndex = 1;
            this.editLabel.Text = "Promjena detalja radnika:";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(50, 129);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(149, 22);
            this.employeeNameTextBox.TabIndex = 2;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(47, 168);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(63, 17);
            this.surnameLabel.TabIndex = 3;
            this.surnameLabel.Text = "Prezime:";
            // 
            // employeeSurnameTextBox
            // 
            this.employeeSurnameTextBox.Location = new System.Drawing.Point(50, 188);
            this.employeeSurnameTextBox.Name = "employeeSurnameTextBox";
            this.employeeSurnameTextBox.Size = new System.Drawing.Size(149, 22);
            this.employeeSurnameTextBox.TabIndex = 4;
            // 
            // oibLabel
            // 
            this.oibLabel.AutoSize = true;
            this.oibLabel.Location = new System.Drawing.Point(47, 223);
            this.oibLabel.Name = "oibLabel";
            this.oibLabel.Size = new System.Drawing.Size(35, 17);
            this.oibLabel.TabIndex = 5;
            this.oibLabel.Text = "OIB:";
            // 
            // employeeOibTextBox
            // 
            this.employeeOibTextBox.Location = new System.Drawing.Point(50, 243);
            this.employeeOibTextBox.Name = "employeeOibTextBox";
            this.employeeOibTextBox.Size = new System.Drawing.Size(149, 22);
            this.employeeOibTextBox.TabIndex = 6;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(47, 277);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(105, 17);
            this.dateOfBirthLabel.TabIndex = 7;
            this.dateOfBirthLabel.Text = "Datum rođenja:";
            // 
            // employeeDateOfBirthDateTimePicker
            // 
            this.employeeDateOfBirthDateTimePicker.Location = new System.Drawing.Point(50, 298);
            this.employeeDateOfBirthDateTimePicker.Name = "employeeDateOfBirthDateTimePicker";
            this.employeeDateOfBirthDateTimePicker.Size = new System.Drawing.Size(149, 22);
            this.employeeDateOfBirthDateTimePicker.TabIndex = 8;
            // 
            // jobLabel
            // 
            this.jobLabel.AutoSize = true;
            this.jobLabel.Location = new System.Drawing.Point(332, 109);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(60, 17);
            this.jobLabel.TabIndex = 9;
            this.jobLabel.Text = "Pozicija:";
            // 
            // employeeJobComboBox
            // 
            this.employeeJobComboBox.FormattingEnabled = true;
            this.employeeJobComboBox.Location = new System.Drawing.Point(335, 129);
            this.employeeJobComboBox.Name = "employeeJobComboBox";
            this.employeeJobComboBox.Size = new System.Drawing.Size(149, 24);
            this.employeeJobComboBox.TabIndex = 10;
            // 
            // projectsLabel
            // 
            this.projectsLabel.AutoSize = true;
            this.projectsLabel.Location = new System.Drawing.Point(332, 168);
            this.projectsLabel.Name = "projectsLabel";
            this.projectsLabel.Size = new System.Drawing.Size(59, 17);
            this.projectsLabel.TabIndex = 11;
            this.projectsLabel.Text = "Projekti:";
            // 
            // employeeProjectsCheckedListBox
            // 
            this.employeeProjectsCheckedListBox.FormattingEnabled = true;
            this.employeeProjectsCheckedListBox.Location = new System.Drawing.Point(335, 188);
            this.employeeProjectsCheckedListBox.Name = "employeeProjectsCheckedListBox";
            this.employeeProjectsCheckedListBox.Size = new System.Drawing.Size(420, 140);
            this.employeeProjectsCheckedListBox.TabIndex = 12;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(324, 384);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(149, 43);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "spremi";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // EmployeeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.employeeProjectsCheckedListBox);
            this.Controls.Add(this.projectsLabel);
            this.Controls.Add(this.employeeJobComboBox);
            this.Controls.Add(this.jobLabel);
            this.Controls.Add(this.employeeDateOfBirthDateTimePicker);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.employeeOibTextBox);
            this.Controls.Add(this.oibLabel);
            this.Controls.Add(this.employeeSurnameTextBox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.editLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmployeeEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeeEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label editLabel;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox employeeSurnameTextBox;
        private System.Windows.Forms.Label oibLabel;
        private System.Windows.Forms.TextBox employeeOibTextBox;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.DateTimePicker employeeDateOfBirthDateTimePicker;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.ComboBox employeeJobComboBox;
        private System.Windows.Forms.Label projectsLabel;
        private System.Windows.Forms.CheckedListBox employeeProjectsCheckedListBox;
        private System.Windows.Forms.Button saveButton;
    }
}