using System.Diagnostics;
public class ListeningActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListeningActivity()
    {
        this.SetActivityName("Listing Activity");
        this.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        int interval = this.GetDuration() / 2;

        Console.WriteLine();
        Console.WriteLine("Think of as many things as you can in response to the following prompt:");
        Console.WriteLine();

        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"---{prompt}---");
        Console.WriteLine();

        Console.WriteLine("Start listing:");

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        int itemCount = 0;

        while (stopwatch.ElapsedMilliseconds / 1000 < this.GetDuration())
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            Console.WriteLine();

            if (!string.IsNullOrWhiteSpace(item))
            {
                itemCount++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {itemCount} items.");
        DisplayEndingMessage();
        ShowSpinner(interval);
    }
}