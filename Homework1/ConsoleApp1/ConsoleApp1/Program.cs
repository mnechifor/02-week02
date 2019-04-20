using System;
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //OperatiiMatematice.Suma(3, 7);

           //FindDuplicates();

           // LinkedListExample();


           //DuplicatesInList();
        }

        private static void DuplicatesInList()
        {
//find duplicates in list
            List<double> list = new List<double>() {10, 11, 50};

            list.Add(10);
            list.Add(20);
            list.Add(11.3);
            list.Add(20);

            List<double> duplicate = new List<double>();

            foreach (var element in list)
            {
                if (!duplicate.Contains(element))
                {
                    duplicate.Add(element);
                }
            }

            foreach (var d in duplicate)
            {
                Console.Write(d + " ");
            }
        }

        private static void LinkedListExample()
        {
            LinkedList<int> list = new LinkedList<int>();

            LinkedListNode<int> firstNode = new LinkedListNode<int>(10);

            list.AddFirst(firstNode);

            LinkedListNode<int> node2 = new LinkedListNode<int>(20);

            list.AddAfter(firstNode, node2);


            foreach (var i in list)
            {
            }
        }

        private static void FindDuplicates()
        {
            int[] arr1 = new int[7] {1, 4, 5, 7, 82, 3, 5};
            int[] arr2 = new int[8] {4, 4, 7, 3, 32, 4, 7, 9};

            int[] duplicates = CommonElementsOfArray.Duplicates(arr1, arr2);

            foreach (var duplicate in duplicates)
            {
                Console.Write(duplicate + " ");
            }

           // int[]intersection = arr1.Intersect(arr2).ToArray();
        }

        public static void TablaInmultirii(int n)
        {
            Console.WriteLine("Enter the number:");
            int numar = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
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
