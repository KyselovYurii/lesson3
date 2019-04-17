namespace lesson3
{
    class Barcelona
    {
        public Barcelona(int id, string name, string zipCode, 
            string location, string country, double latitude, double longitude)
        {
            Id = id;
            Name = name;
            ZipCode = zipCode;
            Location = location;
            Country = country;
            Latitude = latitude;
            Longitude = longitude;
        }

        public int Id { get; }

        public string Name { get; }

        public string ZipCode { get; }

        public string Location { get; }

        public string Country { get; }

        public double Latitude { get; }

        public double Longitude { get; }
    }
}
