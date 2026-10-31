using System;

namespace aaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hello = createArray(100, 100, 900);

            int[] arrayMoreThan500 = new int[99];

            displayArray(hello);

            int a = 0; int b = 0; int c = 0;

            int counter = 0;

            int sum = 0; int sum2 = 0;

            int min = hello[0]; int max = hello[0];

            bool has899 = false;

            for (int i = 0; i < hello.Length; i++)
            {
                if (hello[i] > 500)
                {
                    arrayMoreThan500[a] = hello[i];
                    a++;
                }
                if (hello[i] % 5 == 0)
                {
                    b++;
                }
                if (hello[i] % 2 == 0)
                {
                    c++;
                }

                sum += hello[i];
                if (hello[i] > max)
                {
                    max = hello[i];

                }
                if (hello[i] < min)
                {
                    min = hello[i];
                }
                if (hello[i] >= 500 && hello[i] <= 600)
                {
                    counter++;
                }
                if (hello[i] == 899)
                {
                    has899 = true;
                }
                if (hello[i] >= 100 && hello[i] <= 200)
                {
                    sum2 += hello[i];

                }
            }
            Console.WriteLine();

            displayArray(arrayMoreThan500);

            Console.WriteLine("\nSum of all elements = " + sum);

            double avg = sum / 100;

            Console.WriteLine("\nAverage of all elements = " + avg);

            int lessThanAverage = 0;

            for (int i = 0; i < hello.Length; i++)
            {

                if (hello[i] < avg)
                {
                    lessThanAverage++;
                }
            }

            Console.WriteLine("\nLess Than Average of all elements = " + lessThanAverage);

            Console.WriteLine("\nDivided by 5 of all elements: ");

            displayArray(arrayMod5);

            Console.WriteLine("\nEven numbers:");

            displayArray(arrayEven);

            Console.WriteLine("\nMax num = " + max);

            Console.WriteLine("\nMin num = " + min);

            Console.WriteLine("\nNum between 500 and 600  = " + counter);

            if (has899)
            {
                Console.WriteLine("\nWow, you got 899, thats rare!!!");
            }
            else
            {
                Console.WriteLine("\nYou didnt get the 899");
            }

            Console.WriteLine("\nSum between 100 and 200  = " + sum2);
        }

        static int[] createArray(int arrayLength, int minNum, int maxNum)
        {
            Random rnd = new Random();

            int[] array = new int[arrayLength];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(minNum, maxNum);
            }
            return array;
        }
        static void displayArray(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {

                    if (i != 0)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(array[i]);
                }
            }
        }
    }
}
