using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoPonto
{
    public class EmployeeManage
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public bool ValidateEmployee(string codigo)
        {
            return employees.Exists(x => x.Codigo == codigo);
        }

        public void RecordAttendance(Employee employee)
        {
            //
        }

        public Employee GetEmployeeByCode(string codigo)
        {
            return employees.Find(e => e.Codigo == codigo);
        }
    }

}
