using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaCodTransaccionMembresium
{
    public string CodEmpresa { get; set; } = null!;

    public decimal CodBitacoraMembresia { get; set; }

    public decimal? CodTransaccionMembresia { get; set; }

    public string? Observacion { get; set; }

    public DateTime? Fecha { get; set; }

    public string? CodSucursal { get; set; }

    public string? CodUsuario { get; set; }

    public string? CodEstado { get; set; }

    public string? CodTercero { get; set; }
}
