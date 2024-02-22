using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaExcepcionesImporte
{
    public int CodExcepcion { get; set; }

    public string? Parametro { get; set; }

    public string? CodImporte { get; set; }

    public string? CodTercero { get; set; }

    public string? CodTipo { get; set; }

    public string? CodEstado { get; set; }

    public DateTime? FecIni { get; set; }

    public DateTime? FecFin { get; set; }
}
