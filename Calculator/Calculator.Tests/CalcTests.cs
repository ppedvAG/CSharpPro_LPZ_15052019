using System;
using System.Collections.Generic;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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

            using (ShimsContext.Create())
            {
                System.Fakes.ShimDateTime.NowGet = () => new DateTime(2019, 5, 13);
                Assert.IsFalse(calc.IsWeekend());//Mo
                System.Fakes.ShimDateTime.NowGet = () => new DateTime(2019, 5, 14);
                Assert.IsFalse(calc.IsWeekend());//Di
                System.Fakes.ShimDateTime.NowGet = () => new DateTime(2019, 5, 15);
                Assert.IsFalse(calc.IsWeekend());//Mi
                System.Fakes.ShimDateTime.NowGet = () => new DateTime(2019, 5, 16);
                Assert.IsFalse(calc.IsWeekend());//Do
                System.Fakes.ShimDateTime.NowGet = () => new DateTime(2019, 5, 17);
                Assert.IsFalse(calc.IsWeekend());//Fr
                System.Fakes.ShimDateTime.NowGet = () => new DateTime(2019, 5, 18);
                Assert.IsTrue(calc.IsWeekend());//Sa
                System.Fakes.ShimDateTime.NowGet = () => new DateTime(2019, 5, 19);
                Assert.IsTrue(calc.IsWeekend());//So
                System.Fakes.ShimDateTime.NowGet = () => new DateTime(2019, 5, 20);

            }
        }
    }
}
