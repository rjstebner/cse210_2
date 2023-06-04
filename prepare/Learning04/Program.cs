using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Randy", "Fractions");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Laura", "Math Stuff", "4.3", "1-12");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssingment assingment3 = new WritingAssingment("Panda", "Essay", "How to C#");
        Console.WriteLine(assingment3.GetSummary());
        Console.WriteLine(assingment3.GetWritingInformation());
    }
}