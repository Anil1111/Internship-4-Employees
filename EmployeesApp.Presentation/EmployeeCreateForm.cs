﻿using EmployeesApp.Data.Enums;
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
    public partial class EmployeeCreateForm : Form
    {
        public Employee Employee;
        private ProjectRespository _projectRepository;

        public EmployeeCreateForm(ProjectRespository projectRepository)
        {
            InitializeComponent();

            _projectRepository = projectRepository;

            foreach (var job in Enum.GetValues(typeof(Job)))
                employeeJobComboBox.Items.Add(job);

            employeeJobComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _projectRepository.GetAllProjects().ForEach(project => employeeProjectsCheckedListBox.Items.Add(project));
        }
    }
}
