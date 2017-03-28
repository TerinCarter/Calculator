using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorUnitTestProject
{
    [TestClass]
    public class CalculatorUnitTest
    {
        [TestMethod]
        public void TestAddition()
        {
            CalculatorComponent obj = new CalculatorComponent();
            int result = obj.Add(7, 8);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestSubstraction()
        {
            CalculatorComponent obj = new CalculatorComponent();
            int result = obj.Substract(15, 8);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            CalculatorComponent obj = new CalculatorComponent();
            int result = obj.Multiply(7, 8);
            Assert.AreEqual(56, result);
        }

        [TestMethod]
        public void TestDivision()
        {
            CalculatorComponent obj = new CalculatorComponent();
            double result = obj.Divide(15, 8);
            Assert.AreEqual(1.88, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDivisionByZero()
        {
            CalculatorComponent obj = new CalculatorComponent();
            double result = obj.Divide(15, 0);
        }
    }
}
