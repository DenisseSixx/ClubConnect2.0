using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaBitacoraGeneracion
{
    public decimal Id { get; set; }

    public DateTime? Periodo { get; set; }

    public DateTime? FecInicio { get; set; }

    public DateTime? FecFin { get; set; }

    public string? Usuario { get; set; }

    public DateTime? FecRegistro { get; set; }

    public string? UsuModificacion { get; set; }

    public DateTime? FecModificacion { get; set; }
}
