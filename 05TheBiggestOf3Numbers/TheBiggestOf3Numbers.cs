using System;

    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter a , b , c : ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a >= b && a >= c)
            {
                Console.WriteLine("The bigest number is : "+a);
            }
            else if (a >= b && a <= c)
            {
                Console.WriteLine("The bigest number is : " + c);
            }
            else if (a <= b && b <= c)
            {
                Console.WriteLine("The bigest number is : " + c);
            }
            else 
            {
                Console.WriteLine("The bigest number is : " + b);
            }
        }
    }

