using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommandoFactory new1 = new CommandoFactory();
            new1.AddCommando("Commando", "omer", "bazelet");
            
            new1.AddCommando("SeaCommando", "avi", "geffen");
            
            new1.AddCommando("AirCommando", "itai", "orev");


            foreach (Commando soldier in new1.allCommando)
            {
                soldier.Attack();
                soldier.SayName("COLONEL");
            }
            //EnemyFactory new1 = new EnemyFactory();
            //new1.AddEnemy("ahmed");
            //new1.AddEnemy("ali");
            //foreach (Enemy enemy in new1.allEnemys)
            //{
            //    Console.WriteLine(enemy._isAlive);
            //}


        }
    }
}
