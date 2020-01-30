using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAcademy
{
    class Program
    {
        
        static void Main(string[] args)
        {
             

            Console.WriteLine("Welcome to the game");
            Console.WriteLine("Please choose a fighter!");

            Console.WriteLine("1. Fighter \n 2. Druid \n 3. Monk");

            Dictionary<string, Superhero> actions = new Dictionary<string, Superhero>();

            actions["1"] = Fighter fighter = new Fighter();
        }
    }
}
