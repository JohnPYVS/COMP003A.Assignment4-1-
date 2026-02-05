using System.ComponentModel.Design;
using System.Xml.Serialization;

namespace COMP003A.Assignment4_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Counters and limits are stored into variables
            int stepsCompleted = 0;

            // This is the routine rules
            int maxSteps = 6;
            int restrictedStep = 3;
            int safetyLimit = 5;

            bool running = true;
            
            // This loop is to shows the menu, and keeps showing until the user exits.
            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("1. Start/Continue Routine");
                Console.WriteLine("2. View Progress");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");

                // This will assume the user types 1, 2, or 3).
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    // This section is to advance the routie one step at a time.
                    if (stepsCompleted >= maxSteps)
                    {
                        Console.WriteLine("Maximum steps reached. Cannot continue Routine");
                    }
                    else
                    {
                        int nextStep = stepsCompleted + 1;

                        // If the next step is restricted, we will skip it and move to a valid next step.
                        if (nextStep == restrictedStep)
                        {
                            Console.WriteLine("Step " + nextStep + " is restricted and was skipped");
                            // This will count forward because of the time moved past that step
                            stepsCompleted++;
                        }
                        else
                        {
                            // This is a prograss of completing exactly one step per choice
                            Console.WriteLine("Routine step " + nextStep + " completed");
                            stepsCompleted++;
                        }

                        // This will end the routine once the safety limit has been reached
                        if (stepsCompleted >= safetyLimit)
                        {
                            Console.WriteLine("Safety limit reached. Routine has been stopped");
                            // This is to return to the menu
                        }
                    }
                }
                else if (choice == 2)
                {
                    // To make it easier I put this section so the user can check the progress.
                    Console.WriteLine("Current progress: " + stepsCompleted + " steps completed.");
                    Console.WriteLine("Max steps allowed: " + maxSteps);
                    Console.WriteLine("Safety limit: " + safetyLimit);
                    Console.WriteLine("Restricted step: " + restrictedStep);
                }
                else if (choice == 3)
                {
                    // This is to end the program when the user chooses to exit.
                    running = false;
                    Console.WriteLine("Program ended.");
                }
            }
        }  
    }   
}  