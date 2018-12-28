using EmployeesApp.Data.Enums;
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
    public partial class EmployeeEditForm : Form
    {
        public Employee Employee;

        public EmployeeEditForm(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
            employeeNameTextBox.Text =Employee.Name;
            employeeSurnameTextBox.Text = Employee.Surname;
            employeeOibTextBox.Text = Employee.Oib;
            employeeDateOfBirthDateTimePicker.Value = Employee.DateOfBirth;

            foreach (var job in Enum.GetValues(typeof(Job)))
                employeeJobComboBox.Items.Add(job);

            employeeJobComboBox.SelectedItem = employee.Job;
            employeeJobComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
