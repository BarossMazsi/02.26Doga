using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using program;

 

namespace UnitTestProject
{
    [TestClass]
    public class PowerCalculatorTests
    {
        [TestMethod]
        public void TestPositiveExponent()
        {
            
            int basee = 2;
            int exponent = 3;

            int result = PowerCalculator.CalculatePower(basee, exponent);

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestZeroExponent()
        {
           
            int basee = 5;
            int exponent = 0;

            int result = PowerCalculator.CalculatePower(basee, exponent);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNegativeExponent()
        {
           
            int basee = 2;
            int exponent = -2;

            PowerCalculator.CalculatePower(basee, exponent);

           
        }


        [TestMethod]
        public void TestZeroBaseZeroExponent()
        {

            int basee = 0;
            int exponent = 0;

            int result = PowerCalculator.CalculatePower(basee, exponent);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestOneBaseAnyExponent()
        {

            int basee = 1;
            int exponent = 100;

            int result = PowerCalculator.CalculatePower(basee, exponent);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestNegativeBaseEvenExponent()
        {

            int basee = -3;
            int exponent = 4;

            int result = PowerCalculator.CalculatePower(basee, exponent);

            Assert.AreEqual(81, result);
        }
        [TestMethod]
        public void TestNegativeBaseOddExponent()
        {

            int basee = -2;
            int exponent = 3;

            int result = PowerCalculator.CalculatePower(basee, exponent);

            Assert.AreEqual(-8, result);
        }





    }
}
