using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AreaCalculatorLibrary.Models
{
    public class Triangle : Figure
    {
        public double AB { get; private set; }

        public double BC { get; private set; }

        public double AC { get; private set; }

        public Triangle (string title, double ab, double bc, double ac ) : base(title)
        {
            if (ab < 0 || bc < 0 || ac < 0) 
            { 
                throw new ArgumentException($"Error: Side can not be less than 0\nCheck your input values"); 
            }
            else if (ab > (bc + ac) || bc > (ab + ac) || ac > (ab + bc))
            {
                throw new ArgumentException($"Error: Your side greater than summary of two another sides\n" +
                    $"Check your input values");
            }
            else
            {
                AB = ab;
                BC = bc;
                AC = ac;
            }
        }
        /// <summary>
        /// Area calculation method
        /// </summary>
        public override double CalculateArea()
        {
            double p = (AB + BC + AC) / 2;
            double result = Math.Round(Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC)), 1);
            return result;
        }

        /// <summary>
        /// Checking whether a triangle is rectangular
        /// </summary>
        public bool IsRectangular()
        {
            bool check = (AB == Math.Sqrt(Math.Pow(BC, 2) + Math.Pow(AC, 2))
                || BC == Math.Sqrt(Math.Pow(AB, 2) + Math.Pow(AC, 2))
                || AC == Math.Sqrt(Math.Pow(AB, 2) + Math.Pow(BC, 2)));

            return check;
        }
    }
}
