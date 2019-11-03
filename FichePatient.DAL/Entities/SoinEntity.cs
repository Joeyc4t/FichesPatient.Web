using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FichePatient.DAL.Entities
{
    [Table("SOIN")]
    public class SoinEntity
    {
        [Key]
        public int ID { get; set; }
        public DateTime DATE { get; set; }
        public string TRAITEMENT { get; set; }
        public string PANSEMENTS { get; set; }
        public string CONSEILS { get; set; }
        public int PATIENT_ID { get; set; }
    }
}
