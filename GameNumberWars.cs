using System;
using System.Collections.Generic;
using System.Text;

namespace GameNumberWars
{
    class GameNumberWars
    {
        static void Main(string[] args)
        {
            string firstPlayerName = Console.ReadLine();
            string secondPlayerName = Console.ReadLine();

            string command = Console.ReadLine();

            int firstPlayerPoints = 0;
            int secondPlayerPoints = 0;

            while (true)
            {
                if (command == "End of game")
                {
                    Console.WriteLine($"{firstPlayerName} has {firstPlayerPoints} points");
                    Console.WriteLine($"{secondPlayerName} has {secondPlayerPoints} points");
                    break;
                }

                int firstPlayerCard = int.Parse(command);
                int secondPlayerCard = int.Parse(Console.ReadLine());

                if (firstPlayerCard > secondPlayerCard)
                {
                    firstPlayerPoints = firstPlayerPoints + (firstPlayerCard - secondPlayerCard);
                }
                else if (secondPlayerCard > firstPlayerCard)
                {
                    secondPlayerPoints = secondPlayerPoints + (secondPlayerCard - firstPlayerCard);
                }
                else
                {
                    while (firstPlayerCard == secondPlayerCard)
                    {
                        int firstPlayerWarCard = int.Parse(Console.ReadLine());
                        int secondPlayerWarCard = int.Parse(Console.ReadLine());

                        if (firstPlayerWarCard > secondPlayerWarCard)
                        {
                            Console.WriteLine("Number wars!");
                            Console.WriteLine($"{firstPlayerName} is winner with {firstPlayerPoints} points");
                        }
                        else if (secondPlayerWarCard > firstPlayerWarCard)
                        {
                            Console.WriteLine("Number wars!");
                            Console.WriteLine($"{secondPlayerName} is winner with {secondPlayerPoints} points");
                        }
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
