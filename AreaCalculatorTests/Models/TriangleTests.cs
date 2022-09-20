using AreaCalculatorLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod("Positive area calculation test")]
        public void TriangleTestCalculateArea_Correct()
        {
            // arrange
            double expected = 11.6;
            Triangle triangle = new Triangle("Triangle", 8, 4, 6);

            // act
            double result = triangle.CalculateArea();

            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod("Negative test for whether a triangle is rectangular")]
        public void TriangleTestIsRectangular_ReturnFalse()
        {
            // arrange
            Triangle triangle = new Triangle("Triangle", 8, 4, 6);

            // act
            var result = triangle.IsRectangular();

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod("Positive test for whether a triangle is rectangular")]
        public void TriangleTestIsRectangular_ReturnTrue()
        {
            // arrange
            Triangle triangle = new Triangle("Triangle", 5, 4, 3);

            // act
            var result = triangle.IsRectangular();

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod("Validation test")]
        public void TriangleTestInput_Incorrect()
        {
            // arrange
            Triangle triangle;

            // assert
            Assert.ThrowsException<ArgumentException>(() => triangle = new Triangle("Triangle", -1, 5, 7));
            Assert.ThrowsException<ArgumentException>(() => triangle = new Triangle("Triangle", 66, 4, 6));
            Assert.ThrowsException<ArgumentException>(() => triangle = new Triangle(null, 5, 4, 6));
        }
    }
}