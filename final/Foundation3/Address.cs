namespace EventPlanning
{
    public class Address
    {
        private string street;
        private string city;
        private string state;
        private string country;

        public Address(string street, string city, string state, string country)
        {
            this.street = street;
            this.city = city;
            this.state = state;
            this.country = country;
        }

        public string GetFullAddress()
        {
            return $"{street}, {city}, {state}, {country}";
        }
    }
}
