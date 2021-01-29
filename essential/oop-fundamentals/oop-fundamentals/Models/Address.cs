namespace oop_fundamentals.Models
{
    internal class Address
    {
        private string index;
        public string Index
        {
            get => index;
            set => index = value;
        }


        private string country;
        public string Country
        {
            get => country;
            set => country = value;
        }


        private string city;
        public string City
        {
            get => city;
            set => city = value;
        }


        private string street;
        public string Street
        {
            get => street;
            set => street = value;
        }

        private string house;
        public string House
        {
            get => house;
            set => house = value;
        }

        private string apartment;
        public string Apartment
        {
            get => apartment;
            set => apartment = value;
        }
    }
}
