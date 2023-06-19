class QuoteGenerator
{
    List<string> quotes;

    public QuoteGenerator ()
    {
        quotes = new List<string>
        {
            "It is often the small steps, not the giant leaps, that bring about the most lasting change.",
            "Education is the most powerful weapon which you can use to change the world.",
            "There is always light. If only we're brave enough to see it. If only we're brave enough to be it.",
            "If you want to lift yourself up, lift up someone else.",
            "I have learned not to allow rejection to move me."
        };
    }

    public string GetRandomQuote()
    {
        string randomQuote = "";
        int randomIndex = new Random().Next(quotes.Count);

        randomQuote = quotes[randomIndex];

        return randomQuote;
    }
}