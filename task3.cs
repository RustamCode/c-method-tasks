using System;

namespace taskfive
{
    class Program
    {
        static void Main(string[] args)
        {

            int result = SumMassive(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(result);
        }

        static int SumMassive(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

    }
}
