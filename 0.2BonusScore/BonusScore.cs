using System;

    class BonusScore
    {
        static void Main()
        {
            Console.Write("Enter the score in the range of 1 to 9 : ");
            int score = int.Parse(Console.ReadLine());
            if (score >=1 && score <=3)
            {
                Console.WriteLine(score*10);
            }
            if (score >= 4 && score <= 6)
            {
                Console.WriteLine(score*100);
            }
            if (score >= 7 && score <= 9)
            {
                Console.WriteLine(score*1000);
            }
            if (score > 9 || score <= 0)
            {
                Console.WriteLine("Invalid score");
            }
        }
    }

