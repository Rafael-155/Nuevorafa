using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nuevorafa.Models
{
    [Table("t_cafe")]
    public class Producto
    {

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name="Identificador")] 
    [Column("id")]
    public int ID { get; set; }

    [Required(ErrorMessage="Debe ingresar el nombre del cafe a registrar")]
    [Display(Name="Nombre")] 
    [Column("name")]
    public string nombre { get; set; }

    [Required(ErrorMessage="Debe ingresar el autor del cafe a registrar")]
    [Display(Name="Autor del cafe")] 
    [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Solo se permiten letras")]
    [Column("autor")]
    public string autor { get; set; }

    [Required(ErrorMessage="Debe ingresar el idioma del cafe a registrar")]
    [Display(Name="Idioma del producto")] 
    [Column("idioma")]
    public string idioma { get; set; }

    [Required(ErrorMessage="Debe ingresar el ISBN del cafe a registrar")]
    [Display(Name="ISBN del cafe")] 
    [Column("isbn")]
    public string isbn { get; set; }

    [Required(ErrorMessage="Debe ingresar la editorial del cafe a registrar")]
    [Display(Name="Editorial del cafe")] 
    [Column("editorial")]
    public string editorial { get; set; }

    [Required(ErrorMessage="Debe ingresar el precio del cafe a registrar")]
    [Display(Name="Precio del producto")] 
    [Column("precio")]
    public Decimal precio { get; set; }

    [Required(ErrorMessage="Debe ingresar las paginas del cafe a registrar")]
    [Display(Name="Paginas del cafe")] 
    [Column("pages")]
    public int? pagina { get; set; }

    [Required(ErrorMessage="Debe ingresar la descripcion del cafe a registrar")]
    [Display(Name="Descripcion del cafe")] 
    [Column("descripcion")]
    public string descripcion { get; set; }

    [Required(ErrorMessage="Debe ingresar la imagen del cafe a registrar")]
    [Display(Name="URL de imagen del cafe")] 
    [Column("imagen")]
    public string imagen { get; set; }


    [NotMapped]
    public String Respuesta { get; set; }

    }
}