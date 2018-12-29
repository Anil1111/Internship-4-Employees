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
    public partial class Menu : Form
    {
        private EmployeeRepository _employeeRepository;
        private ProjectRespository _projectRepository;

        public Menu()
        {
            InitializeComponent();
            _employeeRepository = new EmployeeRepository();
            _projectRepository = new ProjectRespository();
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void EmployeesList(object sender, EventArgs e)
        {
            var employeesListForm = new EmployeesListForm(_employeeRepository);
            employeesListForm.ShowDialog();
        }

        private void CreateEmployee(object sender, EventArgs e)
        {
            var employeeCreateForm = new EmployeeCreateForm(_projectRepository);
            employeeCreateForm.ShowDialog();
        }

        private void ProjectsList(object sender, EventArgs e)
        {
            var projectsListForm = new ProjectsListForm(_projectRepository);
            projectsListForm.ShowDialog();
        }

        private void CreateProject(object sender, EventArgs e)
        {
            var projectCreateForm = new ProjectCreateForm();
            projectCreateForm.ShowDialog();
        }
    }
}
