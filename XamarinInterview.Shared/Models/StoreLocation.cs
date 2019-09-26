using System;
namespace XamarinInterview.Shared.Models
{
    public class StoreLocation
    {
        public string Number { get; set; }
        public string Name { get; set; }

        public string City { get; set; }
        public string State { get; set; }

        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
