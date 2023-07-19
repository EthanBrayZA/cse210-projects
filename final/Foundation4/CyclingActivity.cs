class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (GetDuration() / 60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60.0 / _speed;
    }
}