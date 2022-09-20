using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaCalculatorLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace AreaCalculatorLibrary
{
    public class Creator
    {
        /// <summary>
        /// Creates a circle object
        /// </summary>
        public void CreateCircle(string titile, double radius)
        {
            Circle circle = new Circle(titile, radius);

            var results = new List<ValidationResult>();
            var context = new ValidationContext(circle);

            if (!Validator.TryValidateObject(circle, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine(circle.CalculateArea());
            }
        }

        /// <summary>
        /// Creates a triangle object
        /// </summary>
        public void CreateTriangle(string titile, double ab, double bc, double ac)
        {
            Triangle triangle = new Triangle(titile, ab, bc, ac);

            var results = new List<ValidationResult>();
            var context = new ValidationContext(triangle);

            if (!Validator.TryValidateObject(triangle, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine(triangle.CalculateArea());
            }
        }
    }
}