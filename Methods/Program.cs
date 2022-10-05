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
        static int monsters;

        static void Main(string[] args)
        {
            //start screen
            Console.WriteLine("Methods");
            Console.WriteLine();
            Console.WriteLine("Press any button to continue");
            Console.ReadKey(true);
            Console.Clear();

            //declaration
            int enemyPoints;
            int levelBeatPoints;
            int combo;
            float pointMultiplier;

            //initialization
            score = 0;
            health = 100;
            enemyPoints = 100;
            levelBeatPoints = 10000;
            combo = 0;
            pointMultiplier = 0;
            monsters = 3;

            //simulated gameplay
            ShowHUD();
            Console.WriteLine();
            Console.WriteLine("Press any key to fight monsters");

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("You killed a monster");
            AddScore(enemyPoints);
            TakeDamage(monsters*10);
            KillMonster();
            ShowHUD();

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("You killed a monster");
            AddScore(enemyPoints);
            TakeDamage(monsters*10);
            KillMonster();
            ShowHUD();

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("You killed a monster");
            AddScore(enemyPoints);
            TakeDamage(monsters*10);
            KillMonster();
            ShowHUD();

            Console.ReadKey(true);
            Console.Clear();

            TakeDamage(monsters*10);
            KillMonster();
            Console.WriteLine("You killed all of the monsters");
            AddScore(levelBeatPoints);
            ShowHUD();

            Console.ReadKey(true);
        }
        static void ShowHUD()
        {
            Console.WriteLine();
            Console.WriteLine("----------------");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("----------------");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("----------------");
            Console.WriteLine("Score Multiplier: " + combo);
            Console.WriteLine("----------------");
            Console.WriteLine("Monsters Remaining: " + monsters);
            Console.WriteLine("----------------");
            Console.WriteLine();
        }
        static void TakeDamage(int damage)
        {
            health = health - damage;
        }
        static void AddScore(int points)
        {
            Console.WriteLine("You gained " + points + " points");
            score = score + points;
        }
        static void KillMonster()
        {
            monsters = monsters - 1;
        }
    }
}