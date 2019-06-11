using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayrollLibrary;

namespace PayRollTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckFileTestMethod()
        {
            //Arrange Test
            bool Result;

            //Act Test
            Result =PayrollOperations.testFilePath(@"E:\testfile.txt");

            //Assert Test
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ReadFileTestMethod()
        {
            //Arrange Test
            string[] Result;

            //Act Test
            Result = PayrollOperations.readTextFile(@"E:\testfile.txt");

            //Assert Test
            Assert.AreEqual(4, Result.Length);
        }

        [TestMethod]
        public void ReadLinesTestMethod()
        {
            //Arrange Test
            string Result;
            string ExpResult;
            string Line = "102\tankur\t11-07-2016\t40000\\r\\n";


            //Act Test
            Result = PayrollOperations.readLines(Line);
            ExpResult = PayrollOperations.readLines(Line);

            //Assert Test
            Assert.AreEqual(ExpResult, Result);
        }


        [TestMethod]
        public void CheckDateTestMethod()
        {
            //Arrange Test
            bool Result;

            //Act Test
            Result = PayrollOperations.compareDate("10-12-2017");

            //Assert Test
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void SalaryIncreamentTestMethod()
        {
            //Arrange Test
            string salary = "30000";
            double Result;

            //Act Test
            Result = PayrollOperations.calculateNewSalary(salary);

            //Assert Test
            Assert.AreEqual(33000, Result);
        }

        [TestMethod]
        public void WriteFileTestMethod()
        {
            //Arrange Test
            string filepath = @"E:\testfile.txt";
            string Result, ExpResult;

            //Act Test
            ExpResult = "101\tsahil\t10-12-2017\t30000\t33000\r\n102\tankur\t11-07-2016\t40000\t44000\r\n102\tankur\t21-07-2018\t40000\t40000\r\n";
            Result = PayrollOperations.writeToFile(filepath);

            //Assert Test
            Assert.AreEqual(ExpResult, Result);
        }
    }

}
