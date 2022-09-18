using System;
using System.Collections.Generic;

namespace LessonsSimpleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var gamesInfo = GetGamesInfo(); //метод возвращает список объектов класса GamesInfo

            for (int i = 0; i < gamesInfo.Count; i++)
            {
                Console.WriteLine($"{gamesInfo[i].TypeOfGame}:");
                for (int j = 0; j < gamesInfo.Games.Count; j++)
                {
                    Console.WriteLine($"{gamesInfo[i].Name[j].Name}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        new GameInfo()
        {
            TypeOfGame = GameType.Shooter;
        }
        
    }         
}    