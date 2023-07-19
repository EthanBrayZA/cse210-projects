class Event
{
    protected string _eventTitle;
    protected string _eventDescription;
    protected DateTime _eventDate;
    protected Address _eventAddress;

    public Event(string eventTitle, string eventDescription, DateTime eventDate, Address eventAddress)
    {
        _eventTitle = eventTitle;
        _eventDescription = eventDescription;
        _eventDate = eventDate;
        _eventAddress = eventAddress;
    }

    public virtual string GetEventDetails()
    {
        string details = "Event Details:\n";
        details += $"Title: {_eventTitle}\n";
        details += $"Description: {_eventDescription}\n";
        details += $"Date: {_eventDate}\n";
        details += $"Address: {_eventAddress.GetFullAddress()}\n";
        return details;
    }
}
