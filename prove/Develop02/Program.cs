using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        QuoteGenerator quoteGenerator = new QuoteGenerator();
        Journal         journal = new Journal();
        int             menuUserInput = 0;
        List<string>    menu = new List<string>
        {
            "Please select one of the following choices:",
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Daily Quote",
            "6. Quit",
            "What would you like to do? "
        };

        Console.WriteLine("Welcome to the journal program.");

        while (menuUserInput != 6)
        {
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuUserInput = int.Parse(Console.ReadLine());

            switch (menuUserInput)
            {
                case 1:
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.Date.ToString("MMM dd, yyyy");

                    Entry entry = new Entry(date, prompt, response);
                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("Name of file to Load? ");
                    string fileNameLoad = Console.ReadLine();
                    journal.LoadFromFile(fileNameLoad);
                    break;
                case 4:
                    Console.WriteLine("Name of file to save? ");
                    string fileNameSave = Console.ReadLine();
                    journal.SaveToFile(fileNameSave);

                    break;
                case 5:
                    string quote = quoteGenerator.GetRandomQuote();
                    Console.WriteLine(quote);
                    break;
            }
        }
    }
}