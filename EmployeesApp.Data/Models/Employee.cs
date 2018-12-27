using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Data.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Oib { get; set; }
        public Job Job { get; set; }

        public List<Project> Projects { get; set; }

        public Employee(string name, string surname, DateTime dateOfBirth, string oib, Job job, List<Project> projects)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Oib = oib;
            Job = job;
            Projects = projects;
        }

        public override string ToString() => $"{Name} {Surname}({Job}), OIB:{Oib}";
    }
}
