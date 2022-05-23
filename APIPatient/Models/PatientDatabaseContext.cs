using System.Collections.Generic;
using System;
using System.Linq;
namespace APIPatient.Models
{
    public class PatientDatabaseContext
    {
       public List<PatientModel> Patients_lst = new List<PatientModel>();
        public PatientDatabaseContext()
        {
            PatientModel l0 = new PatientModel() {Location= new Location() {City= "bb", Description = "park", StartDate = new System.DateTime(2020, 5, 19), EndDate = new System.DateTime(2020, 6, 20) },ID=123456 };
            PatientModel l1 = new PatientModel() { Location = new Location() { City = "bb", Description = "centeral station", StartDate = new System.DateTime(2020, 5, 20), EndDate = new System.DateTime(2020, 6, 20) }, ID = 123456 };
            PatientModel l2 = new PatientModel() { Location = new Location() { City = "jerusalem", Description = "centeral station", StartDate = new System.DateTime(2020, 5, 20), EndDate = new System.DateTime(2020, 6, 20) }, ID = 1234567 };
            PatientModel l3 = new PatientModel() { Location = new Location() { City = "bb", Description = "centeral station", StartDate = new System.DateTime(2020, 5, 20), EndDate = new System.DateTime(2020, 6, 20) }, ID = 123456789 };
            Patients_lst.Add(l0);
            Patients_lst.Add(l1);
            Patients_lst.Add(l2);
            Patients_lst.Add(l3);
        }
        public List<PatientModel> GetPatientLocationsByCity(string city)
        {
            return Patients_lst.FindAll(p => p.Location.City == city);
        }
        public List<PatientModel> GetPatientLocationsByID(int id)
        {
            return Patients_lst.FindAll(p => p.ID == id);
        }
        public void AddLocation(PatientModel pm=null)
        {
            PatientModel newLocation= new PatientModel() 
            { ID = 123456, Location = new Location { City = pm.Location.City, Description = pm.Location.Description, StartDate = pm.Location.StartDate, EndDate = pm.Location.EndDate } };
            Patients_lst.Add(newLocation);
            //אם המורה התכוונה להכניס שרירותי לחלוטין...
            //PatientModel newLocation = new PatientModel()
            //{ ID = 123, Locations = new Locations { City = "bbb", Location = "centeral station", StartDate = new DateTime(), EndDate = new DateTime(2022,5,10) }};
            //Patients_lst.Add(newLocation);
        }
    }
}