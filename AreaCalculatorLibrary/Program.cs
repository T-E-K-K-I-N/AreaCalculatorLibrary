using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaCalculatorLibrary.Models;

namespace AreaCalculatorLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new Creator();

            creator.CreateCircle("Circle", 7);
            creator.CreateTriangle("Triangle", 7, 7, 6);
        }
    }
}
