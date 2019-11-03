using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FichePatient.DAL.Entities
{
    [Table("LOCALITE")]
    public class LocaliteEntity
    {
        [Key]
        public int ID { get; set; }
        public string NOM { get; set; }
        public int CODE_POSTAL { get; set; }
        public string COMMUNE { get; set; }
        public string PROVINCE { get; set; }
    }
}
