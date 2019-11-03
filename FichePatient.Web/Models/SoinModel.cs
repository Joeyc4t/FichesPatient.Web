using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace FichePatient.Web.Models
{
    public class SoinModel
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Date")]
        [Required]
        public DateTime? DATE { get; set; }
        [DisplayName("Traitement")]
        [AllowHtml]
        public string TRAITEMENT { get; set; }
        [DisplayName("Pansements")]
        [AllowHtml]
        public string PANSEMENTS { get; set; }
        [DisplayName("Conseils")]
        [AllowHtml]
        public string CONSEILS { get; set; }
        public int PATIENT_ID { get; set; }
    }
}