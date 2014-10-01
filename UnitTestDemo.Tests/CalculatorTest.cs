using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDemo.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add_Input_First_1_Second_2_Return_3() {
            //arrange
            ICalculator target = new Calculator();
            int firstNumber = 1;
            int secondNumber = 2;
            int expected = 3;

            //act
            int actual;
            actual = target.Add(firstNumber, secondNumber);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
