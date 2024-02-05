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
                // Welcome message
                Console.WriteLine("Welcome to Ogechi's Virtual Pet Simulator!");

                // Display pet type options
                Console.WriteLine("The below is a list of the pet types we offer here. \n 1. Cat \n 2. Dog \n 3. Rabbit \n 4. Mouse \n 5. Fish");

                Console.WriteLine("");
                Console.Write("Kindly enter your pet type now: ");
                // Read the user's input for pet type
                string petType = Console.ReadLine();

                // Check if the entered pet type is supported
                if (petType == "Cat" || petType == "Dog" || petType == "Rabbit" || petType == "Mouse" || petType == "Fish")
                {
                    Console.WriteLine("");
                    Console.Write("What is your pet's name? ");
                    // Read the user's input for pet name
                    string petName = Console.ReadLine();

                    // Create a pet object with initial values
                    Pet userPet = new Pet(petType, petName);

                    Console.WriteLine("");
                    Console.WriteLine($"Yay! Your {petType}'s name is {petName}.");

                    // Variable to control the main game loop
                    bool isRunning = true;

                    // Main game loop
                    while (isRunning)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine($"1. Feed {petName}.");
                        Console.WriteLine($"2. Play with {petName}.");
                        Console.WriteLine($"3. Let {petName} Rest");
                        Console.WriteLine($"4. Check {petName} Status");
                        Console.WriteLine($"5. Exit");

                        Console.WriteLine("");
                        Console.Write("Kindly enter your choice: ");
                        // Read the user's input for the chosen action
                        string choice = Console.ReadLine();

                        // Switch statement to handle different user choices
                        switch (choice)
                        {
                            case "1":
                                // Call the Feed method on the user's pet
                                userPet.Feed();
                                break;
                            case "2":
                                // Call the Play method on the user's pet
                                userPet.Play();
                                break;
                            case "3":
                                // Call the Rest method on the user's pet
                                userPet.Rest();
                                break;
                            case "4":
                                // Call the CheckStatus method on the user's pet
                                userPet.CheckStatus();
                                break;
                            case "5":
                                // Exit the game loop
                                Console.WriteLine("");
                                Console.WriteLine($"Thank you for visiting {petName}, see you next time. Goodbye!");
                                isRunning = false;
                                break;
                            default:
                                // Inform the user if an invalid choice is entered
                                Console.WriteLine("");
                                Console.WriteLine("Option not available, please try again.");
                                break;
                        }
                    }
                }
                else
                {
                    // Inform the user if the entered pet type is not supported
                    Console.WriteLine("We currently do not cater for this pet type, please try again.");
                }
            }

            // Class to represent a virtual pet
            class Pet
            {
                // Properties to store pet attributes
                public string TypeOfPet { get; set; }
                public string NameOfPet { get; set; }
                public int HungerLevel { get; set; }
                public int HappinessLevel { get; set; }
                public int HealthLevel { get; set; }

                // Constructor to initialize the pet with default values
                public Pet(string type, string name)
                {
                    TypeOfPet = type;
                    NameOfPet = name;
                    HungerLevel = 5;
                    HappinessLevel = 5;
                    HealthLevel = 5;
                }

                // Method to feed the pet
                public void Feed()
                {
                    // Decrease hunger and slightly increase health
                    HungerLevel = Math.Max(HungerLevel - 2, 0);
                    HealthLevel = Math.Min(HealthLevel + 1, 10);
                    Console.WriteLine("");
                    Console.WriteLine($"{NameOfPet} has been fed. Hunger decreased, health increased slightly.");
                }

                // Method to play with the pet
                public void Play()
                {
                    // Increase happiness and slightly increase hunger
                    HappinessLevel = Math.Min(HappinessLevel + 2, 10);
                    HungerLevel = Math.Min(HungerLevel + 1, 10);
                    Console.WriteLine("");
                    Console.WriteLine($"{NameOfPet} has played. Happiness increased, hunger increased slightly.");
                }

                // Method to let the pet rest
                public void Rest()
                {
                    // Improve health and decrease happiness slightly
                    HealthLevel = Math.Min(HealthLevel + 2, 10);
                    HappinessLevel = Math.Max(HappinessLevel - 1, 0);
                    Console.WriteLine("");
                    Console.WriteLine($"{NameOfPet} has rested. Health improved, happiness decreased slightly.");
                }

                // Method to check the pet's status
                public void CheckStatus()
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Status of {NameOfPet} - Hunger: {HungerLevel}, Happiness: {HappinessLevel}, Health: {HealthLevel}");

                    // Display warning messages for critical conditions
                    if (HungerLevel >= 8) Console.WriteLine($"{NameOfPet} is very hungry!");
                    if (HappinessLevel <= 2) Console.WriteLine($"{NameOfPet} is unhappy!");
                    if (HealthLevel <= 2) Console.WriteLine($"{NameOfPet} is in poor health!");
                }
            }
        }
    }