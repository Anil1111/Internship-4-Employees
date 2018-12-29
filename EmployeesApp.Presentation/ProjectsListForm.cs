using EmployeesApp.Data.Models;
using EmployeesApp.Domain.Repositories;
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
    public partial class ProjectsListForm : Form
    {
        private List<Project> _projects;
        private ProjectRespository _projectRespository;

        public ProjectsListForm(ProjectRespository projectRespository)
        {
            InitializeComponent();
            _projectRespository = projectRespository;
            RefreshProjects();
        }

        private void RefreshProjects()
        {
            projectsListBox.Items.Clear();

            _projects = _projectRespository.GetAllProjects();

            _projects.OrderBy(project => project.Name)
                .ToList()
                .ForEach(project => projectsListBox.Items.Add(project));
        }
    }
}
