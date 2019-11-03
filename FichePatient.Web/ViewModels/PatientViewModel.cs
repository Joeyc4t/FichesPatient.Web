using FichePatient.Web.Models;
using System.Collections.Generic;

namespace FichePatient.Web.ViewModels
{
    public class PatientViewModel
    {
        public PatientModel patient { get; set; }
        public EtatSanteModel etatSante { get; set; }
        public IEnumerable<SoinModel> soins { get; set; }
    }
}