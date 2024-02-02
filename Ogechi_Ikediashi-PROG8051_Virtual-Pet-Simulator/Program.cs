using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogechi_Ikediashi_PROG8051_Virtual_Pet_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Committing my first code to Git

            //Selecting Users Pet
            //Welcoming the user and providing options of Pet to user
            Console.WriteLine("Hello dear, Welcome to Pet Store!");
            Console.WriteLine("Please enter a number to choose a type of pet.");
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Rabbit");
            Console.WriteLine("4. Mouse");
            Console.WriteLine("5. Fish");

            //Declaring a variable to accept user input, coverting the inputted string to integer type and accepting User Input
            int PetType = Convert.ToInt32(Console.ReadLine());
            if (PetType > 0 || PetType < 6)
            {
                if (PetType == 1)
                {
                    Console.WriteLine("You've chosen a Cat!");
                }
                else if (PetType == 2)
                {
                    Console.WriteLine("You've chosen a Dog!");
                }
                else if (PetType == 3)
                {
                    Console.WriteLine("You've chosen a Rabbit!");
                }
                else if (PetType == 4)
                {
                    Console.WriteLine("You've chosen a Mouse!");
                }
                else if (PetType == 5)
                {
                    Console.WriteLine("You've chosen a Fish!");
                }
                else {
                    Console.WriteLine("Oops! You have entered a wrong number or your pet type is not covered at this time");
                        }
            }
        }
    }
}
