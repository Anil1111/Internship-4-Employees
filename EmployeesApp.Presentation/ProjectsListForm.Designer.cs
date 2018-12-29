namespace EmployeesApp.Presentation
{
    partial class ProjectsListForm
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
            this.projectsListBox = new System.Windows.Forms.ListBox();
            this.projectDetailsButton = new System.Windows.Forms.Button();
            this.projectRemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectsListBox
            // 
            this.projectsListBox.FormattingEnabled = true;
            this.projectsListBox.ItemHeight = 16;
            this.projectsListBox.Location = new System.Drawing.Point(12, 72);
            this.projectsListBox.Name = "projectsListBox";
            this.projectsListBox.Size = new System.Drawing.Size(609, 372);
            this.projectsListBox.TabIndex = 0;
            // 
            // projectDetailsButton
            // 
            this.projectDetailsButton.Location = new System.Drawing.Point(649, 72);
            this.projectDetailsButton.Name = "projectDetailsButton";
            this.projectDetailsButton.Size = new System.Drawing.Size(129, 45);
            this.projectDetailsButton.TabIndex = 1;
            this.projectDetailsButton.Text = "Detalji projekta";
            this.projectDetailsButton.UseVisualStyleBackColor = true;
            // 
            // projectRemoveButton
            // 
            this.projectRemoveButton.Location = new System.Drawing.Point(649, 156);
            this.projectRemoveButton.Name = "projectRemoveButton";
            this.projectRemoveButton.Size = new System.Drawing.Size(129, 45);
            this.projectRemoveButton.TabIndex = 2;
            this.projectRemoveButton.Text = "Brisanje projekta";
            this.projectRemoveButton.UseVisualStyleBackColor = true;
            // 
            // ProjectsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.projectRemoveButton);
            this.Controls.Add(this.projectDetailsButton);
            this.Controls.Add(this.projectsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProjectsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProjectsListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox projectsListBox;
        private System.Windows.Forms.Button projectDetailsButton;
        private System.Windows.Forms.Button projectRemoveButton;
    }
}