class Scripture
{
    private Reference reference;
    private List<Word> words;
    
    public Scripture(Reference _reference, string _text)
    {
        reference = _reference;
        words = new List<Word>();

        List<string> allWords = _text.Split(' ').ToList();
        foreach(string wordString in allWords)
        {
            Word newWord = new Word(wordString);
            words.Add(newWord);
        }
    } 

    public void HideRandomWords()
    {
        List<Word> visibleWords = words.Where(word => !word.GetIsHidden()).ToList();
        int wordsToHide = Math.Min(visibleWords.Count, 3);
        Random random = new Random();

        for (int i = visibleWords.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            Word temp = visibleWords[i];
            visibleWords[i] = visibleWords[j];
            visibleWords[j] = temp;
        }

        for (int i = 0; i < wordsToHide; i++)
        {
            visibleWords[i].Hide();
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = "";

        foreach (Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                scriptureText += word.GetDisplayText() + " ";
            }
            else
            {
                scriptureText += new string('_', word.GetDisplayText().Length) + " ";
            }
        }

        return $"{reference.GetDisplayText()} {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
       bool completelyHidden = true;

        foreach (Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                completelyHidden = false;

                break;
            }
        }

       return completelyHidden;
    }
}