using FichePatient.DAL.Entities;
using System.Configuration;
using Tools.Generic;

namespace FichePatient.DAL.Repositories
{
    public class SoinRepository : BaseRepository<SoinEntity>
    {
        public SoinRepository() : base(ConfigurationManager.AppSettings["provider"], ConfigurationManager.AppSettings["connString"]) { }
    }
}
