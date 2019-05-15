﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void Calc_Sum_3_and_4_results_7()
        {
            //Arrange
            var calc = new Calc();

            //Act
            var result = calc.Sum(3, 4);

            //Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Calc_Sum_0_and_0_results_0()
        {
            //Arrange
            var calc = new Calc();

            //Act
            var result = calc.Sum(0, 0);

            //Assert
            Assert.AreEqual(0, result);
        }


        [TestMethod]
        public void Calc_Sum_MAX_and_1_______()
        {
            var calc = new Calc();

            Assert.ThrowsException<OverflowException>(() => calc.Sum(int.MaxValue, 1));

        }

        [TestMethod]
        public void Calc_IsWeekend()
        {
            var calc = new Calc();

            Assert.IsFalse(calc.IsWeekend());//Mo
            Assert.IsFalse(calc.IsWeekend());//Di
            Assert.IsFalse(calc.IsWeekend());//Mi
            Assert.IsFalse(calc.IsWeekend());//Do
            Assert.IsFalse(calc.IsWeekend());//Fr
            Assert.IsTrue(calc.IsWeekend());//Sa
            Assert.IsTrue(calc.IsWeekend());//So

        }
    }
}
