using System;

public class ScriptureShelf
{
    private List<Scripture> _scriptures;

    public ScriptureShelf()
    {
        _scriptures = new List<Scripture>();
    }

    public void AddScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }

    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
        {
            Console.WriteLine("There are no Scriptures");
        }

        Random random = new Random();
        return _scriptures[random.Next(_scriptures.Count)];
    }
}