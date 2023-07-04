using System;

class Encounters
{
    // Encounters
    public static void Intro()
    {
        Console.WriteLine("As you approach, a weathered stone archway stands before you, covered in moss and ivy.");
        Console.WriteLine("The entrance exudes a musty scent and sends a shiver down your spine. ");
        Console.WriteLine("Above, a faded warning sign depicts a skull and crossed bones and the words: Enter if you Dare");
        Console.ReadKey();
        Console.Clear();
    }
    public static void FirstEncounter()
    {
        Console.WriteLine("As you enter the dark dungeon, torchlight flickers, illuminating a chamber draped in decaying tapestries. In the center stands a rugged brigand, clutching a rusted sword with determined eyes.");
        Console.WriteLine("Scars mar his weathered face, and his stance exudes readiness. The room is filled with a tense energy as your group approaches, and the brigand locks eyes, ready to fight.");
        Console.ReadKey();
        Console.Clear();
        Combat.StartCombat(false, "Brigand", 1, 5);
    }
}