class Program
{
    static void Main(string[] args)
    {
        // Create lecture event
        LectureEvent lecture = new LectureEvent("Introduction to AI", "John Smith", new DateTime(2023, 7, 20, 9, 0, 0), new Address("123 Main St", "Cityville", "CA", "USA"), 100);

        // Create reception event
        ReceptionEvent reception = new ReceptionEvent("Networking Reception", "Email RSVP: info@example.com", new DateTime(2023, 7, 21, 18, 0, 0), new Address("456 Elm St", "Townsville", "NY", "USA"));

        // Create outdoor gathering event
        OutdoorGatheringEvent gathering = new OutdoorGatheringEvent("Summer BBQ", "Bring your own food and drinks!", new DateTime(2023, 7, 22, 15, 0, 0), new Address("789 Oak St", "Villageville", "TX", "USA"), "Sunny");

        // Display event details
        Console.WriteLine("---------------------");
        Console.WriteLine(lecture.GetEventDetails());
        Console.WriteLine("---------------------");
        Console.WriteLine();
        Console.WriteLine("---------------------");
        Console.WriteLine(reception.GetEventDetails());
        Console.WriteLine("---------------------");
        Console.WriteLine();
        Console.WriteLine("---------------------");
        Console.WriteLine(gathering.GetEventDetails());
        Console.WriteLine("---------------------");
    }
}