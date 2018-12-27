﻿using System;
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
        public Menu()
        {
            InitializeComponent();
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void EmployeesList(object sender, EventArgs e)
        {
            var employeesListForm = new EmployeesListForm();
            employeesListForm.ShowDialog();
        }
    }
}
