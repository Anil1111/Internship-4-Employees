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
    public partial class EmployeesListForm : Form
    {
        private List<Employee> _employees;
        private EmployeeRepository _employeeRepository;

        public EmployeesListForm(EmployeeRepository employeeRepository)
        {
            InitializeComponent();
            _employeeRepository = employeeRepository;
            RefreshEmployees();
        }

        private void RefreshEmployees()
        {
            employeesListBox.Items.Clear();

            _employees = _employeeRepository.GetAllEmployees();

            _employees.OrderBy(employee => employee.Surname)
                .ThenBy(employee => employee.Name)
                .ToList()
                .ForEach(employee => employeesListBox.Items.Add(employee));

            if (_employees.Count == 0)
            {
                employeeDetailsButton.Visible = false;
                employeeRemoveButton.Visible = false;
                employeesListBox.Visible = false;
                employeesInfoLabel.Visible = true;
            }
            else
            {
                employeeDetailsButton.Visible = true;
                employeeRemoveButton.Visible = true;
                employeesListBox.Visible = true;
                employeesInfoLabel.Visible = false;
            }
        }

        private void EmployeeDetails(object sender, EventArgs e)
        {
            var selectedEmployee = employeesListBox.SelectedItem as Employee;
            if (selectedEmployee == null) return;

            var employeeDetailsForm = new EmployeeDetailsForm(selectedEmployee);
            employeeDetailsForm.ShowDialog();
            _employeeRepository.Edit(employeeDetailsForm.Employee);
            RefreshEmployees();
        }

        private void EmployeeDelete(object sender, EventArgs e)
        {
            var selectedEmployeeToDelete = employeesListBox.SelectedItem as Employee;
            if (selectedEmployeeToDelete == null) return;
            var decisionToDelete = MessageBox.Show($"Jeste li sigurni da želite izbrisati zaposlenika:\n{selectedEmployeeToDelete.ToString()}", "Brisanje zaposlenika", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (decisionToDelete)
            {
                case DialogResult.Yes:
                    _employeeRepository.Delete(selectedEmployeeToDelete);
                    break;

                case DialogResult.No:
                    break;
            }

            RefreshEmployees();
        }
    }
}
