namespace EmployeesApp.Presentation
{
    partial class EmployeeDetailsForm
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
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.employeeSurnameLabel = new System.Windows.Forms.Label();
            this.employeeOibLabel = new System.Windows.Forms.Label();
            this.employeeJobLabel = new System.Windows.Forms.Label();
            this.employeeProjectsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.employeeEditButton = new System.Windows.Forms.Button();
            this.employeeDateOfBirthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(111, 75);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(30, 17);
            this.employeeNameLabel.TabIndex = 0;
            this.employeeNameLabel.Text = "Ime";
            // 
            // employeeSurnameLabel
            // 
            this.employeeSurnameLabel.AutoSize = true;
            this.employeeSurnameLabel.Location = new System.Drawing.Point(111, 106);
            this.employeeSurnameLabel.Name = "employeeSurnameLabel";
            this.employeeSurnameLabel.Size = new System.Drawing.Size(59, 17);
            this.employeeSurnameLabel.TabIndex = 1;
            this.employeeSurnameLabel.Text = "Prezime";
            // 
            // employeeOibLabel
            // 
            this.employeeOibLabel.AutoSize = true;
            this.employeeOibLabel.Location = new System.Drawing.Point(111, 137);
            this.employeeOibLabel.Name = "employeeOibLabel";
            this.employeeOibLabel.Size = new System.Drawing.Size(31, 17);
            this.employeeOibLabel.TabIndex = 2;
            this.employeeOibLabel.Text = "OIB";
            // 
            // employeeJobLabel
            // 
            this.employeeJobLabel.AutoSize = true;
            this.employeeJobLabel.Location = new System.Drawing.Point(111, 207);
            this.employeeJobLabel.Name = "employeeJobLabel";
            this.employeeJobLabel.Size = new System.Drawing.Size(74, 17);
            this.employeeJobLabel.TabIndex = 4;
            this.employeeJobLabel.Text = "Zanimanje";
            // 
            // employeeProjectsCheckedListBox
            // 
            this.employeeProjectsCheckedListBox.FormattingEnabled = true;
            this.employeeProjectsCheckedListBox.Location = new System.Drawing.Point(460, 64);
            this.employeeProjectsCheckedListBox.Name = "employeeProjectsCheckedListBox";
            this.employeeProjectsCheckedListBox.Size = new System.Drawing.Size(292, 191);
            this.employeeProjectsCheckedListBox.TabIndex = 5;
            // 
            // employeeEditButton
            // 
            this.employeeEditButton.Location = new System.Drawing.Point(314, 344);
            this.employeeEditButton.Name = "employeeEditButton";
            this.employeeEditButton.Size = new System.Drawing.Size(203, 67);
            this.employeeEditButton.TabIndex = 6;
            this.employeeEditButton.Text = "Promijeni detalje radnika";
            this.employeeEditButton.UseVisualStyleBackColor = true;
            // 
            // employeeDateOfBirthLabel
            // 
            this.employeeDateOfBirthLabel.AutoSize = true;
            this.employeeDateOfBirthLabel.Location = new System.Drawing.Point(111, 173);
            this.employeeDateOfBirthLabel.Name = "employeeDateOfBirthLabel";
            this.employeeDateOfBirthLabel.Size = new System.Drawing.Size(101, 17);
            this.employeeDateOfBirthLabel.TabIndex = 7;
            this.employeeDateOfBirthLabel.Text = "Datum rođenja";
            // 
            // EmployeeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeeDateOfBirthLabel);
            this.Controls.Add(this.employeeEditButton);
            this.Controls.Add(this.employeeProjectsCheckedListBox);
            this.Controls.Add(this.employeeJobLabel);
            this.Controls.Add(this.employeeOibLabel);
            this.Controls.Add(this.employeeSurnameLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Name = "EmployeeDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeeDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label employeeSurnameLabel;
        private System.Windows.Forms.Label employeeOibLabel;
        private System.Windows.Forms.Label employeeJobLabel;
        private System.Windows.Forms.CheckedListBox employeeProjectsCheckedListBox;
        private System.Windows.Forms.Button employeeEditButton;
        private System.Windows.Forms.Label employeeDateOfBirthLabel;
    }
}