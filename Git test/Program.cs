using System;
using System.Collections.Generic;

namespace Git_test
{
    class Program
    {
        static void Main(string[] args)
        {
            scoreBoard gameScore = new scoreBoard();
            gameScore.redScore = 10;
            gameScore.blueScore = 0;
            gameScore.gameTimer = 43;

            Football gameBall = new Football();
            gameBall.x = 75;
            gameBall.y = 20;
            gameBall.speed = 30;
            gameBall.inGoal = false;
            
            List<Player> redTeam = new List<Player>();

            redTeam.Add(new Player());

            redTeam[0].team = "Kifen";
            redTeam[0].name = "Calle Lindstedt";
            redTeam[0].age = 17;

            List<Player> blueTeam = new List<Player>();

            blueTeam.Add(new Player());

            blueTeam[0].team = "Huddinge FC";
            blueTeam[0].name = "Ben Lomas";
            blueTeam[0].age = 12;

            System.Console.WriteLine("Lag: " + redTeam[0].team);
            System.Console.WriteLine("Namn: " + redTeam[0].name);
            System.Console.WriteLine("Ålder: " + redTeam[0].age);

            System.Console.WriteLine();
            System.Console.WriteLine("----VS----    :    Bollens Position: x:" + gameBall.x + " / y:" + gameBall.y);
            System.Console.WriteLine();

            System.Console.WriteLine("Lag: " + blueTeam[0].team);
            System.Console.WriteLine("Namn: " + blueTeam[0].name);
            System.Console.WriteLine("Ålder: " + blueTeam[0].age);

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();

            System.Console.WriteLine("Score:");
            System.Console.WriteLine("Kifen: " + gameScore.redScore);
            System.Console.WriteLine("Huddinge FC: " + gameScore.blueScore);
            System.Console.WriteLine();
            System.Console.WriteLine("Klocka (minuter): " + gameScore.gameTimer);

            Console.ReadLine();

        }

        class Football
        {
            public int x;
            public int y;
            public int speed;
            public bool inGoal;
        }

        class Player
        {
            public string team;
            public string name;
            public int age;

        }

        class scoreBoard 
        {
            public int redScore;
            public int blueScore;
            public float gameTimer;
        }

    }

}
