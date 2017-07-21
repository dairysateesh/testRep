using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPP.Models
{
    public interface IPatientSchedulesRepository
    {
        IEnumerable<PatientSchedule> SelectAll();
        PatientSchedule SelectByID(string id);
        void Insert(PatientSchedule obj);
        void Update(PatientSchedule obj);
        void Delete(string id);
        void Save();
    }
}