class ReceptionEvent : Event
{
    private string _rsvpEmail;

    public ReceptionEvent(string eventTitle, string rsvpEmail, DateTime eventDate, Address eventAddress)
        : base(eventTitle, "Reception", eventDate, eventAddress)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetEventDetails()
    {
        string details = base.GetEventDetails();
        details += $"RSVP Email: {_rsvpEmail}\n";
        return details;
    }
}