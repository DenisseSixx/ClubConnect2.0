using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaConsumo
{
    public string CodEmpresa { get; set; } = null!;

    public decimal CodConsumo { get; set; }

    public string? Serie { get; set; }

    public decimal? Folio { get; set; }

    public decimal? Monto { get; set; }

    public DateTime? Fecha { get; set; }

    public string? CodCaja { get; set; }

    public string? CodUsuario { get; set; }

    public string? CodEstado { get; set; }

    public string? CodCliente { get; set; }

    public string? CodTercero { get; set; }

    public decimal? CodDependiente { get; set; }

    public decimal? CodCajaVen { get; set; }

    public decimal? CodCajaDetalleVen { get; set; }

    public decimal? CodVenta { get; set; }
}
