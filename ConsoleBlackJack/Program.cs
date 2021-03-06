﻿using System;
using System.Collections.Generic;

namespace ConsoleBlackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n =-=-=-=-=-=-=-=-=-=- \n Welcome to Console Blackjack! Press Enter for start first player's turn. \n =-=-=-=-=-=-=-=-=-=-");
            List<string> Card_names = new List<string>() { "Diamonds Jack", "Clubs Jack", "Hearts Jack", "Spades Jack", "Diamonds Dame", "Clubs Dame", "Hearts Dame", "Spades Dame", "Diamonds King", "Clubs King", "Hearts King", "Spades King", "Diamonds Six", "Clubs Six", "Hearts Six", "Spades Six", "Diamonds Seven", "Clubs Seven", "Hearts Seven", "Spades Seven", "Diamonds Eight", "Clubs Eight", "Hearts Eight", "Spades Eight", "Diamonds Nine", "Clubs Nine", "Hearts Nine", "Spades Nine", "Diamonds Ten", "Clubs Ten", "Hearts Ten", "Spades Ten", "Diamonds Ace", "Clubs Ace", "Hearts Ace", "Spades Ace" };
            Dictionary<string, byte> Cards = new Dictionary<string, byte>()
            {
                {"Diamonds Jack", 2 },
                {"Clubs Jack", 2 },
                {"Hearts Jack", 2 },
                {"Spades Jack", 2 },

                {"Diamonds Dame", 3 },
                {"Clubs Dame", 3 },
                {"Hearts Dame", 3 },
                {"Spades Dame", 3 },

                {"Diamonds King", 4 },
                {"Clubs King", 4 },
                {"Hearts King", 4 },
                {"Spades King", 4 },

                {"Diamonds Six", 6 },
                {"Clubs Six", 6 },
                {"Hearts Six", 6 },
                {"Spades Six", 6 },

                {"Diamonds Seven", 7 },
                {"Clubs Seven", 7 },
                {"Hearts Seven", 7 },
                {"Spades Seven", 7 },

                {"Diamonds Eight", 8 },
                {"Clubs Eight", 8 },
                {"Hearts Eight", 8 },
                {"Spades Eight", 8 },

                {"Diamonds Nine", 9 },
                {"Clubs Nine", 9 },
                {"Hearts Nine", 9 },
                {"Spades Nine", 9 },

                {"Diamonds Ten", 10 },
                {"Clubs Ten", 10 },
                {"Hearts Ten", 10 },
                {"Spades Ten", 10 },

                {"Diamonds Ace", 11 },
                {"Clubs Ace", 11 },
                {"Hearts Ace", 11 },
                {"Spades Ace", 11 },
            };
            Console.ReadLine();
            byte max_index = 35;
            byte raz = 3;
            byte EXIT = 0;
            byte sum1 = 0;
            Random num = new Random();
            for (byte i = 1; i < 3; i++)
            {
                int Card1 = num.Next(0, max_index);
                string Name = Card_names[Card1];
                if (Cards.ContainsKey(Name))
                {
                    sum1 += Cards[Name];
                    Console.WriteLine($" Card Value - {Name}");
                    Card_names.RemoveAt(Card1);
                    max_index -= 1;
                }
            }
            while (EXIT != 1)
            {
                Console.WriteLine(" \n =-=-=-=-=-=-=-=-=-=- \n Press F for cards, else press Enter. \n =-=-=-=-=-=-=-=-=-=-");
                string S = Console.ReadLine();
                if (S == "F")
                {
                    int Card1 = num.Next(0, max_index);
                    string Name = Card_names[Card1];
                    if (Cards.ContainsKey(Name))
                    {
                        sum1 += Cards[Name];
                        Console.WriteLine($" Card Value - {Name}");
                        Card_names.RemoveAt(Card1);
                        max_index -= 1;
                    }
                }
                else
                {
                    EXIT = 1;
                }
            }
            byte sum2 = 0;
            for (byte i = 1; i < raz; i++)
            {
                int Card1 = num.Next(0, max_index);
                string Name = Card_names[Card1];
                if (Cards.ContainsKey(Name))
                {
                    sum2 += Cards[Name];
                    Card_names.RemoveAt(Card1);
                    max_index -= 1;
                }
            }
            string Winner = (sum1 > sum2 && sum1 <= 21) ? $"The banker have {sum2} and it means you won!" : $"The banker have {sum2} and it means you lose!";
            Console.WriteLine($"{Winner} Press Enter for finish program.");
            Console.ReadLine();
        }
    }
}
