using System;

/* Create a class vector on the plane, class fields - vector coordinates.
 * In the class, provide different methods for overloading operations.
 * 
 * Создать класс вектор на плоскости, поля класса - координаты вектора.
 * В классе предусмотреть разные методы перегрузки операций. */

namespace _20180313_Vector
{
    class Program
    {
        static void Main()
        {
            Vector vector1 = new Vector(3, 25, 14);
            Vector vector2 = new Vector(5, 11, 24);

            Console.WriteLine("Demonstration of operator overloading: ==, !=, + and -\n");

            Console.WriteLine($"Coordinates of the first vector: {vector1}");
            Console.WriteLine($"Coordinates of the second vector: {vector2}");
            Console.WriteLine();

            if (vector1 == vector2)
                Console.WriteLine("Vectors are equal");
            else
                Console.WriteLine("Vectors are not equal");
            Console.WriteLine();

            Vector vector3 = vector1 + vector2;
            Vector vector4 = vector1 - vector2;
            Vector vector5 = vector1 * vector2;

            Console.WriteLine($"vector1 + vector2: {vector3}");
            Console.WriteLine($"vector1 - vector2: {vector4}");
            Console.WriteLine($"vector1 * vector2: {vector5}");

            Console.ReadKey();
        }
    }
}