using System;

namespace ConsoleApp.Viarables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($" cevrenin radiusu : ");
            int qiymet = Sahe(Convert.ToInt32(Console.ReadLine()));
            Console.Write($" cevrenin sahesi : ");
            Console.WriteLine(qiymet);

            Console.WriteLine("-------");

             int qiymet2 = Sahe(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.Write($" duzbucaqlinin sahesi : ");
            Console.WriteLine(qiymet2);

            Console.WriteLine("-------");

            int qiymet3 = Sahe(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.Write($" ucbucagin daxiline cekilmis cevrenin sahesi : ");
            Console.WriteLine(qiymet3);





        }

        static int Sahe( int r  )
        {
             int p = 3;
             int s = p * (r * r);
             return s;
        }
        static int Sahe( int a , int b)
        {
            int s = a * b;
            return s;
        }
        static int Sahe( int r , int a , int b , int c)
        {
            int p = (a + b + c) / 2;
            int s = p * r;
            return s;
        }
    }
}
