using System;

namespace taskone
{
    class Program
    {
        static void Main(string[] args)
        {
            int qiymetler = Bolme(15, 5);
            Console.WriteLine(qiymetler);

        }
        static int Bolme( int num1 , int num2)
        {
            int cavab;
            cavab = num1 / num2;
            return cavab;
        }

    
    }
}

