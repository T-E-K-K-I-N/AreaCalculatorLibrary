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
        [Required(ErrorMessage = "There must be a value for the Radius")]
        [Range(0, 100, ErrorMessage = "An incorrect value was entered for the Radius")]
        public double Radius { get; private set; }

        public Circle(string title, double radius) : base(title)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }
    }
}
