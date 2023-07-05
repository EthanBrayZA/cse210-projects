public class ReflectingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random random = new Random();

    public ReflectingActivity()
    {
        this.SetActivityName("Reflecting Activity");
        this.SetDescription("This activity will help you reflect on times in your life when " +
            "you have shown strength and resilience. This will help you recognize the power you " +
            "have and how you can use it in other aspects of your life.");
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Write("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();
        int interval = GetDuration();
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine();
            DisplayQuestions();
            ShowSpinner(interval);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int randomPrompt = random.Next(0, prompts.Count);
        return prompts[randomPrompt];
    }

    public string GetRandomQuestion()
    {
        int randomQuestion = random.Next(0, questions.Count);
        return questions[randomQuestion];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"---{GetRandomPrompt()}---");
    }

    public void DisplayQuestions()
    {
        Console.WriteLine($"> {GetRandomQuestion()} ");
    }
    
}