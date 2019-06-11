using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects
{
    public class EmployeeRecord
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public double salary { get; set; }
        public EmployeeRecord() { }
        public EmployeeRecord(string Id ,string name , DateTime JoiningDate  ,double salary) {
            this.Id = Id;
            this.Name = name;
            this.JoiningDate = JoiningDate;
            this.salary = salary;

        }
        public EmployeeRecord(string str_Id , string str_name,  string str_date , string str_salary)
        {
            this.Id = str_Id;
            this.Name = str_name;
            this.JoiningDate = DateTime.Parse(str_date);
            this.salary = Double.Parse(str_salary);
             
        }

        public static string[] readTextFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            return lines;
        }
        public static DateTime ConstDate(string yyyymmdd) {

            return DateTime.Parse(yyyymmdd);

        }
        public static bool testpath(string path)
        {

            return File.Exists(path);
        }

    }

}
