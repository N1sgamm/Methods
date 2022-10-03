using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static int score; //declaration
        static int health;

        static void Main(string[] args)
        {
            //start screen
            Console.WriteLine("Methods");
            Console.WriteLine();
            Console.WriteLine("Press any button to continue");
            Console.ReadKey(true);
            Console.Clear();

            //initialization
            score = 0;
            int enemyPoints;
            enemyPoints = 100;
            int levelBeatPoints;
            levelBeatPoints = 10000;
            int combo;
            combo = 0;
            float pointMultiplier;
            pointMultiplier = 0;
            health = 100;

            //simulated gameplay
            ShowHUD();
            AddScore(enemyPoints);
            Console.WriteLine();
            Console.WriteLine("Press any key to fight monsters");
            Console.ReadKey(true);

            Console.Clear();
            Console.WriteLine("You killed a monster");
            ShowHUD();
            AddScore(levelBeatPoints);

            Console.ReadKey(true);
        }
        static void AddScore(int points)
        {
            Console.WriteLine(points + "+");
            score = score + points;

        }
        static void ShowHUD()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("----------------");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("----------------");
            Console.WriteLine();
        }
    }
}