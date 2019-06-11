using System;
using BussinessObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayrollLibrary;

namespace TestPayroll
{
    [TestClass]
    public class UnitTest1
    {
        EmployeeRecord emp = new EmployeeRecord("1", "anuj", new DateTime(2017, 1, 1), 2000.0);
        [TestMethod]
        public void TestCalculateSalary()
        {
            double expected = 2200.00;

            
            double actual =SalaryOperation.calculatesalary(emp);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_testpath()
        {
            Boolean expected, actual;
            expected = true;
            actual = EmployeeRecord.testpath(@"E:\LiveProject\Payroll\Output.txt");
            Assert.AreEqual(expected, actual);
            


        }
        [TestMethod]
        public void Test_Datecheck()
        {
            Boolean expected, actual;
            expected = true;
            actual = SalaryOperation.Datecheck(emp.JoiningDate, EmployeeRecord.ConstDate("2018 1 1"));
            Assert.AreEqual(expected, actual);



        }

        [TestMethod]
        public void Test_Writetextfile()
        {
            Boolean expected, actual;
            expected = true;
            actual = SalaryOperation.Writetextfile(@"E:\LiveProject\Payroll\Test.txt", emp);
            Assert.AreEqual(expected, actual);



        }
    }
}
