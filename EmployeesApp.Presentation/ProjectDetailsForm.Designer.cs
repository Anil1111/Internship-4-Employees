namespace EmployeesApp.Presentation
{
    partial class ProjectDetailsForm
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
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.projectDurationLabel = new System.Windows.Forms.Label();
            this.programersLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.designersLabel = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.accountantsLabel = new System.Windows.Forms.Label();
            this.projectEditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameLabel.Location = new System.Drawing.Point(5, 46);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(109, 38);
            this.projectNameLabel.TabIndex = 0;
            this.projectNameLabel.Text = "label1";
            // 
            // projectDurationLabel
            // 
            this.projectDurationLabel.AutoSize = true;
            this.projectDurationLabel.Location = new System.Drawing.Point(12, 98);
            this.projectDurationLabel.Name = "projectDurationLabel";
            this.projectDurationLabel.Size = new System.Drawing.Size(46, 17);
            this.projectDurationLabel.TabIndex = 1;
            this.projectDurationLabel.Text = "label1";
            // 
            // programersLabel
            // 
            this.programersLabel.AutoSize = true;
            this.programersLabel.Location = new System.Drawing.Point(9, 144);
            this.programersLabel.Name = "programersLabel";
            this.programersLabel.Size = new System.Drawing.Size(82, 17);
            this.programersLabel.TabIndex = 2;
            this.programersLabel.Text = "Programeri:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 164);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(222, 180);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(287, 164);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(221, 180);
            this.listBox2.TabIndex = 4;
            // 
            // designersLabel
            // 
            this.designersLabel.AutoSize = true;
            this.designersLabel.Location = new System.Drawing.Point(284, 144);
            this.designersLabel.Name = "designersLabel";
            this.designersLabel.Size = new System.Drawing.Size(75, 17);
            this.designersLabel.TabIndex = 5;
            this.designersLabel.Text = "Dizajeneri:";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(567, 164);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(221, 180);
            this.listBox3.TabIndex = 6;
            // 
            // accountantsLabel
            // 
            this.accountantsLabel.AutoSize = true;
            this.accountantsLabel.Location = new System.Drawing.Point(564, 144);
            this.accountantsLabel.Name = "accountantsLabel";
            this.accountantsLabel.Size = new System.Drawing.Size(92, 17);
            this.accountantsLabel.TabIndex = 7;
            this.accountantsLabel.Text = "Računovođe:";
            // 
            // projectEditButton
            // 
            this.projectEditButton.Location = new System.Drawing.Point(338, 384);
            this.projectEditButton.Name = "projectEditButton";
            this.projectEditButton.Size = new System.Drawing.Size(151, 54);
            this.projectEditButton.TabIndex = 8;
            this.projectEditButton.Text = "Uređivanje projekta:";
            this.projectEditButton.UseVisualStyleBackColor = true;
            this.projectEditButton.Click += new System.EventHandler(this.ProjectEdit);
            // 
            // ProjectDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.projectEditButton);
            this.Controls.Add(this.accountantsLabel);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.designersLabel);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.programersLabel);
            this.Controls.Add(this.projectDurationLabel);
            this.Controls.Add(this.projectNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProjectDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProjectDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Label projectDurationLabel;
        private System.Windows.Forms.Label programersLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label designersLabel;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label accountantsLabel;
        private System.Windows.Forms.Button projectEditButton;
    }
}