using System;
using System.Threading;

class BreathingActivity : Activity
{
    static string breathDescription = "This activity will help you relax by clearing you mind and focusing only on your breath.";
    public BreathingActivity() : base("Breathing Activity", breathDescription, 20)
    {
    }

    public void StartBreathingActivity(int duration)
    {
        int repeatCount = (int)Math.Ceiling(duration / 14.0);

        for (int repeat = 1; repeat <= repeatCount; repeat++)
        {
            Console.WriteLine("");
            Console.WriteLine($"Breathing Round {repeat}");
            Console.WriteLine("");

            for (int i = 4; i >= 0; i--)
            {
                Console.Write("\rBreathe in: {0}   ", i);
                Thread.Sleep(1000); // Pause for 1 second
            }
            Console.WriteLine("");

            for (int i = 4; i >= 0; i--)
            {
                Console.Write("\rNow hold: {0}  ", i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("");

            for (int i = 6; i >= 0; i--)
            {
                Console.Write("\rAnd breathe out: {0}  ", i);
                Thread.Sleep(1000);
            }

            Console.WriteLine();
        }

        Console.WriteLine("\rBreathing complete!");
        Console.WriteLine("Press enter to continue.");

        Console.ReadLine(); // Wait for user input before closing the console
    }
}
