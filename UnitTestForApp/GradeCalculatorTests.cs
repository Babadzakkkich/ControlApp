using ControlApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestForApp
{
    [TestClass]
    public class GradeCalculatorTests
    {
        [TestMethod]
        public void Test_Positive_Score_Excellent()
        {
            int module1Score = 22;
            int module2Score = 38;
            int module3Score = 20;

            var result = GradeCalculator.CalculateGrade(module1Score, module2Score, module3Score);

            Assert.AreEqual(80, result.totalScore);
            Assert.AreEqual("5 (отлично)", result.grade);
        }

        [TestMethod]
        public void Test_Positive_Score_Good()
        {
            int module1Score = 15;
            int module2Score = 25;
            int module3Score = 10;

            var result = GradeCalculator.CalculateGrade(module1Score, module2Score, module3Score);

            Assert.AreEqual(50, result.totalScore);
            Assert.AreEqual("4 (хорошо)", result.grade);
        }

        [TestMethod]
        public void Test_Positive_Score_Satisfactory()
        {
            int module1Score = 10;
            int module2Score = 10;
            int module3Score = 10;

            var result = GradeCalculator.CalculateGrade(module1Score, module2Score, module3Score);

            Assert.AreEqual(30, result.totalScore);
            Assert.AreEqual("3 (удовлетворительно)", result.grade);
        }

        [TestMethod]
        public void Test_Positive_Score_Fail()
        {
            int module1Score = 5;
            int module2Score = 5;
            int module3Score = 5;

            var result = GradeCalculator.CalculateGrade(module1Score, module2Score, module3Score);

            Assert.AreEqual(15, result.totalScore);
            Assert.AreEqual("2 (неудовлетворительно)", result.grade);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_Negative_Score_OutOfRange_Module1()
        {
            int module1Score = -1;
            int module2Score = 20;
            int module3Score = 10;

            GradeCalculator.CalculateGrade(module1Score, module2Score, module3Score);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_Negative_Score_OutOfRange_Module2()
        {
            int module1Score = 10;
            int module2Score = 40;
            int module3Score = 10;

            GradeCalculator.CalculateGrade(module1Score, module2Score, module3Score);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_Negative_Score_OutOfRange_Module3()
        {
            int module1Score = 10;
            int module2Score = 20;
            int module3Score = 25;

            GradeCalculator.CalculateGrade(module1Score, module2Score, module3Score);
        }
    }
}
