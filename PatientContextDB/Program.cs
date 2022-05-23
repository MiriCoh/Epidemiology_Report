using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientContextDB
{
    public class PatientDatabaseContext
    {
        public List<PatientModel> Patient_lst = new List<PatientModel>();
        public PatientDatabaseContext()
        {
            PatientModel p1 = new PatientModel() { City = "bb", Location = "centeral station", StartDate = new System.DateTime(2020, 5, 20), EndDate = new System.DateTime(2020, 6, 20) };
            PatientModel p2 = new PatientModel() { City = "bb", Location = "centeral station", StartDate = new System.DateTime(2020, 5, 20), EndDate = new System.DateTime(2020, 5, 21) };
            PatientModel p3 = new PatientModel() { City = "Jerusalem", Location = "Mall", StartDate = new System.DateTime(2020, 5, 22), EndDate = new System.DateTime(2020, 5, 23) };
            Patient_lst.Add(p1);
            Patient_lst.Add(p2);
            Patient_lst.Add(p3);
        }
    }
}
