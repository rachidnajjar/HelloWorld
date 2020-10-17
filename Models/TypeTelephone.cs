using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelloWorld.Models
{
    [Table("TypeTelephone")]
    public class TypeTelephone
    {
        protected TypeTelephone()
        {
        }
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Libelle { get; set; }

    }
}