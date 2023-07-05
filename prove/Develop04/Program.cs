class Program
{
    static void Main(string[] args)
    {
        int userMenuInput = 0;

        List<string> menu = new List<string>
        {
            "Menu Options:",
            " 1. Start breathing activity",
            " 2. Start reflecting activity",
            " 3. Start listening activity",
            " 4. Quit"
        };

        Dictionary<string, int> activityLog = new Dictionary<string, int>
        {
            { "Breathing Activity", 0 },
            { "Reflecting Activity", 0 },
            { "Listening Activity", 0 }
        };

        while (userMenuInput != 4)
        {
            Console.Clear();
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("Select a choice from the menu: ");
            userMenuInput = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (userMenuInput)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    activityLog["Breathing Activity"] += 1;
                    break;
                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    activityLog["Reflecting Activity"] += 1;
                    break;
                case 3:
                    ListeningActivity listeningActivity = new ListeningActivity();
                    listeningActivity.Run();
                    activityLog["Listening Activity"] += 1;
                    break;
            }
        }

        Console.WriteLine("Activity Log:");
        foreach (KeyValuePair<string, int> entry in activityLog)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} times");
        }
    }
}