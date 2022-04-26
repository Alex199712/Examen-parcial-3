using System.ComponentModel.DataAnnotations;

namespace Modelos;

public class Producto
{
    [Required(ErrorMessage = "Codigo Obligatorio ")]
    public string Codigo { get; set; }
    [Required(ErrorMessage = "Codigo Obligatorio")]
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public int Existencia { get; set; }
    public byte[] Imagen { get; set; }
}
