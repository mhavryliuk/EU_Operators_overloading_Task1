using System;

// https://msdn.microsoft.com/ru-ru/library/ms131187(v=vs.110).aspx

namespace _20180313_Vector
{
    class Vector : IEquatable<Vector>   // Vector - object type for comparison.
    {
        // The coordinates of a point in three-dimensional space
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(double x, double y, double z)
        {
            try
            {
                if (x < 0 && y < 0 && z < 0)
                {
                    throw new Exception("This is a test exception that occurs if x, y and z are less than 0\n");
                }
                else
                {
                    X = x;
                    Y = y;
                    Z = z;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Overload the comparison operator ==
        public static bool operator ==(Vector vector1, Vector vector2)
        {
            return Equals(vector1, vector2);
        }

        // Overload the comparison operator !=
        public static bool operator !=(Vector vector1, Vector vector2)
        {
            return !Equals(vector1, vector2);
        }

        // Overload the binary operator +
        public static Vector operator +(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.X + vector2.X,
                              vector1.Y + vector2.Y,
                              vector1.Z + vector2.Z);
        }

        // Overload the binary operator -
        public static Vector operator -(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.X - vector2.X,
                              vector1.Y - vector2.Y,
                              vector1.Z - vector2.Z);
        }

        // Overload the binary operator *
        public static Vector operator *(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.X * vector2.X,
                              vector1.Y * vector2.Y,
                              vector1.Z * vector2.Z);
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", X, Y, Z);
        }

        public bool Equals(Vector other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z);
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != GetType())
                return false;
            return Equals((Vector)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = X.GetHashCode();
                hashCode = (hashCode * 397) ^ Y.GetHashCode();
                hashCode = (hashCode * 397) ^ Z.GetHashCode();
                return hashCode;
            }
        }
    }
}