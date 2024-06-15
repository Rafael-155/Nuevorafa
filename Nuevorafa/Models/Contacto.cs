using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nuevorafa.Models
{
    [Table("t_contacto")]
    public class Contacto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set;}
        public String? Name { get; set; }
        public String? Email { get; set; }

        public String? Message { get; set; }
        public String? Category { get; set; }
    }
}
