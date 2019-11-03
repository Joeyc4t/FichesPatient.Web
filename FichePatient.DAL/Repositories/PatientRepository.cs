using FichePatient.DAL.Entities;
using System.Configuration;
using Tools.Generic;

namespace FichePatient.DAL.Repositories
{
    public class PatientRepository : BaseRepository<PatientEntity>
    {
        public PatientRepository() : base(ConfigurationManager.AppSettings["provider"], ConfigurationManager.AppSettings["connString"]) { }
    }
}
