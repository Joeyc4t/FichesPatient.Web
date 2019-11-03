using FichePatient.DAL.Entities;
using System.Configuration;
using Tools.Generic;

namespace FichePatient.DAL.Repositories
{
    public class LocaliteRepository : BaseRepository<LocaliteEntity>
    {
        public LocaliteRepository() : base(ConfigurationManager.AppSettings["provider"], ConfigurationManager.AppSettings["connString"]) { }
    }
}
