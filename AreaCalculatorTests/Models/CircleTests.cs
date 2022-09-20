using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculatorLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod("Positive area calculation test")]
        public void TestCircleCalculateArea_Correct()
        {
            // arrange
            double expected = 153.9;
            Circle circle = new Circle("Circle", 7);

            // act
            double result = circle.CalculateArea();

            // assert
            Assert.AreEqual(expected, result);
        }
    }
}