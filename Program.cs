using System;

/** <remark>
 * Create a class vector on the plane, class fields - vector coordinates.
 * In the class, provide different methods for overloading operations.
</remark> */

namespace _20180313_Task1_Vector
{
    internal class Program
    {
        private static void Main()
        {
            try
            {
                var vector1 = new Vector(3, 25, 14);
                var vector2 = new Vector(5, 11, 24);

                Console.WriteLine("Demonstration of operator overloading: ==, !=, + and -\n");

                Console.WriteLine($"Coordinates of the first vector: {vector1}");
                Console.WriteLine($"Coordinates of the second vector: {vector2}");
                Console.WriteLine();

                Console.WriteLine(vector1 == vector2 ? "Vectors are equal\n" : "Vectors are not equal\n");

                var vector3 = vector1 + vector2;
                var vector4 = vector1 - vector2;
                var vector5 = vector1 * vector2;

                Console.WriteLine($"vector1 + vector2: {vector3}");
                Console.WriteLine($"vector1 - vector2: {vector4}");
                Console.WriteLine($"vector1 * vector2: {vector5}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}