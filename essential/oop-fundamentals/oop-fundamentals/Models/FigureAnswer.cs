using oop_fundamentals.Interfaces;
using oop_fundamentals.Models.Geography;
using System;

namespace oop_fundamentals.Models
{
    public class FigureAnswer : ITaskAnswer
    {
        public void Process()
        {
            GetTriangle();
            Console.WriteLine(new string('*', 50));
            GetRectangle();
            Console.WriteLine(new string('*', 50));
            GetPentagon();
        }

        private void GetTriangle()
        {
            Point point = new Point(10, 1, "A");
            Point point1 = new Point(-2, 3, "B");
            Point point2 = new Point(1, 5, "C");

            Figure figure = new Figure(point, point1, point2);

            Console.WriteLine($"Triangle? -> {figure.Name}, it has perimeter that equal {figure.Perimeter}.");
        }
        private void GetRectangle()
        {
            Point point = new Point(10, 4, "A");
            Point point1 = new Point(1, 0, "B");
            Point point2 = new Point(10, 0, "C");
            Point point3 = new Point(1, 4, "D");

            Figure figure = new Figure(point, point1, point2, point3);

            Console.WriteLine($"Rectangle? -> {figure.Name}, it has perimeter that equal {figure.Perimeter}.");
        }

        private void GetPentagon()
        {
            Point point = new Point(10, 4, "A");
            Point point1 = new Point(1, 0, "B");
            Point point2 = new Point(10, 0, "C");
            Point point3 = new Point(1, 4, "D");
            Point point4 = new Point(13, -3, "F");

            Figure figure = new Figure(point, point1, point2, point3, point4);

            Console.WriteLine($"Pentagon? -> {figure.Name}, it has perimeter that equal {figure.Perimeter}.");
        }
    }
}
