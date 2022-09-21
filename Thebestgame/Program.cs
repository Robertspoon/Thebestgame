using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thebestgame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brought to you by Totally Real Studios");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            

            Console.WriteLine("Super Awesome Cool Game");
            Console.WriteLine();
            Console.ReadKey(true);

            string Title;
            int Score;
            int lives;
            int Health;
            int EnemyScore;
            int BossDamage;
            float Shield;
            float PointMultiplier;
            float EnemyShieldDmg;
            float ShieldRestoration;
            float ShieldDepleation;
            float multipliedscore;
            Score = 0;
            lives = 3; 
            Health = 100;
            EnemyScore = 50;
            BossDamage = -100;
            Shield = 100.00f;
            PointMultiplier = 2.567f;
            EnemyShieldDmg = -24.5f;
            ShieldRestoration = 24.5f;
            ShieldDepleation = -100.0f;
            multipliedscore = 0.0f;
            Title = "Explorer";

            Console.WriteLine("Score: " + Score);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Shield: " + Shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine("You encounter an enemy!");
            Console.WriteLine("Enemy strikes you, deplating 24.5% of your shield!");
            Console.WriteLine();


            Shield = Shield + EnemyShieldDmg;
            Console.WriteLine("Score: " + Score);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Shield: " + Shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine("You strike the enemy, slaying them!");
            Console.WriteLine("You gained 50 points!");
            Console.WriteLine();


            Score = Score + EnemyScore;
            Console.WriteLine("Score: " + Score);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Shield: " + Shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine();
            Console.ReadKey(true);

            Shield = Shield + ShieldRestoration;
            Console.WriteLine("You picked up a shield restoration unit, restoring your shield to full!");
            Console.WriteLine("Score: " + Score);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Shield: " + Shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine("You encounter a Special Enemy!");
            Console.WriteLine("Special Enemy hits you with his hammer, completely depleating your shield!");
            Console.WriteLine();

            Shield = Shield + ShieldDepleation;
            Console.WriteLine("Score: " + Score);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Shield: " + Shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine("You strike the special enemy with a mighty blow, slaying them!");
            Console.WriteLine("Slaying the special enemy gave you a point multiplier of 2.567");
            
            

            multipliedscore = Score * PointMultiplier;
            Console.WriteLine("Score: " + multipliedscore);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Shield: " + Shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine();
            Console.ReadKey(true);


            Console.WriteLine("You found a chest!");
            Console.WriteLine("You open the chest and gain a new title!");
            Console.WriteLine();

            Console.WriteLine("Score: " + multipliedscore);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Shield: " + Shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine("You encounter Obelosh, The destroyer of towns!");
            Console.WriteLine("He strikes you with his great sword, killing you instantly");
            Console.WriteLine();

            Health = Health + BossDamage;
            Console.WriteLine("Score: " + multipliedscore);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Shield: " + Shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine("YOU DIED");


            Console.ReadKey(true);
        }
    }
}
