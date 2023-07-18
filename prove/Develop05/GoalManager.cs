public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool exitProgram = false;

        while (!exitProgram)
        {
            Console.WriteLine("----- ETERNAL QUEST -----");
            Console.WriteLine("1. Display Points");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Create Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.WriteLine("--------------------------");
            Console.Write("Enter your choice: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    CreateGoal();
                    break;
                case "4":
                    RecordEvent();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    exitProgram = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine("----- Your Points -----");
        Console.WriteLine($"Score: {_score}");
        Console.WriteLine("-----------------------");
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("----- Goals -----");
        foreach (Goal goal in _goals)
        {
            string completionStatus = goal.IsComplete() ? "[X]" : "[ ]";
            string details = goal.GetDetailsString();
            Console.WriteLine($"{completionStatus} {details}");
        }
        Console.WriteLine("------------------");
    }

    public void CreateGoal()
    {
        Console.WriteLine("----- Create Goal -----");
        Console.Write("Enter goal type (1. Simple, 2. Eternal, 3. Checklist): ");
        string input = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (input)
        {
            case "1":
                Goal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
                Console.WriteLine("Simple goal created.");
                break;
            case "2":
                Goal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
                Console.WriteLine("Eternal goal created.");
                break;
            case "3":
                Console.Write("Enter goal target: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter goal bonus: ");
                int bonus = int.Parse(Console.ReadLine());

                Goal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(checklistGoal);
                Console.WriteLine("Checklist goal created.");
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("----- Record Event -----");
        Console.WriteLine("Select a goal to record an event:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.Write("Enter the goal number: ");
        int goalNumber = int.Parse(Console.ReadLine());

        if (goalNumber >= 1 && goalNumber <= _goals.Count)
        {
            Goal selectedGoal = _goals[goalNumber - 1];
            selectedGoal.RecordEvent();
            _score += selectedGoal.Points;
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        int i = 0;

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            if (i == 0)
            {
                _score = int.Parse(parts[0]);
                i++;
                continue;
            }

            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal myGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                myGoal.RecordEvent();
                _goals.Add(myGoal);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal myGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(myGoal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal myGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));
                myGoal.SetAmountCompleted(int.Parse(parts[4]));
                _goals.Add(myGoal);
            }
        }

        Console.WriteLine("File Loaded");
    }
}