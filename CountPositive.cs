using System;

namespace Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { -4, 2, 0, 2 };
            int result = countPositive(inputArray);
            Console.WriteLine("Expected result is 2, actual result is " + result);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        // If x==null throw NullPointerException
        // else return the number of positive elements in x.
        static int countPositive(int[] x)
        {
            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
