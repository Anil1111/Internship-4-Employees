using EmployeesApp.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesApp.Presentation
{
    public partial class ProjectDetailsForm : Form
    {
        public Project Project;

        public ProjectDetailsForm(Project project)
        {
            InitializeComponent();
            Project = project;
            projectNameLabel.Text = Project.Name;
            projectDurationLabel.Text = Project.Duration();
        }
    }
}
