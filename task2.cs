using System;

namespace taskone
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var deyerler = Repeat(Console.ReadLine() ,Convert.ToInt32(Console.ReadLine()) );
            
            Console.WriteLine(deyerler);
            
        }
        static string Repeat(string word, int num)
        {
            var result = word;

            for (var i = 0; i < num - 1; i++)
            {
                result += word;
            }

            return result;
            
        }
    }
}

