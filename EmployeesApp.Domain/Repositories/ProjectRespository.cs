using EmployeesApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Domain.Repositories
{
    public class ProjectRespository
    {
        public ProjectRespository()
        {
            SeedData();
        }
        private void SeedData()
        {
            new Project("DUMP Days", new Dictionary<Employee, int>(), DateTime.Now, DateTime.Now);
            new Project("Employee app", new Dictionary<Employee, int>(), DateTime.Now, DateTime.Now);
            new Project("Tech talks", new Dictionary<Employee, int>(), DateTime.Now, DateTime.Now);

        }

        public List<Project> GetAllProjects() => Project.AllProjects;
    }
}
