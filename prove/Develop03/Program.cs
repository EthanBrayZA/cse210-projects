class Program
{
    static void Main(string[] args)
    {
        string userInput = "";

        // List of scripture masteries
        List<ScriptureMastery> scriptureMasteries = new List<ScriptureMastery>()
        {
            new ScriptureMastery("Proverbs", 3, 5, 6, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths."),
            new ScriptureMastery("Matthew", 5, 14, "Ye are the light of the world. A city that is set on an hill cannot be hid."),
            new ScriptureMastery("John", 7, 17, "If any man will do his will, he shall know of the doctrine, whether it be of God, or whether I speak of myself."),
            new ScriptureMastery("2 Nephi", 2, 25, "Adam fell that men might be; and men are, that they might have joy."),
            new ScriptureMastery("Doctrine and Covenants", 88, 118, "And as all have not faith, seek ye diligently and teach one another words of wisdom; yea, seek ye out of the best books words of wisdom; seek learning, even by study and also by faith.")
        };

        Random random = new Random();

        // Randomly choose a scripture mastery from the list
        int randomIndex = random.Next(0, scriptureMasteries.Count);
        ScriptureMastery randomScriptureMastery = scriptureMasteries[randomIndex];

        Reference reference = new Reference(randomScriptureMastery.Book, randomScriptureMastery.Chapter, randomScriptureMastery.Verse, randomScriptureMastery.EndVerse, randomScriptureMastery.Text);
        Scripture scripture = new Scripture(reference, randomScriptureMastery.Text);

        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type quit to finish");
            userInput = Console.ReadLine();

            scripture.HideRandomWords();
        }
        Console.Clear();

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("");
        Console.WriteLine("Thank you for playing");
    }
}