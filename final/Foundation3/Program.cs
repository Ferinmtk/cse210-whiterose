using System;

namespace EventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some addresses
            Address address1 = new Address("123 Main St", "Ruaraka", "CA", "Kenya");
            Address address2 = new Address("456 Maple Rd", "Klantown", "ON", "Kampala");
            Address address3 = new Address("789 Oak Blvd", "Thitown", "TX", "USA");

            //  events
            Event lecture = new Lecture("Tech Talk", "A talk on the latest in tech", "2024-08-01", "10:00 AM", address1, "John Doe", 100);
            Event reception = new Reception("Company Party", "Annual company gathering", "2024-08-15", "6:00 PM", address2, "rsvp@company.com");
            Event outdoorGathering = new OutdoorGathering("Summer Festival", "Outdoor summer fun", "2024-08-20", "2:00 PM", address3, "Sunny and warm");

            
            Event[] events = { lecture, reception, outdoorGathering };

            // marketing messages for each event
            foreach (Event ev in events)
            {
                Console.WriteLine("Standard Details:");
                Console.WriteLine(ev.GetStandardDetails());
                Console.WriteLine("\nFull Details:");
                Console.WriteLine(ev.GetFullDetails());
                Console.WriteLine("\nShort Description:");
                Console.WriteLine(ev.GetShortDescription());
                Console.WriteLine("\n----------------------\n");
            }
        }
    }
}
