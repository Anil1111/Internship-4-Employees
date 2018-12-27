namespace EmployeesApp.Presentation
{
    partial class EmployeesListForm
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
            this.employeesListBox = new System.Windows.Forms.ListBox();
            this.employeeDetailsButton = new System.Windows.Forms.Button();
            this.employeeRemoveButton = new System.Windows.Forms.Button();
            this.employeesInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeesListBox
            // 
            this.employeesListBox.FormattingEnabled = true;
            this.employeesListBox.ItemHeight = 16;
            this.employeesListBox.Location = new System.Drawing.Point(12, 82);
            this.employeesListBox.Name = "employeesListBox";
            this.employeesListBox.Size = new System.Drawing.Size(527, 356);
            this.employeesListBox.TabIndex = 0;
            // 
            // employeeDetailsButton
            // 
            this.employeeDetailsButton.Location = new System.Drawing.Point(587, 82);
            this.employeeDetailsButton.Name = "employeeDetailsButton";
            this.employeeDetailsButton.Size = new System.Drawing.Size(164, 67);
            this.employeeDetailsButton.TabIndex = 1;
            this.employeeDetailsButton.Text = "Pogledajte detalje zaposlenika";
            this.employeeDetailsButton.UseVisualStyleBackColor = true;
            this.employeeDetailsButton.Click += new System.EventHandler(this.EmployeeDetails);
            // 
            // employeeRemoveButton
            // 
            this.employeeRemoveButton.Location = new System.Drawing.Point(587, 186);
            this.employeeRemoveButton.Name = "employeeRemoveButton";
            this.employeeRemoveButton.Size = new System.Drawing.Size(164, 67);
            this.employeeRemoveButton.TabIndex = 2;
            this.employeeRemoveButton.Text = "Ukloni zaposlenika";
            this.employeeRemoveButton.UseVisualStyleBackColor = true;
            this.employeeRemoveButton.Click += new System.EventHandler(this.EmployeeDelete);
            // 
            // employeesInfoLabel
            // 
            this.employeesInfoLabel.AutoSize = true;
            this.employeesInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.employeesInfoLabel.Location = new System.Drawing.Point(550, 82);
            this.employeesInfoLabel.Name = "employeesInfoLabel";
            this.employeesInfoLabel.Size = new System.Drawing.Size(238, 25);
            this.employeesInfoLabel.TabIndex = 3;
            this.employeesInfoLabel.Text = "NEMA ZAPOSLENIKA!";
            // 
            // EmployeesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeesInfoLabel);
            this.Controls.Add(this.employeeRemoveButton);
            this.Controls.Add(this.employeeDetailsButton);
            this.Controls.Add(this.employeesListBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "EmployeesListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista svih zaposlenika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox employeesListBox;
        private System.Windows.Forms.Button employeeDetailsButton;
        private System.Windows.Forms.Button employeeRemoveButton;
        private System.Windows.Forms.Label employeesInfoLabel;
    }
}