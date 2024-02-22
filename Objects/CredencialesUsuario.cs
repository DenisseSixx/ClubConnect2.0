using System.ComponentModel.DataAnnotations;

namespace Objects;

public class CredencialesUsuario
{
    [Required]
    public string CodTercero { get; set; }
    [Required]
    public string Clave { get; set; }
}