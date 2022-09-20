using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AreaCalculatorLibrary.Models
{
    public class Circle : Figure
    {
        public double Radius { get; private set; }

        public Circle(string title, double radius) : base(title)
        {
            if(radius < 0)
            {
                throw new ArgumentException($"Error: Radius can not be less than 0\n" +
                    $"Check your input values");
            }
            else
            {
                Radius = radius;
            }
        }

        public override double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }
    }
}
