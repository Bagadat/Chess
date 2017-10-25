namespace Chess
{
    public class Coordinates
    {
        public int X { get; }
        public int Y { get; }

        public Coordinates(int x, int y)
        {
            Y = y - '1';
            X = x - 'a';
        }
    }
}
