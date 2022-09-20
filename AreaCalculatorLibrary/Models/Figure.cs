using System.ComponentModel.DataAnnotations;

namespace AreaCalculatorLibrary.Models
{
    public abstract class Figure
    {
        //[Required(ErrorMessage = "The name of the figure is missing!")]
        public string Title { get; private set; }

        public Figure(string title)
        {
            Title = title;
        }

        public abstract double CalculateArea();
    }
}