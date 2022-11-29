// See https://aka.ms/new-console-template for more information
using System;

namespace tictacahmad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME THE TİC TAC TOE !");
            string n1 = "1";
            string n2 = "2";
            string n3 = "3";
            string n4 = "4";
            string n5 = "5";
            string n6 = "6";
            string n7 = "7";
            string n8 = "8";
            string n9 = "9";

            string player = "X";
            string number;
            int numberout;


            int stepnumber = 0;

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($" {n1} | {n2} | {n3}");
                Console.WriteLine("___|___|___");
                Console.WriteLine($" {n4} | {n5} | {n6}");
                Console.WriteLine("___|___|___");
                Console.WriteLine($" {n7} | {n8} | {n9}");



                if (i % 2 == 1) player = "X";
                else player = "O";

                while (stepnumber < 9)
                {
                    Console.Write($"{player}'s move > ");
                    number = Console.ReadLine();
                    if (!int.TryParse(number, out numberout)) continue;

                    if (numberout == 1)
                    {
                        if (n1 != "1")
                        {
                            Console.WriteLine("Illegal move try again");
                            continue;
                        }
                        n1 = player;
                    }

                    else if (numberout == 2)
                    {
                        if (n2 != "2")
                        {
                            Console.WriteLine("Illegal move try again");
                            continue;
                        }
                        n2 = player;
                    }

                    else if (numberout == 3)
                    {
                        if (n3 != "3")
                        {
                            Console.WriteLine("Illegal move try again");
                            continue;
                        }
                        n3 = player;
                    }

                    else if (numberout == 4)
                    {
                        if (n4 != "4")
                        {
                            Console.WriteLine("Illegal move try again");
                            continue;
                        }
                        n4 = player;
                    }

                    else if (numberout == 5)
                    {
                        if (n5 != "5")
                        {
                            Console.WriteLine("Illegal move try again");
                            continue;
                        }
                        n5 = player;
                    }

                    else if (numberout == 6)
                    {
                        if (n6 != "6")
                        {
                            Console.WriteLine("Illegal move try again");
                            continue;
                        }
                        n6 = player;
                    }

                    else if (numberout == 7)
                    {
                        if (n7 != "7")
                        {
                            Console.WriteLine("Illegal move try again");
                            continue;
                        }
                        n7 = player;
                    }

                    else if (numberout == 8)
                    {
                        if (n8 != "8")
                        {
                            Console.WriteLine("Illegal move try again");
                            continue;
                        }
                        n8 = player;
                    }

                    else if (numberout == 9)
                    {
                        if (n9 != "9")
                        {
                            Console.WriteLine("Illegal move try again");
                            continue;
                        }
                        n9 = player;
                    }


                    else
                    {
                        Console.WriteLine("Illegal move try again");
                        continue;
                    }

                    numberout++;
                    break;
                }


            }
            Console.WriteLine("draw!");
        }
    }
}
