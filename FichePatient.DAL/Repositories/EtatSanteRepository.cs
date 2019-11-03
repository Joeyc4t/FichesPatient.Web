using FichePatient.DAL.Entities;
using System.Configuration;
using Tools.Generic;

namespace FichePatient.DAL.Repositories
{
    public class EtatSanteRepository : BaseRepository<EtatSanteEntity>
    {
        public EtatSanteRepository() : base(ConfigurationManager.AppSettings["provider"], ConfigurationManager.AppSettings["connString"]) { }
    }
}
