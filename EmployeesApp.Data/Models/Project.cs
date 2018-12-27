using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Data.Models
{
    public sealed class Project
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Dictionary<Employee, int> EmployeesAndWorkingTime { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<Project> AllProjects { get; set; }

        public Project(string name, Dictionary<Employee, int> employeesAndWorkingTime, DateTime startDate, DateTime endDate)
        {
            Id = Guid.NewGuid();
            Name = name;
            EmployeesAndWorkingTime = employeesAndWorkingTime;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override string ToString() => $"{Name}({EmployeesAndWorkingTime.Count} radnika), trajanje: {StartDate.ToShortDateString()}-{EndDate.ToShortDateString()}";
    }
}
