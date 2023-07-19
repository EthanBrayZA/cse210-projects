class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double Distance = _laps * 50.0 / 1609.34; // Convert meters to miles
        return Math.Round(Distance, 2);
    }

    public override double GetSpeed()
    {
        double Speed = GetDistance() / (GetDuration() / 60.0);
        return Math.Round(Speed, 2);
    }

    public override double GetPace()
    {
        double Pace = (GetDuration() / 60.0) / GetDistance(); 
        return Math.Round(Pace, 2);
    }
    public override string GetSummary()
    {
        string summary = base.GetSummary();
        summary = summary.Replace("Activity", "SwimmingActivity");
        summary += $", Laps: {_laps}";
        return summary;
    }
}