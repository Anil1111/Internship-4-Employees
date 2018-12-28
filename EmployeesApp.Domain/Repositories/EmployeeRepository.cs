using EmployeesApp.Data.Enums;
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
        public EmployeeRepository()
        {
            SeedData();
        }

        private void SeedData()
        {
            new Employee("Ivo", "Jovanovic", DateTime.Now, "1312312421", Job.dizajner, new List<Project>());
            new Employee("Mate", "Jovanovic", DateTime.Now, "1312312421", Job.dizajner, new List<Project>());
            new Employee("Sime", "Jovanovic", DateTime.Now, "1312312421", Job.dizajner, new List<Project>());
        }

        public List<Employee> GetAllEmployees() => Employee.AllEmployees;

        public void Edit(Employee employeeForEdit)
        {
            Employee employeeToDelete = null;

            employeeToDelete = GetAllEmployees()
                .Where(employee => employee.Oib == employeeForEdit.Oib)
                .FirstOrDefault();

            if (employeeForEdit == null)
                return;

            Employee.AllEmployees.Remove(employeeToDelete);
            Employee.AllEmployees.Add(employeeForEdit);
        }

        public void Delete(Employee selectedEmployeeToDelete)
        {
            var employeeToDelete = GetAllEmployees().Where(employee => employee.Oib == selectedEmployeeToDelete.Oib).FirstOrDefault();

            if (employeeToDelete == null) return;

            Employee.AllEmployees.Remove(employeeToDelete);
        }
    }
}
