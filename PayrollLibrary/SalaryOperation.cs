using BussinessObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PayrollLibrary
{
    public class SalaryOperation
    {
        public static double extrasalary = 0.0;
        public static bool Datecheck(DateTime vardate, DateTime constdate)
        {

            return (constdate > vardate);

        }
        public static double calculatesalary(EmployeeRecord emp)
        {
            if (Datecheck(emp.JoiningDate, EmployeeRecord.ConstDate("2018 1 1")))
            {
                return (SalaryOperation.extrasalary = emp.salary * 1.1);
            }
            else
            {
                return (SalaryOperation.extrasalary = emp.salary);
            }

        }



        public static bool Writetextfile(string output_filepath, EmployeeRecord employee) {
            if (EmployeeRecord.testpath(output_filepath))
            {
                double salary = SalaryOperation.calculatesalary(employee);
                string creattext = employee.Id + "\t" + employee.Name + "\t" + employee.JoiningDate.ToString("MM / dd / yyyy") + "\t" + employee.salary + "\t" + salary;
                string createText = creattext + Environment.NewLine;
                File.AppendAllText(output_filepath, createText);
                return true;
            }
            else
            {
                return false;
            }

        }
        public static EmployeeRecord[] ReadTextFile(string input_filepath) {
            int k = 0;
           
            String[] lines = EmployeeRecord.readTextFile(input_filepath);
            EmployeeRecord[] emparray = new EmployeeRecord[lines.Length];
          
            foreach (var line in lines)
            {
               
                string []words = line.Split('\t');
                EmployeeRecord emp1 = new EmployeeRecord();
                emp1.Id = words[0];
                emp1.Name = words[1];
                emp1.JoiningDate = Convert.ToDateTime(words[2]);
                emp1.salary = Convert.ToDouble(words[3]);

                // EmployeeRecord emp = new EmployeeRecord(words[0].ToString(), words[1].ToString(), Convert.ToDateTime(words[2]), Convert.ToDouble(words[3]);


                emparray[k] = emp1;
                k++;
            }
            return emparray;

        }

    }
}
