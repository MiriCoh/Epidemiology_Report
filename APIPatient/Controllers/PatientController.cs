using APIPatient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIPatient.Controllers
{
    public class PatientController : ApiController
    {
        // GET: api/Patient
        PatientDatabaseContext connectDB = new PatientDatabaseContext();
        public List<PatientModel> Get()
        {
            return connectDB.Patients_lst.ToList();
        }

        [HttpGet]
        [Route("api/Patient/GetPatientLocationsByCity/{city}")]
        public List<PatientModel> Get(string city)
        {
            return connectDB.GetPatientLocationsByCity(city);

        }
        [HttpGet]
        [Route("api/Patient/GetPatientLocationsByID/{id}")]
        public List<PatientModel> Get(int id)
        {
            return connectDB.GetPatientLocationsByID(id);

        }
        //POST: api/Patient
        public void Post(PatientModel pm)
        {
            connectDB.AddLocation(pm);
        }

    }
}
