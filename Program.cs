using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBOTcsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            
            RunningRobot fernando = new RunningRobot("Fernando", "Running", 50, 100);
            FlyingRobot julio = new FlyingRobot("Julio", "Flying", 75, 50);
            SwimmingRobot Manuel = new SwimmingRobot("Manuel", "Swimming", 50, 50);

            Console.WriteLine("Welcome to the robot factory. What type of robot would you like to have today?");
            Console.WriteLine("We offer three different types of robots. We offer a Swimming, Flying, and Running Robot");
            Console.WriteLine("Please choose the type of robot you would like to begin your adventure today with");
            Console.WriteLine("You can choose from a 'Swimming' robot, a 'Flying' robot, or a 'Running' robot.");
            answer = Console.ReadLine();

                if (answer == "Swimming")
            {
                Console.WriteLine("You have chosen the swimming robot. you are taken to our robot swimming facility to use the robot and test that shit out");
                Console.WriteLine("You have entered the swimming facitlity and you take the robot and put that shit in the water.");
                Console.WriteLine("Your dog has died and you have left the faciclity cryn===ig");

            }
               if (answer == "Flying")
            {
                Console.WriteLine("your are dead goodbye");
                Console.WriteLine("Just kidding, you have choose the fkying robot, you are taken to our companies ariel facility to use the flying robot.");
                Console.WriteLine("Walk would you like to do with the robot. You can 'A', fly the robot around, 'B' ride the robot around like a flying pony and hope you don't fall off.");
                Console.WriteLine("you can 'C' attack another rbot with the fling prowess and see who wins and in a battle to the death");
                Console.WriteLine();

            }
               if (answer == "Running")
            {

            }



























































               
        }
    }
}