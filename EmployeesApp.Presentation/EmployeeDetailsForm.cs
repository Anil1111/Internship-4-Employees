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
    public partial class EmployeeDetailsForm : Form
    {
        public Employee Employee;

        public EmployeeDetailsForm(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
            employeeNameLabel.Text = $"{employeeNameLabel.Text}: {Employee.Name}";
            employeeSurnameLabel.Text = $"{employeeSurnameLabel.Text}: {Employee.Surname}";
            employeeOibLabel.Text = $"{employeeOibLabel.Text}: {Employee.Oib}";
            employeeDateOfBirthLabel.Text = $"{employeeDateOfBirthLabel.Text}: {Employee.DateOfBirth}";
            employeeJobLabel.Text = $"{employeeJobLabel.Text}: {Employee.Job}";
        }
    }
}
