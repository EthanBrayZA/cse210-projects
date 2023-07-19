class ActivityTracker
{
    private List<Activity> _activities;

    public ActivityTracker()
    {
        _activities = new List<Activity>();
    }

    public void AddActivity(Activity activity)
    {
        _activities.Add(activity);
    }

    public List<string> GetActivitySummaries()
    {
        List<string> summaries = new List<string>();
        foreach (Activity activity in _activities)
        {
            summaries.Add(activity.GetSummary());
        }
        return summaries;
    }
}