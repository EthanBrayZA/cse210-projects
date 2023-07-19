class Program
{
    static void Main(string[] args)
    {
        // Create running activity
        RunningActivity running = new RunningActivity(new DateTime(2023, 07, 18), 30, 3.0);

        // Create cycling activity
        CyclingActivity cycling = new CyclingActivity(new DateTime(2023, 07, 18), 30, 12.0);

        // Create swimming activity
        SwimmingActivity swimming = new SwimmingActivity(new DateTime(2023, 07, 18), 30, 40);

        // Create activity tracker and add activities
        ActivityTracker tracker = new ActivityTracker();
        tracker.AddActivity(running);
        tracker.AddActivity(cycling);
        tracker.AddActivity(swimming);

        // Display activity summaries
        List<string> summaries = tracker.GetActivitySummaries();
        foreach (string summary in summaries)
        {
            Console.WriteLine(summary);
        }
    }
}