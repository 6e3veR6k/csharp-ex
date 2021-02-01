using oop_fundamentals.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace oop_fundamentals.Models
{
    class RectangleAnswer : ITaskAnswer
    {
        public void Process()
        {
            double rectangleFirstSide = GetUserValue();
            Console.WriteLine($"a = {rectangleFirstSide}");

            double rectangleSecondSide = GetUserValue();
            Console.WriteLine($"b = {rectangleSecondSide}");

            Rectangle rectangle = new Rectangle(rectangleFirstSide, rectangleSecondSide);

            Console.WriteLine($"Your rectangle has Area: {rectangle.Area} and Perimeter: {rectangle.Perimeter}");
        }

        private static double GetUserValue()
        {
            double rectangleFirstSide;
            UserInput consoleInput = new UserInput("Enter rectangle side: ");
            consoleInput.IsValidValue += (x => x > 0 && !Double.IsInfinity(x) && x <= 100);
            consoleInput.GetUserValue(out rectangleFirstSide);
            return rectangleFirstSide;
        }
    }
}
