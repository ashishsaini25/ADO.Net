using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeePayrollService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeOperation emp = new EmployeeOperation();
            //   emp.GetAllEmployees();
            //bool result= emp.DeleteEmployee("Ashish");
            //Console.WriteLine(result);
            Employee employee = new Employee();
            employee.Name = "Saif";
            employee.BasicPay = 1000;
            double result = emp.UpdateEmployee(employee);
            Console.WriteLine(result);
        }
    }
}
