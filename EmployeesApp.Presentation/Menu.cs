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

        public Menu()
        {
            InitializeComponent();
            _employeeRepository = new EmployeeRepository();
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
    }
}
