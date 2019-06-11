using BussinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            //  EmployeeRecord emp = new EmployeeRecord("1" , "anuj" ,new DateTime(2017, 1, 1) ,1000.0);
            //PayrollLibrary.SalaryOperation.calculatesalary(emp);
            int i = 0;
            EmployeeRecord[] emparray = PayrollLibrary.SalaryOperation.ReadTextFile(@"E:\LiveProject\Payroll\Input.txt");
            foreach (var item in emparray)
            {
                PayrollLibrary.SalaryOperation.Writetextfile(@"E:\LiveProject\Payroll\Output.txt", emparray[i]);
                i++;
            }
        }
    }
}
