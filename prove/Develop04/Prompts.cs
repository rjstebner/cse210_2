using System;
using System.Collections.Generic;

public class Prompt
{
    private List<string> reflectingPrompts;
    private List<string> reflectingQuestions;
    private List<string> listingPrompts;

    public Prompt()
    {
        reflectingPrompts = new List<string>()
        {
            " --- Think of a time when you stood up for someone else. ---",
            " --- Think of a time when you did something really difficult. ---",
            " --- How did I see the hand of the Lord in my life today? ---",
            " --- Think of a time when you helped someone in need. ---",
            " --- Think of a time when you did something truly selfless ---."
        };

        reflectingQuestions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        
        listingPrompts = new List<string>()
        {
            " --- Who are people that you appreciate? ---",
            " --- What are personal strengths of yours? ---",
            " --- Who are people that you have helped this week? ---",
            " --- When have you felt the Holy Ghost this month? ---",
            " --- Who are some of your personal heroes? ---"
        };
    }

    public string GetRandomReflectingPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(reflectingPrompts.Count);
        return reflectingPrompts[index];
    }

    public List<string> GetReflectingQuestions()
    {
        return new List<string>(reflectingQuestions);
    }

    public string GetRandomListingPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(listingPrompts.Count);
        return listingPrompts[index];
    }
}
