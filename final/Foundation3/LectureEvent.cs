class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string eventTitle, string speaker, DateTime eventDate, Address eventAddress, int capacity)
        : base(eventTitle, "Lecture", eventDate, eventAddress)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetEventDetails()
    {
        string details = base.GetEventDetails();
        details += $"Speaker: {_speaker}\n";
        details += $"Capacity: {_capacity}\n";
        return details;
    }
}