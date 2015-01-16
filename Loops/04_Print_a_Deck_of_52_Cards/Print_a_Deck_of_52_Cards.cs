﻿using System;
using System.Text;
//Problem 4. Print a Deck of 52 Cards

//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

class Print_a_Deck_of_52_Cards
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        for (int card = 2; card < 15; card++)
        {
            for (int symbol = 0; symbol < 4; symbol++)
            {
                switch (card)
                {
                    case 2:
                        Console.Write("2 ");
                        break;
                    case 3:
                        Console.Write("3 ");
                        break;
                    case 4:
                        Console.Write("4 ");
                        break;
                    case 5:
                        Console.Write("5 ");
                        break;
                    case 6:
                        Console.Write("6 ");
                        break;
                    case 7:
                        Console.Write("7 ");
                        break;
                    case 8:
                        Console.Write("8 ");
                        break;
                    case 9:
                        Console.Write("9 ");
                        break;
                    case 10:
                        Console.Write("10");
                        break;
                    case 11:
                        Console.Write("J ");
                        break;
                    case 12:
                        Console.Write("Q ");
                        break;
                    case 13:
                        Console.Write("K ");
                        break;
                    case 14:
                        Console.Write("A ");
                        break;
                    default:
                        break;
                }
                if (symbol == 0)
                {
                    Console.Write('\u2663'+" ");
                }
                if (symbol == 1)
                {
                    Console.Write('\u2666' + " ");
                }
                if (symbol == 2)
                {
                    Console.Write('\u2665' + " ");
                }
                if (symbol == 3)
                {
                    Console.WriteLine('\u2660' + " ");
                }
            }
        }
    }
}
