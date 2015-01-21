using System;

    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter a, b, c, d ,e : ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            if (a > b && a > c && a > d && a > e)
            {
                Console.WriteLine("biggest is " + a);
            }
            else if (b > a && b > c && b > d && b > e)
            {
                Console.WriteLine("biggest is " + b);
            }
            else if (c > a && c > b && c > d && c > e)
            {
                Console.WriteLine("biggest is " + c);
            }
            else if (d > a && d > b && d > c && d > e)
            {
                Console.WriteLine("biggest is " + d);
            }
            else
            {
                Console.WriteLine("biggest is " + e);
            }
        }
    }

