abstract class Activity
{
    private DateTime _date;
    private int _duration;

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public DateTime Date => _date;

    protected int GetDuration()
    {
        return _duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string summary = $"{_date:dd MMM yyyy} {_GetType()} ({_duration} min) - ";
        summary += $"Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
        return summary;
    }

    private string _GetType()
    {
        return GetType().Name;
    }
}