using System;

class ScriptureProvider
{
    private List<(Reference reference, string text)> _scriptures;
    private Random _random;

    public ScriptureProvider()
    {
        _scriptures = new List<(Reference reference, string text)>();
        _random = new Random();
        InitializeScriptures();
    }

    private void InitializeScriptures()
    {
        // Add your predefined scriptures here
        // Each scripture is represented as a tuple of (reference, text)
        _scriptures.Add((new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));
        _scriptures.Add((new Reference("Matthew", 5, 14), "You are the light of the world. A town built on a hill cannot be hidden."));
        _scriptures.Add((new Reference("2 Nephi", 9, 28,29), "O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish. But to be learned is good if they hearken unto the counsels of God."));
        _scriptures.Add((new Reference("D&C", 8, 2,3), "2 Yea, behold, I will tell you in your mind and in your heart, by the Holy Ghost, which shall come upon you and which shall dwell in your heart.Now, behold, this is the spirit of revelation; behold, this is the spirit by which Moses brought the children of Israel through the Red Sea on dry ground.."));
        // Add more scriptures as needed
    }

    public (Reference reference, string text) GetRandomScripture()
    {
        if (_scriptures.Count > 0)
        {
            int index = _random.Next(_scriptures.Count);
            return _scriptures[index];
        }
        else
        {
            return (null, null);
        }
    }
}
