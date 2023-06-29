class ScriptureMastery
{
    public string Book { get; }
    public int Chapter { get; }
    public int Verse { get; }
    public int EndVerse { get; }
    public string Text { get; }

    public ScriptureMastery(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = verse;
        Text = "";
    }

    public ScriptureMastery(string book, int chapter, int verse, int endVerse, string text)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = endVerse;
        Text = text;
    }

    public ScriptureMastery(string book, int chapter, int verse, string text)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        Text = text;
    }
}
