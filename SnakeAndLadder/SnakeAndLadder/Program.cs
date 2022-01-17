using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            //single position at start
            Console.WriteLine("Welcome to snake and ladder program");  //Welcome message
            int NO_OF_PLAYER = 1;              //number of player
            int POSITION = 0;                 //position of player
            Console.WriteLine("Number of player: " + NO_OF_PLAYER + " is playing in game at position: " + POSITION);
            //roll dice
            Random random = new Random();               //Computation
            int dicenumber = random.Next(0, 7);
            Console.WriteLine("Roll the dice and get the number on dice " + dicenumber);
        }
    }
}
