using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FichePatient.DAL.Entities
{
    [Table("PATIENT")]
    public class PatientEntity
    {
        [Key]
        public int ID { get; set; }
        public string CIVILITE { get; set; }
        public string NOM_FAMILLE { get; set; }
        public string PRENOM { get; set; }
        public string RUE { get; set; }
        public string NUMERO { get; set; }
        public int LOCALITE_ID { get; set; }
        public DateTime DATE_NAISSANCE { get; set; }
        public string TELEPHONE { get; set; }
        public string EMAIL { get; set; }
        public string MEDECIN_TRAITANT { get; set; }
        public string MEDECIN_TRAITANT_TELEPHONE { get; set; }
        public int ETAT_SANTE_ID { get; set; }
        public bool STATUTENREGISTREMENT { get; set; }
    }
}
