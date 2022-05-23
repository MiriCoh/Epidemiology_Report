using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIPatient.Models
{


    public class PatientModel
    {
        public Location Location { get; set; }
        public int ID { get; set; } = 123;
        public PatientModel()
        {

        }
        public PatientModel(Location locations)
        {
            this.Location = locations;
            this.ID = ID*10+ID/10%10;
        }
    }
}