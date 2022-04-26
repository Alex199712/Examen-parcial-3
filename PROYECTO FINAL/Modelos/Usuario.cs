using System.ComponentModel.DataAnnotations;

namespace Modelos;

public class Usuario
{
    [Required(ErrorMessage = "Codigo Obligatorio")]
    public string Codigo { get; set; }
    [Required(ErrorMessage = "Codigo Obligatorio")]
    public string Nombre { get; set; }
    [Required(ErrorMessage = "Codigo Obligatorio")]
    public string Rol { get; set; }
    public string Clave { get; set; }
    public bool EstaActivo { get; set; }
}
