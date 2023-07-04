using System;

class Combat
{
    
    public static void StartCombat(bool random, string name, int power, int health)
    
    {
        Random rand = new Random();
        string opponentName = "";
        int opponentPower = 0;
        int opponentHealth = 0;

        if (random == true)
        {
            // Generate random opponent
        }
        else
        {
            opponentName = name;
            opponentPower = power;
            opponentHealth = health;
        }

        while (opponentHealth > 0 )
        {
            if (Program.player.Health == 0)
                {
                    Console.WriteLine("You Died");
                    Console.WriteLine("The Game is now over");

                    Environment.Exit(0);
                }
            Console.WriteLine($"{Program.player.Name}\t\t\t\t\t|  {opponentName}");
            Console.WriteLine($"Health: {Program.player.Health}| Potions: {Program.player.Potions}\t\t\t|  Health: {opponentHealth} ");
            Console.WriteLine($"Power: {Program.player.Power}| Armour: {Program.player.Armour}");
            Console.WriteLine();
            Console.WriteLine("==============================");
            Console.WriteLine("| (A)ttack | (F)lee | (H)eal |");
            Console.WriteLine("==============================");
            Console.WriteLine();


            





    

            string choice = Console.ReadLine();

            if (choice.ToLower() == "a" || choice.ToLower() == "attack")
            {
                int damage = Math.Max(opponentPower - Program.player.Armour, 0);
                int attack = Program.player.Power;
                opponentHealth -= attack;
                Console.WriteLine($"You strike out and attack dealing {attack} damage to the {opponentName}.");
                Program.player.TakeDamage(damage);
                Console.WriteLine($"The {opponentName} retaliats dealing {damage} damage to you.");
                Console.ReadKey();
                Console.Clear();
            }
            else if (choice.ToLower() == "f" || choice.ToLower() == "flee")
            {
                if (rand.Next(0, 2) == 0)
                {
                    int damage = Math.Max(opponentPower - Program.player.Armour, 0);
                    Program.player.TakeDamage(damage);
                    Console.WriteLine($"You turn to flee, leaving your self open the {opponentName} siezes the oppertunity and lashes out at you");
                    Console.WriteLine($"You take {damage} as you flee back to saftey");
                    Console.ReadKey();
                    Console.Clear();

                }
                else
                {
                    Console.WriteLine($"You find an opening to retread and run away from the {opponentName} back to from whence you came");
                    Console.ReadKey();
                    Console.Clear();

                    break;
                }
            }
            else if (choice.ToLower() == "h" || choice.ToLower() == "heal")
            {
                if (Program.player.Potions == 0)
                {
                    Console.WriteLine($"You have no potions!");
                    int damage = Math.Max(opponentPower - Program.player.Armour, 0);
                    Program.player.TakeDamage(damage);
                    Console.WriteLine($" As you fiddle around in your bag {opponentName} strikes at you dealing {damage}");
                    Console.ReadKey();
                    Console.Clear();

                }
                else
                {
                    Program.player.UsePotion(Program.player.PotionValue);
                    Console.ReadKey();
                    Console.Clear();

                }
            }
        }
    }
}
