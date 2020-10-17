using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelloWorld.Models
{
    [Table("Telephone")]
    public class Telephone
    {
        protected Telephone()
        {
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public int EmployeId { get; set; }

        // [ForeignKey("EmployeId")]
        public virtual Employe Employe { get; set; }

        public int TypeTelephoneId { get; set; }

        // [ForeignKey("TypeTelephoneId")]
        public virtual TypeTelephone TypeTelephone { get; set; }

        public string Numero { get; set; }
    }
}