using System;

// Interface IEquatable<T>: https://msdn.microsoft.com/ru-ru/library/ms131187(v=vs.110).aspx

namespace _20180313_Task1_Vector
{
    public class Vector : IEquatable<Vector>   // Vector - object type for comparison.
    {
        // The coordinates of a point in three-dimensional space
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        /// <summary>
        /// The constructor of the Vector class.
        /// </summary>
        /// <param name="x">The coordinate of the point along the x axis.</param>
        /// <param name="y">The coordinate of the point along the y axis.</param>
        /// <param name="z">The coordinate of the point along the z axis.</param>
        public Vector(double x, double y, double z)
        {
            if (x < 0 && y < 0 && z < 0)
                throw new Exception("This is a test exception that occurs if x, y and z are less than 0\n");

            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Overload the comparison operator ==
        /// </summary>
        /// <param name="vector1">First vektor.</param>
        /// <param name="vector2">First vektor.</param>
        /// <returns>The result of comparing two vectors: true or false.</returns>
        public static bool operator ==(Vector vector1, Vector vector2) => Equals(vector1, vector2);

        /// <summary>
        /// Overload the comparison operator !=
        /// </summary>
        /// <param name="vector1">First vektor.</param>
        /// <param name="vector2">First vektor.</param>
        /// <returns>The result of comparing two vectors: true or false.</returns>
        public static bool operator !=(Vector vector1, Vector vector2) => !Equals(vector1, vector2);

        /// <summary>
        /// Overload the binary operator +
        /// </summary>
        /// <param name="vector1">First vektor.</param>
        /// <param name="vector2">First vektor.</param>
        /// <returns>The result of addition of two vectors.</returns>
        public static Vector operator +(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.X + vector2.X,
                              vector1.Y + vector2.Y,
                              vector1.Z + vector2.Z);
        }

        /// <summary>
        /// Overload the binary operator -
        /// </summary>
        /// <param name="vector1">First vektor.</param>
        /// <param name="vector2">First vektor.</param>
        /// <returns>The result of subtraction of the second vector from the first vector.</returns>
        public static Vector operator -(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.X - vector2.X,
                              vector1.Y - vector2.Y,
                              vector1.Z - vector2.Z);
        }

        /// <summary>
        /// Overload the binary operator *
        /// </summary>
        /// <param name="vector1">First vektor.</param>
        /// <param name="vector2">First vektor.</param>
        /// <returns>The result of multiplying two vectors.</returns>
        public static Vector operator *(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.X * vector2.X,
                              vector1.Y * vector2.Y,
                              vector1.Z * vector2.Z);
        }

        /// <summary>
        /// ToString() method allows you to display a vector as a string.
        /// </summary>
        /// <returns>Vector as a string.</returns>
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }

        /// <inheritdoc />
        /// <summary>
        /// The Equals () method determines whether the given vector is equal to the current vector.
        /// </summary>
        /// <param name="other">Vector for verification.</param>
        /// <returns>Result of checking.</returns>
        public bool Equals(Vector other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z);
        }

        /// <summary>
        /// Equals() method determines whether the given object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to check.</param>
        /// <returns>Result of checking.</returns>
        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            return obj.GetType() == GetType() && Equals((Vector)obj);
        }

        /// <summary>
        /// GetHashCode () method to check the equality of the object.
        /// </summary>
        /// <returns>HashCode of the current object.</returns>
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