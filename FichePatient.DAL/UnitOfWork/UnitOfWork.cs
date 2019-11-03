using FichePatient.DAL.Entities;
using FichePatient.DAL.Repositories;

using Tools.Generic;

namespace FichePatient.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region FIELDS
        private IRepository<PatientEntity> _PatientRepository;
        private IRepository<EtatSanteEntity> _EtatSanteRepository;
        private IRepository<LocaliteEntity> _LocaliteRepository;
        private IRepository<SoinEntity> _SoinRepository;
        #endregion

        #region PROPERTIES
        public IRepository<PatientEntity> PatientRepository
        {
            get
            {
                if (_PatientRepository == null) { _PatientRepository = new PatientRepository(); }
                return _PatientRepository;
            }
        }

        public IRepository<EtatSanteEntity> EtatSanteRepository
        {
            get
            {
                if (_EtatSanteRepository == null) { _EtatSanteRepository = new EtatSanteRepository(); }
                return _EtatSanteRepository;
            }
        }

        public IRepository<LocaliteEntity> LocaliteRepository
        {
            get
            {
                if (_LocaliteRepository == null) { _LocaliteRepository = new LocaliteRepository(); }
                return _LocaliteRepository;
            }
        }

        public IRepository<SoinEntity> SoinRepository
        {
            get
            {
                if (_SoinRepository == null) { _SoinRepository = new SoinRepository(); }
                return _SoinRepository;
            }
        }
        #endregion

        #region METHODS
        public void Dispose() { }
        #endregion
    }
}
