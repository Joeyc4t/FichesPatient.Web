using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace FichePatient.Web.Models
{
    public class EtatSanteModel
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Auto examen des pieds possible")]
        public bool AUTO_EXAMEN_POSSIBLE { get; set; }
        public string AUTO_EXAMEN_POSSIBLE_DESC { get; set; }
        [DisplayName("PG")]
        public bool MONOFILAMENT_PG_FAIT { get; set; }
        public string MONOFILAMENT_PG_FAIT_DESC { get; set; }
        [DisplayName("PD")]
        public bool MONOFILAMENT_PD_FAIT { get; set; }
        public string MONOFILAMENT_PD_FAIT_DESC { get; set; }
        public int? MONOFILAMENT_PG_COTE { get; set; }
        public int? MONOFILAMENT_PD_COTE { get; set; }
        [DisplayName("Type 1")]
        public bool DIABETE_TYPE_1 { get; set; }
        public string DIABETE_TYPE_1_DESC { get; set; }
        [DisplayName("Type 2")]
        public bool DIABETE_TYPE_2 { get; set; }
        public string DIABETE_TYPE_2_DESC { get; set; }
        [DisplayName("Secondaire")]
        public bool DIABETE_SECONDAIRE { get; set; }
        public string DIABETE_SECONDAIRE_DESC { get; set; }
        [DisplayName("G")]
        public bool PROTHESE_GENOU_G { get; set; }
        public string PROTHESE_GENOU_G_DESC { get; set; }
        [DisplayName("D")]
        public bool PROTHESE_GENOU_D { get; set; }
        public string PROTHESE_GENOU_D_DESC { get; set; }
        [DisplayName("G")]
        public bool PROTHESE_HANCHE_G { get; set; }
        public string PROTHESE_HANCHE_G_DESC { get; set; }
        [DisplayName("D")]
        public bool PROTHESE_HANCHE_D { get; set; }
        public string PROTHESE_HANCHE_D_DESC { get; set; }
        [DisplayName("Maladies cardiaques")]
        public bool MALADIES_CARDIAQUES { get; set; }
        public string MALADIES_CARDIAQUES_DESC { get; set; }
        [DisplayName("Valve cardiaque")]
        public bool VALVE_CARDIAQUE { get; set; }
        public string VALVE_CARDIAQUE_DESC { get; set; }
        [DisplayName("Anti-coagulant")]
        public bool ANTI_COAGULANT { get; set; }
        public string ANTI_COAGULANT_DESC { get; set; }
        [DisplayName("Thyroïde")]
        public bool THYROIDE { get; set; }
        public string THYROIDE_DESC { get; set; }
        [DisplayName("Transplanté rénal")]
        public bool TRANSPLANTE_RENAL { get; set; }
        public string TRANSPLANTE_RENAL_DESC { get; set; }
        [DisplayName("Allergies")]
        public bool ALLERGIES { get; set; }
        public string ALLERGIES_DESC { get; set; }
        [DisplayName("Autre")]
        public bool AUTRE { get; set; }
        public string AUTRE_DESC { get; set; }
        [DisplayName("Normale")]
        public bool CIRCULATION_SANGUINE_NORMALE { get; set; }
        public string CIRCULATION_SANGUINE_NORMALE_DESC { get; set; }
        [DisplayName("Varices/varicosités")]
        public bool CIRCULATION_SANGUINE_VARICES { get; set; }
        public string CIRCULATION_SANGUINE_VARICES_DESC { get; set; }
        [DisplayName("Œdème")]
        public bool CIRCULATION_SANGUINE_OEDEME { get; set; }
        public string CIRCULATION_SANGUINE_OEDEME_DESC { get; set; }
        [DisplayName("Sécheresse/Anidrose")]
        public bool TROUBLE_SUDATION_ANIDROSE { get; set; }
        public string TROUBLE_SUDATION_ANIDROSE_DESC { get; set; }
        [DisplayName("Hyperhydrose")]
        public bool TROUBLE_SUDATION_HYPERHYDROSE { get; set; }
        public string TROUBLE_SUDATION_HYPERHYDROSE_DESC { get; set; }
        [DisplayName("Bromidrose")]
        public bool TROUBLE_SUDATION_BROMIDROSE { get; set; }
        public string TROUBLE_SUDATION_BROMIDROSE_DESC { get; set; }
        [DisplayName("Durillon")]
        public bool HYPERKERATOSES_DURILLON { get; set; }
        public string HYPERKERATOSES_DURILLON_DESC { get; set; }
        [DisplayName("Cor péri-unguéal")]
        public bool HYPERKERATOSES_COR_PERI_UNGUEAL { get; set; }
        public string HYPERKERATOSES_COR_PERI_UNGUEAL_DESC { get; set; }
        [DisplayName("Cor sous-ungéal")]
        public bool HYPERKERATOSES_COR_SOUS_UNGUEAL { get; set; }
        public string HYPERKERATOSES_COR_SOUS_UNGUEAL_DESC { get; set; }
        [DisplayName("Cor articulation interphalangienne")]
        public bool HYPERKERATOSES_COR_ARTICULATION_INTERPHA { get; set; }
        public string HYPERKERATOSES_COR_ARTICULATION_INTERPHA_DESC { get; set; }
        [DisplayName("Cor pulpaire")]
        public bool HYPERKERATOSES_COR_PULPAIRE { get; set; }
        public string HYPERKERATOSES_COR_PULPAIRE_DESC { get; set; }
        [DisplayName("Cor plantaire")]
        public bool HYPERKERATOSES_COR_PLANTAIRE { get; set; }
        public string HYPERKERATOSES_COR_PLANTAIRE_DESC { get; set; }
        [DisplayName("Œil de perdrix")]
        public bool HYPERKERATOSES_OEIL_PERDRIX { get; set; }
        public string HYPERKERATOSES_OEIL_PERDRIX_DESC { get; set; }
        [DisplayName("Ampoule/phlyctène")]
        public bool HYPERKERATOSES_AMPOULE { get; set; }
        public string HYPERKERATOSES_AMPOULE_DESC { get; set; }
        [DisplayName("Rhagade/crevasse")]
        public bool HYPERKERATOSES_RHAGADE { get; set; }
        public string HYPERKERATOSES_RHAGADE_DESC { get; set; }
        [DisplayName("Eczéma")]
        public bool HYPERKERATOSES_ECZEMA { get; set; }
        public string HYPERKERATOSES_ECZEMA_DESC { get; set; }
        [DisplayName("Verrue")]
        public bool HYPERKERATOSES_VERRUE { get; set; }
        public string HYPERKERATOSES_VERRUE_DESC { get; set; }
        [DisplayName("Psoriasis")]
        public bool HYPERKERATOSES_PSORIASIS { get; set; }
        public string HYPERKERATOSES_PSORIASIS_DESC { get; set; }
        [DisplayName("Remarques")]
        [AllowHtml]
        public string REMARQUES { get; set; }
    }
}