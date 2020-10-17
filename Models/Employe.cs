using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelloWorld.Models
{
    [Table("Employe")]
    public class Employe
    {
        protected Employe()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public virtual ICollection<Telephone> Telephones { get; set; }
    }
}