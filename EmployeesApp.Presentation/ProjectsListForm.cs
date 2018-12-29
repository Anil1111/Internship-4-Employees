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

        private void ProjectDetails(object sender, EventArgs e)
        {

            var selectedProject = projectsListBox.SelectedItem as Project;
            if (selectedProject == null) return;

            var projectDetailsForm = new ProjectDetailsForm(selectedProject);
            projectDetailsForm.ShowDialog();
        }

        private void ProjectDelete(object sender, EventArgs e)
        {
            var selectedProjectToDelete = projectsListBox.SelectedItem as Project;
            if (selectedProjectToDelete == null) return;

            var decisionToDelete = MessageBox.Show($"Jeste li sigurni da želite izbrisati projekt:\n{selectedProjectToDelete.ToString()}", "Brisanje projekta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (decisionToDelete)
            {
                case DialogResult.Yes:
                    _projectRespository.Delete(selectedProjectToDelete);
                    break;

                case DialogResult.No:
                    break;
            }

            RefreshProjects();
        }
    }
}
