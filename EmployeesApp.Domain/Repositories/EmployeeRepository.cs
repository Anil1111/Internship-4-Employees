using EmployeesApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Domain.Repositories
{
    public class EmployeeRepository
    {
        public List<Employee> GetAllEmployees() => Employee.AllEmployees;
    }
}
