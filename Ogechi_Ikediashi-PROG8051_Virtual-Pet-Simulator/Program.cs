using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogechi_Ikediashi_PROG8051_Virtual_Pet_Simulator
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ogechi's Virtual Pet Simulator!");

            Console.WriteLine("The below is a list of the pet type care we offer here.");
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Rabbit");

            Console.Write("Kindly enter your pet type now: ");
            string petType = Console.ReadLine();

            Console.Write("What is your pet's name? ");
            string petName = Console.ReadLine();

            Pet userPet = new Pet(petType, petName);

            Console.WriteLine($"Yay! Your {petType}'s name is {petName}.");

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine($"1. Feed {petName}.");
                Console.WriteLine($"2. Play with {petName}.");
                Console.WriteLine($"3. Let {petName} Rest");
                Console.WriteLine($"4. Check {petName} Status");
                Console.WriteLine($"5. Exit");

                Console.Write("Kindly enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        userPet.Feed();
                        break;
                    case "2":
                        userPet.Play();
                        break;
                    case "3":
                        userPet.Rest();
                        break;
                    case "4":
                        userPet.CheckStatus();
                        break;
                    case "5":
                        Console.WriteLine($"Thank you for visiting {petName}, see you next time. Goodbye!");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("We currently do not carter for this pet type, please try again.");
                        break;
                }
            }
        }
    }

    class Pet
    {
        public string TypeOfPet { get; set; }
        public string NameOfPet { get; set; }
        public int HungerLevel { get; set; }
        public int HappinessLevel { get; set; }
        public int HealthLevel { get; set; }

        public Pet(string type, string name)
        {
            TypeOfPet = type;
            NameOfPet = name;
            HungerLevel = 5;
            HappinessLevel = 5;
            HealthLevel = 5;
        }

        public void Feed()
        {
            HungerLevel = Math.Max(HungerLevel - 2, 0);
            HealthLevel = Math.Min(HealthLevel + 1, 10);
            Console.WriteLine($"{NameOfPet} has been fed. Hunger decreased, health increased slightly.");
        }

        public void Play()
        {
            HappinessLevel = Math.Min(HappinessLevel + 2, 10);
            HungerLevel = Math.Min(HungerLevel + 1, 10);
            Console.WriteLine($"{NameOfPet} is playing. Happiness increased, hunger increased slightly.");
        }

        public void Rest()
        {
            HealthLevel = Math.Min(HealthLevel + 2, 10);
            HappinessLevel = Math.Max(HappinessLevel - 1, 0);
            Console.WriteLine($"{NameOfPet} is resting. Health improved, happiness decreased slightly.");
        }

        public void CheckStatus()
        {
            Console.WriteLine($"Status of {NameOfPet} - Hunger: {HungerLevel}, Happiness: {HappinessLevel}, Health: {HealthLevel}");
            if (HungerLevel >= 8) Console.WriteLine($"{NameOfPet} is very hungry!");
            if (HappinessLevel <= 2) Console.WriteLine($"{NameOfPet} is unhappy!");
            if (HealthLevel <= 2) Console.WriteLine($"{NameOfPet} is in poor health!");
        }
    }
}