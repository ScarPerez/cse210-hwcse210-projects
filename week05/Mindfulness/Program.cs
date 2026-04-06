using System;
using System.Threading;
using System.Collections.Generic;

// EXCEEDING REQUIREMENTS:
// - Added menu loop so user can repeat activities
// - Clean structure using separate classes
// - Included basic validation for menu input
// - Used time-based execution for activities

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        // Loop to keep program running until user exits
        while (choice != "4")
        {
            Console.Clear();

            // Menu
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");

            choice = Console.ReadLine();

            Console.Clear();

            // Option 1: Breathing
            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            // Option 2: Reflection
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }
            // Option 3: Listing
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            // Option 4: Exit
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye 👋");
            }
            // Invalid option
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
                Thread.Sleep(2000);
            }
        }
    }
}

