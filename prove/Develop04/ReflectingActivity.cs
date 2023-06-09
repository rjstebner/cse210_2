using System;
using System.Threading;

class ReflectingActivity : Activity
{
    static string reflectingDescription = "This activity will help you reflect on times in your life to empower and guide you.";

    public ReflectingActivity() : base("Reflecting Activity", reflectingDescription, 20)
    {
    }

    public void StartReflectingActivity(int duration)
    {
        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        Prompt prompt = new Prompt();
        string randomPrompt = prompt.GetRandomReflectingPrompt();
        Console.WriteLine("");
        Console.WriteLine(randomPrompt);
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("For the next few moments, you will receive a series of questions. Ponder on each question and how they relate to your experience.");
        Console.WriteLine("Press 'Enter' to start");
        Console.ReadLine();
        Console.Clear();
        ContinuingReflectingActivity(duration);
    }
// the method was getting rather confuesing for me to work with so I split it be for the complicated part
public void ContinuingReflectingActivity(int duration)
{
    Animation animation = new Animation();
    Prompt prompt = new Prompt();
    Random rand = new Random();

    // Create a copy of the reflecting questions list
    List<string> reflectingQuestionsCopy = prompt.GetReflectingQuestions();

    // Shuffle the reflecting questions
    int n = reflectingQuestionsCopy.Count;
    while (n > 1)
    {
        n--;
        int k = rand.Next(n + 1);
        string value = reflectingQuestionsCopy[k];
        reflectingQuestionsCopy[k] = reflectingQuestionsCopy[n];
        reflectingQuestionsCopy[n] = value;
    }

    // Calculate the rounded duration to the nearest multiple of 10
    int roundedDuration = (int)Math.Round((double)duration / 10) * 10;
    int minimumDuration = 5; // Minimum duration in seconds

    // Display the shuffled reflecting questions until the minimum duration is reached
    DateTime startTime = DateTime.Now;
    TimeSpan elapsed;
    int index = 0;
    while (true)
    {
        // Check if the elapsed time exceeds the minimum duration
        elapsed = DateTime.Now - startTime;
        if (elapsed.TotalSeconds >= minimumDuration)
            break;

        // Display the current question
        string question = reflectingQuestionsCopy[index];
        Console.WriteLine(question);
        animation.ShowSpinner();
        animation.ShowSpinner();
        Console.Write("\b \b");

        // Move to the next question
        index++;
        if (index >= reflectingQuestionsCopy.Count)
            index = 0;
    }

    // Continue displaying questions until the rounded duration is reached
    while (true)
    {
        // Check if the elapsed time exceeds the rounded duration
        elapsed = DateTime.Now - startTime;
        if (elapsed.TotalSeconds >= roundedDuration)
            break;

        // Display the current question
        string question = reflectingQuestionsCopy[index];
        Console.WriteLine(question);
        animation.ShowSpinner();
        animation.ShowSpinner();
        Console.Write("\b \b");

        // Move to the next question
        index++;
        if (index >= reflectingQuestionsCopy.Count)
            index = 0;
    }

    // Display "Well done" and wait for user input
    Console.WriteLine($"You have completed {duration} seconds of The Reflecting Activity!");
    Console.WriteLine("Press Enter to continue.");
    Console.ReadLine();
}




}
