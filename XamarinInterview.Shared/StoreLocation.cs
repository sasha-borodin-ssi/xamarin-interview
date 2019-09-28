using System;
namespace XamarinInterview.Shared
{
    public class StoreLocation
    {
        public string Number { get; set; }
        public string Name { get; set; }

        public string City { get; set; }
        public string State { get; set; }

        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }



        public string CityState => $"{City}, {State}";
    }
}
