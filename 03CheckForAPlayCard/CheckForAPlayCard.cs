﻿using System;

    class CheckForAPlayCard
    {
        static void Main()
        {
            Console.Write("Enter a playing card : ");
            string playingCard = Console.ReadLine();
            switch (playingCard)
            {
                case "2":
                case "3":
                case "4":`
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "A":
                case "J":
                case "K":
                case "Q": Console.WriteLine("yes");
                    break;
                default: Console.WriteLine("no");
                    break; 
            }
        }
    }

