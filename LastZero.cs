
using System;

namespace Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 0, 1, 0 };
            int result = lastZero(inputArray);
            Console.WriteLine("Expected result is 2, actual result is " + result);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        // If x==null throw NullPointerException
        // else return the index of the last 0 in x.
        // If 0 does not occur in x, return -1.
        static int lastZero(int[] x)
        {
            for (int i = ((x.Length)-1); i >= 0; i--)
            {
                if (x[i] == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
