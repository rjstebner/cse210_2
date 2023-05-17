using System;

class Fraction
{
    private int _top;
    private int _bot;

    public Fraction()
    {
        _top = 1;
        _bot = 1;
    }
    public Fraction(int number)
    {
        _top = number;
        _bot = 1;
    }

    public Fraction(int top, int bot)
    {
        _top = top;
        _bot = bot;
    }

    public string GetFraction()
    {
        string text = $"{_top}/{_bot}";
        return text;
    }

    public double GetDecimal()
    {
        return (double)_top /  (double)_bot;
    }
}