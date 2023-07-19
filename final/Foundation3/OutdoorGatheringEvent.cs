class OutdoorGatheringEvent : Event
{
    private string _weatherForecast;

    public OutdoorGatheringEvent(string eventTitle, string eventDescription, DateTime eventDate, Address eventAddress, string weatherForecast)
        : base(eventTitle, eventDescription, eventDate, eventAddress)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetEventDetails()
    {
        string details = base.GetEventDetails();
        details += $"Weather Forecast: {_weatherForecast}\n";
        return details;
    }
}
