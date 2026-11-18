namespace CartesianSpaces
{
    public enum Quarter : byte { Start, LayOnX, LayOnY, First, Second, Third, Fourth, OutSpaceAndTime }
    public class Point<T> : IEquatable<Point<T>>, IComparable<Point<T>> where T : struct, INumber<T>
    {
        private readonly T x;
        private readonly T y;
        private readonly double range;
        private readonly Quarter quarter;

        public T X { get { return x; } }
        public T Y { get { return y; } }
        public double Range { get { return range; } }
        public Quarter Quarter { get { return quarter; } }

        public Point(Point<T> point) : this(point.x, point.y) { }
        public Point() : this(default, default) { }
        public Point(T both) : this(both, both) { }
        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
            quarter = GetQuarter(x, y);
            range = GetRange(x, y);
        }

        public static Quarter GetQuarter(T x, T y)
        {
            if (x == T.Zero && y == T.Zero) return Quarter.Start;
            if (x == T.Zero) return Quarter.LayOnY;
            if (y == T.Zero) return Quarter.LayOnX;
            if (x > T.Zero && y > T.Zero) return Quarter.First;
            if (x < T.Zero && y > T.Zero) return Quarter.Second;
            if (x < T.Zero && y < T.Zero) return Quarter.Third;
            return Quarter.Fourth;
        }
        public static Quarter GetQuarter(Point<T>? point)
        {
            if (point is null) throw new ArgumentNullException(nameof(point));
            return GetQuarter(point.x, point.y);
        }
        public static double GetRange(T x, T y)
        {
            var _x = double.CreateChecked(x);
            var _y = double.CreateChecked(y);
            return Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2));
        }
        public static double GetRange(Point<T>? point)
        {
            if (point is null) throw new ArgumentNullException(nameof(point));
            return GetRange(point.x, point.y);
        }
        public static bool Equals(Point<T>? p1, Point<T>? p2)
        {
            if (ReferenceEquals(p1, p2)) return true;
            if (p1 is null) return false;
            if (p2 is null) return false;
            if (p1.Range == p2.Range) return true;
            return false;
        }
        public static int CompareTo(Point<T>? p1, Point<T>? p2)
        {
            if (ReferenceEquals(p1, p2)) return 0;
            if (p1 is null) return -1;
            if (p2 is null) return 1;
            var r1 = p1.Range;
            var r2 = p2.Range;
            if (r1 < r2) return -1;
            if (r1 > r2) return 1;
            return 0;
        }

        public int CompareTo(Point<T>? point)
        {
            return CompareTo(this, point);
        }
        public bool Equals(Point<T>? point)
        {
            return Equals(this, point);
        }

        public override string ToString()
        {
            return $"X: {x}, Y: {y}";
        }
        public override bool Equals(object? obj)
        {
            var point = obj as Point<T>;
            return Equals(this, point);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(range);
        }

        public static bool operator ==(Point<T>? p1, Point<T>? p2)
        {
            return Equals(p1, p2);
        }
        public static bool operator !=(Point<T>? p1, Point<T>? p2)
        {
            return !Equals(p1, p2);
        }

        public static bool operator <(Point<T>? p1, Point<T>? p2)
        {
            return CompareTo(p1, p2) < 0;
        }
        public static bool operator >(Point<T>? p1, Point<T>? p2)
        {
            return CompareTo(p1, p2) > 0;
        }
        public static bool operator <=(Point<T>? p1, Point<T>? p2)
        {
            return CompareTo(p1, p2) <= 0;
        }
        public static bool operator >=(Point<T>? p1, Point<T>? p2)
        {
            return CompareTo(p1, p2) >= 0;
        }

        public static Point<T> operator +(Point<T>? p1, Point<T>? p2)
        {
            if (p1 is null) throw new ArgumentNullException(nameof(p1));
            if (p2 is null) throw new ArgumentNullException(nameof(p2));
            return new Point<T>(p1.x + p2.x, p1.y + p2.y);
        }
        public static Point<T> operator -(Point<T>? p1, Point<T>? p2)
        {
            if (p1 is null) throw new ArgumentNullException(nameof(p1));
            if (p2 is null) throw new ArgumentNullException(nameof(p2));
            return new Point<T>(p1.x - p2.x, p1.y - p2.y);
        }

        public static Point<T> operator +(Point<T>? point, T value)
        {
            if (point is null) throw new ArgumentNullException(nameof(point));
            return new Point<T>(point.x + value, point.y + value);
        }
        public static Point<T> operator +(T value, Point<T>? point)
        {
            if (point is null) throw new ArgumentNullException(nameof(point));
            return new Point<T>(point.x + value, point.y + value);
        }

        public static Point<T> operator -(Point<T>? point, T value)
        {
            if (point is null) throw new ArgumentNullException(nameof(point));
            return new Point<T>(point.x - value, point.y - value);
        }
        public static Point<T> operator -(T value, Point<T>? point)
        {
            if (point is null) throw new ArgumentNullException(nameof(point));
            return new Point<T>(value - point.x, value - point.y);
        }

        // Этот оператор переопределил просто так, пусть будет
        public static implicit operator (T X, T Y)(Point<T>? point)
        {
            if (point is null) throw new ArgumentNullException(nameof(point));
            return (point.x, point.y);
        }
    }
}