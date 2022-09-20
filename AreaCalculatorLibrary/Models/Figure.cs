using System.ComponentModel.DataAnnotations;

namespace AreaCalculatorLibrary.Models
{
    public abstract class Figure
    {
        public string? Title { get; private set; }

        public Figure(string title)
        { 
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException($"Error: Title can not be empty or have a null value\n" +
                    $"Check your input value");
            }
            else
            {
                Title = title;
            }
        }

        public abstract double CalculateArea();
    }
}