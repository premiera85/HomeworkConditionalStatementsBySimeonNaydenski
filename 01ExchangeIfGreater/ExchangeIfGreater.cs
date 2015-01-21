using System;

    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.WriteLine("Enter a and b : ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = 0;
            if (a > b)
            {
                c = a;
                a = b;
                b = c;
                Console.WriteLine("{0} {1}",a,b);
            }
            else
            {
                Console.WriteLine(a+" "+b);
            }
        }
    }

