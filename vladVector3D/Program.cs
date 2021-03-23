using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vladVector3D
{
    class Program
    {
        public static Vector3D Init(int x, int y, int z) => new Vector3D(x, y, z);

        public static void Read()
        {
            Console.Write("Введите X: ");
            int.TryParse(Console.ReadLine(), out int x);
            Console.Write("Введите Y: ");
            int.TryParse(Console.ReadLine(), out int y);
            Console.Write("Введите Z: ");
            int.TryParse(Console.ReadLine(), out int z);

            Vector3D vector1 = Init(x, y, z);

            Console.Write("Введите X: ");
            int.TryParse(Console.ReadLine(), out x);
            Console.Write("Введите Y: ");
            int.TryParse(Console.ReadLine(), out y);
            Console.Write("Введите Z: ");
            int.TryParse(Console.ReadLine(), out z);

            Vector3D vector2 = Init(x, y, z);
            Console.WriteLine("Vector 1: ");
            Display(vector1);
            Console.WriteLine("Vector 2: ");
            Display(vector2);
            vector1++;
            vector2++;
            Vector3D res = vector1.SumOfVectors(vector2);
            Display(res);

        }
        public static void Display(Vector3D vector)
        {
            Console.WriteLine(vector);
        }

        static void Main(string[] args)
        {
            Read();
        }
    }
}
