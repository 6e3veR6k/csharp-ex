using System;

namespace oop_fundamentals.Models.Geography
{
    public class Figure
    {
        private Point[] points;
        private double perimeter;
        public double Perimeter
        {
            get
            {
                PerimeterCalculator();
                return perimeter;
            }
        }

        public string Name
        {
            get
            {
                return Enum.GetName(typeof(FigureTypes), points.Length);
            }
        }


        private enum FigureTypes
        {
            Point,
            Line,
            Triangle,
            Quadrilateral,
            Pentagon,
            Hexagon
        }

        public Figure(Point point, Point point1, Point point2) : this(point, point1, point2, null, null)
        {
            Point[] _points = new Point[3];
            Array.Copy(points, 0, _points, 0, 3);
            points = _points;
        }

        public Figure(Point point, Point point1, Point point2, Point point3) : this(point, point1, point2, point3, null)
        {
            Point[] _points = new Point[4];
            Array.Copy(points, 0, _points, 0, 4);
            points = _points;
        }

        public Figure(Point point, Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[5];
            points[0] = point;
            points[1] = point1;
            points[2] = point2;
            points[3] = point3;
            points[4] = point4;
        }

        private double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }

        private void PerimeterCalculator()
        {
            Array.Sort(points);
            int lastIndex = points.Length - 1;

            this.perimeter = LengthSide(points[lastIndex], points[0]);

            for (int i = 1; i <= lastIndex; i++)
            {
                this.perimeter += LengthSide(points[i - 1], points[i]);
            }

        }
    }
}
