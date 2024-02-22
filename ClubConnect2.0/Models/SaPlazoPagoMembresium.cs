using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaPlazoPagoMembresium
{
    public string? CodEmpresa { get; set; }

    public decimal CodPlaMem { get; set; }

    public string? CodTipoMembresia { get; set; }

    public string? PeriodoPago { get; set; }

    public decimal? Monto { get; set; }

    public string? CodEstado { get; set; }

    public decimal? Mensualidad { get; set; }

    public string? TipoAdquisicion { get; set; }

    public decimal? CodPerPag { get; set; }
}
