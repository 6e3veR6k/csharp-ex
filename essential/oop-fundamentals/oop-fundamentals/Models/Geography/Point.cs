using System;

namespace oop_fundamentals.Models.Geography
{
    public class Point: IComparable
    {
        private int x;
        private int y;
        private string name;

        public int X { get => x; }
        public int Y { get => y; }
        public string Name { get => name; }

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Point firstPoint = obj as Point;

            if(firstPoint != null)
            {
                double firstPointDistanseFromZero = Math.Sqrt(Math.Pow(firstPoint.X, 2) + Math.Pow(firstPoint.Y, 2));
                double thisPointDistanseFromZero = Math.Sqrt(Math.Pow(this.X, 2) + Math.Pow(this.Y, 2));

                return thisPointDistanseFromZero.CompareTo(firstPointDistanseFromZero);
            }
            else
            {
                throw new ArgumentException("Object is not a Point.");
            }
        }
    }
}
