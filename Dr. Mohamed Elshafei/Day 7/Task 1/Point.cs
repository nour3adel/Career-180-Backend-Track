namespace Day7
{
    public class _3DPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public _3DPoint()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public _3DPoint(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"({X} , {Y} , {Z})";
        }

        public override bool Equals(object? obj)
        {
            if (obj is _3DPoint p)
                return X == p.X && Y == p.Y && Z == p.Z;

            return false;
        }

        public static bool operator ==(_3DPoint p1, _3DPoint p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(_3DPoint p1, _3DPoint p2)
        {
            return !p1.Equals(p2);
        }
    }
}

