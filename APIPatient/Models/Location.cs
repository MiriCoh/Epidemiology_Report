using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIPatient.Models
{
    public class Location
    {
        public string City { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Location(string city, string location, DateTime startDate, DateTime endDate)
        {
            this.City = city;
            this.Description = location;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
        public Location()
        {

        }
    }
}