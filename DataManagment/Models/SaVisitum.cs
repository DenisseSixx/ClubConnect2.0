using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaVisitum
{
    public string CodEmpresa { get; set; } = null!;

    public string CodCliente { get; set; } = null!;

    public string CodTercero { get; set; } = null!;

    public decimal? CodDependiente { get; set; }

    public DateTime? FecVisita { get; set; }

    public string? CodAcceso { get; set; }
}
