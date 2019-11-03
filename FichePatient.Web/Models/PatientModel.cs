using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FichePatient.Web.Models
{
    public class PatientModel
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Civilité")]
        [Required]
        public string CIVILITE { get; set; }
        [DisplayName("Nom de famille")]
        [Required]
        public string NOM_FAMILLE { get; set; }
        [DisplayName("Prénom")]
        [Required]
        public string PRENOM { get; set; }
        [DisplayName("Adresse")]
        [Required]
        public string RUE { get; set; }
        [DisplayName("Numéro")]
        [Required]
        public string NUMERO { get; set; }
        [DisplayName("Localité")]
        [Required]
        public int LOCALITE_ID { get; set; }
        [DisplayName("Date de naissance")]
        [Required]
        public DateTime DATE_NAISSANCE { get; set; }
        [DisplayName("Téléphone")]
        public string TELEPHONE { get; set; }
        [DisplayName("Adresse mail")]
        public string EMAIL { get; set; }
        [DisplayName("Médecin traitant")]
        public string MEDECIN_TRAITANT { get; set; }
        [DisplayName("Téléphone médecin traitant")]
        public string MEDECIN_TRAITANT_TELEPHONE { get; set; }
        public int ETAT_SANTE_ID { get; set; }
        public bool STATUTENREGISTREMENT { get; set; }
    }
}