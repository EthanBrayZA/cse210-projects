class Reference
{
    private string book;
    private int chapter;
    private int verse;
    private int endVerse;
    private string text;

    public Reference(string _book, int _chapter, int _verse)
    {
        book = _book;
        chapter = _chapter;
        verse = _verse;
        endVerse = 0;
        text = "";
    }

    public Reference(string _book, int _chapter, int _verseStart, int _verseEnd, string _text)
    {
        book = _book;
        chapter = _chapter;
        verse = _verseStart;
        endVerse = _verseEnd;
        text = _text;
    }

    public string GetDisplayText()
    {
        string referenceDisplay = "";

        if (endVerse != 0)
        {
            referenceDisplay = $"{book} {chapter}:{verse}-{endVerse}";
        }
        else
        {
            referenceDisplay = $"{book} {chapter}:{verse}";
        }

        return referenceDisplay;
    }
}