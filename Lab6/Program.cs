using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        //putting random outside of Main so it can generate two random numbers that won't match all the time
        public static Random rnd = new Random();

        static void Main(string[] args)
        {


            //asking user number of sides of die
            int numberOfSides1 = GetNumber("Enter number of sides: ");

            //if (!int.TryParse(Console.ReadLine() out, numberOfSides1))
                
            while (true)
            {
                //asking user if they want to continue playing
                Console.WriteLine("Roll the dice? y/n");
                string play;
                play = Console.ReadLine();

                if (play == "y")
                {
                    int dice1 = rnd.Next(1, numberOfSides1+1);
                    
                    int dice2 = rnd.Next(1, numberOfSides1+1);

                    Console.WriteLine(dice1);
                    Console.WriteLine(dice2);
                    
                }
                else
                {
                    break;
                }

               
            }

        }

        public static int GetNumber(string message)
        {
            Console.WriteLine(message);

            return int.Parse(Console.ReadLine());
            

        }
       
    }
}
