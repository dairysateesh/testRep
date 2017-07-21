using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPP.Models
{
    public class PatientSchedulesRepository : IPatientSchedulesRepository
    {
        private AppDBEntities db = null;

        public PatientSchedulesRepository()
        {
            this.db = new AppDBEntities();
        }

        public PatientSchedulesRepository(AppDBEntities db)
        {
            this.db = db;
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(PatientSchedule obj)
        {
            db.PatientSchedules.Add(obj);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<PatientSchedule> SelectAll()
        {
            throw new NotImplementedException();
        }

        public PatientSchedule SelectByID(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(PatientSchedule obj)
        {
            throw new NotImplementedException();
        }
    }
}