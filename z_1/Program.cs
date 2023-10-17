using System;

namespace z_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("------------");


            int[] myArray;
            myArray = new int[n];
            for (int i = 0; i < n; i++)
            {

                myArray[i] = int.Parse(Console.ReadLine());

            }

            int min = myArray[0];
            int max = myArray[0];
            int imin = 0;
            int imax = 0;

            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < min)
                {
                    min = myArray[i];
                    imin = i;
                }
                if (myArray[i] > max)
                {
                    max = myArray[i];
                    imax = i;
                }

            }
            Console.WriteLine("Минимальный элемент = " + min);
            Console.WriteLine("Максимальный элемент = " + max);

            int b = 0;

            b = myArray[imax];
            myArray[imax] = myArray[imin];
            myArray[imin] = b;


            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }

        }
    }
}
