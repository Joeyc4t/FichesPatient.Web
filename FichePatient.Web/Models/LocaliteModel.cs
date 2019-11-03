using System.ComponentModel.DataAnnotations;

namespace FichePatient.Web.Models
{
    public class LocaliteModel
    {
        [Key]
        public int ID { get; set; }
        public string NOM { get; set; }
        public int CODE_POSTAL { get; set; }
        public string COMMUNE { get; set; }
        public string PROVINCE { get; set; }
    }
}