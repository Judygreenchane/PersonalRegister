using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    internal class Payroll
    {
        private List<Employee> employees { get; set; }
        public Payroll()
        {
            employees = new List<Employee>();
        }
        public void AddEmployees(string name, int salary)
        {
            employees.Add(new Employee(name, salary));
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return employees.ToArray();
        }
    }
}
