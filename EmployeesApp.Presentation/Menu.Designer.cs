namespace EmployeesApp.Presentation
{
    partial class Menu
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
            this.menuLabel = new System.Windows.Forms.Label();
            this.employeesListButton = new System.Windows.Forms.Button();
            this.employeeCreateButton = new System.Windows.Forms.Button();
            this.projectsListButton = new System.Windows.Forms.Button();
            this.projectCreateButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.EmployeesGroupBox = new System.Windows.Forms.GroupBox();
            this.projectsGroupBox = new System.Windows.Forms.GroupBox();
            this.EmployeesGroupBox.SuspendLayout();
            this.projectsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.Location = new System.Drawing.Point(335, 43);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(143, 48);
            this.menuLabel.TabIndex = 0;
            this.menuLabel.Text = "MENU";
            // 
            // employeesListButton
            // 
            this.employeesListButton.Location = new System.Drawing.Point(67, 37);
            this.employeesListButton.Name = "employeesListButton";
            this.employeesListButton.Size = new System.Drawing.Size(151, 62);
            this.employeesListButton.TabIndex = 1;
            this.employeesListButton.Text = "Popis radnika";
            this.employeesListButton.UseVisualStyleBackColor = true;
            this.employeesListButton.Click += new System.EventHandler(this.EmployeesList);
            // 
            // employeeCreateButton
            // 
            this.employeeCreateButton.Location = new System.Drawing.Point(67, 130);
            this.employeeCreateButton.Name = "employeeCreateButton";
            this.employeeCreateButton.Size = new System.Drawing.Size(151, 62);
            this.employeeCreateButton.TabIndex = 2;
            this.employeeCreateButton.Text = "Kreiranje novog radnika";
            this.employeeCreateButton.UseVisualStyleBackColor = true;
            this.employeeCreateButton.Click += new System.EventHandler(this.CreateEmployee);
            // 
            // projectsListButton
            // 
            this.projectsListButton.Location = new System.Drawing.Point(79, 37);
            this.projectsListButton.Name = "projectsListButton";
            this.projectsListButton.Size = new System.Drawing.Size(151, 62);
            this.projectsListButton.TabIndex = 3;
            this.projectsListButton.Text = "Popis projekata";
            this.projectsListButton.UseVisualStyleBackColor = true;
            this.projectsListButton.Click += new System.EventHandler(this.ProjectsList);
            // 
            // projectCreateButton
            // 
            this.projectCreateButton.Location = new System.Drawing.Point(79, 130);
            this.projectCreateButton.Name = "projectCreateButton";
            this.projectCreateButton.Size = new System.Drawing.Size(151, 62);
            this.projectCreateButton.TabIndex = 4;
            this.projectCreateButton.Text = "Kreiranje novog projekta";
            this.projectCreateButton.UseVisualStyleBackColor = true;
            this.projectCreateButton.Click += new System.EventHandler(this.CreateProject);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(344, 399);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 39);
            this.button5.TabIndex = 5;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Exit);
            // 
            // EmployeesGroupBox
            // 
            this.EmployeesGroupBox.Controls.Add(this.employeesListButton);
            this.EmployeesGroupBox.Controls.Add(this.employeeCreateButton);
            this.EmployeesGroupBox.Location = new System.Drawing.Point(74, 132);
            this.EmployeesGroupBox.Name = "EmployeesGroupBox";
            this.EmployeesGroupBox.Size = new System.Drawing.Size(302, 222);
            this.EmployeesGroupBox.TabIndex = 6;
            this.EmployeesGroupBox.TabStop = false;
            this.EmployeesGroupBox.Text = "Radnje nad radnicima";
            // 
            // projectsGroupBox
            // 
            this.projectsGroupBox.Controls.Add(this.projectCreateButton);
            this.projectsGroupBox.Controls.Add(this.projectsListButton);
            this.projectsGroupBox.Location = new System.Drawing.Point(435, 132);
            this.projectsGroupBox.Name = "projectsGroupBox";
            this.projectsGroupBox.Size = new System.Drawing.Size(301, 222);
            this.projectsGroupBox.TabIndex = 7;
            this.projectsGroupBox.TabStop = false;
            this.projectsGroupBox.Text = "Radnje nad projektima";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.projectsGroupBox);
            this.Controls.Add(this.EmployeesGroupBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.menuLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.EmployeesGroupBox.ResumeLayout(false);
            this.projectsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Button employeesListButton;
        private System.Windows.Forms.Button employeeCreateButton;
        private System.Windows.Forms.Button projectsListButton;
        private System.Windows.Forms.Button projectCreateButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox EmployeesGroupBox;
        private System.Windows.Forms.GroupBox projectsGroupBox;
    }
}