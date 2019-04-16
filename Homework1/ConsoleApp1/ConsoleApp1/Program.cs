using System;
using System.Runtime.InteropServices;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 11, 32, 13, 4, 8, 55, 21, 88, 99 };

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[3]);
            //Console.WriteLine(numbers[4]);
            //Console.WriteLine(numbers[5]);
            //Console.WriteLine(numbers[6]);

            Console.WriteLine("-----------");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        private static void TablaInmultirii()
        {
            Console.WriteLine("Enter the number:");
            int numar = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(numar + " * " + i + " = " + numar * i);

                Console.WriteLine("{0} * {1} = {2}", numar, i, numar * i);

                Console.WriteLine($"{numar} * {i} = {numar * i}");
            }
        }

        private static void NumericalOperations()
        {
            int numar1 = Convert.ToInt32(Console.ReadLine());
            int numar2 = Convert.ToInt32(Console.ReadLine());

            if (numar1 == 0)
            {
                Console.WriteLine("Nu poti imparti la 0");
            }
            else
            {
                Console.WriteLine("numar2/numar1=" + numar2 / numar1);
            }

            int rezultatulInmultirii = numar2 * numar1;

            Console.WriteLine("Inmultire:" + rezultatulInmultirii);

            Console.ReadLine();
        }
    }
}
