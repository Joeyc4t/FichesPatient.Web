using FichePatient.DAL.Entities;
using System;
using Tools.Generic;

namespace FichePatient.DAL.UnitOfWork
{
    interface IUnitOfWork : IDisposable
    {
        IRepository<PatientEntity> PatientRepository { get; }
        IRepository<EtatSanteEntity> EtatSanteRepository { get; }
        IRepository<LocaliteEntity> LocaliteRepository { get; }
        IRepository<SoinEntity> SoinRepository { get; }
    }
}
