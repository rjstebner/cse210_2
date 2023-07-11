class RogueCombat : Combat
{
    protected override void Flee(int opponentPower, string opponentName)
    {
        Console.WriteLine($"You find an opening to retreat and run away from the {opponentName} back to whence you came.");
        Console.ReadKey();
        Console.Clear();
    }

    protected override void GainCoins(int opponentValue)
    {
        Program.player.GainCoins(opponentValue * 2);
        Console.WriteLine($"You picked up {opponentValue + opponentValue} coins.");
    } 
}
