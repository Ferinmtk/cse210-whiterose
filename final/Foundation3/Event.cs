namespace EventPlanning
{
    public abstract class Event
    {
        private string title;
        private string description;
        private string date;
        private string time;
        private Address address;

        public Event(string title, string description, string date, string time, Address address)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            this.time = time;
            this.address = address;
        }

        public string GetStandardDetails()
        {
            return $"Title: {title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address.GetFullAddress()}";
        }

        public abstract string GetFullDetails();

        public string GetShortDescription()
        {
            return $"Type: {GetType().Name}, Title: {title}, Date: {date}";
        }
    }
}
