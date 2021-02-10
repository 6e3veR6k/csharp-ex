namespace oop_fundamentals.Models.Geography
{
    public class Point
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
    }
}
