using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaMovimientosDetum
{
    public string CodEmpresa { get; set; } = null!;

    public decimal CodMovimiento { get; set; }

    public string CodTipo { get; set; } = null!;

    public decimal CodDetalle { get; set; }

    public decimal CodImporte { get; set; }

    public string CodSubtipo { get; set; } = null!;

    public string? CodTipoTransaccion { get; set; }

    public string? CodTransaccion { get; set; }

    public DateTime? CodPeriodo { get; set; }

    public decimal? TotPeriodos { get; set; }

    public string Extra01 { get; set; } = null!;

    public string Extra02 { get; set; } = null!;

    public string? CodFactura { get; set; }

    public string? CodRecibo { get; set; }

    public string? CodReferencia { get; set; }

    public decimal? MonOriginal { get; set; }

    public decimal? MonAdeudoAnterior { get; set; }

    public decimal? MonAdeudoAnteriorSinRecargo { get; set; }

    public decimal? Recargo { get; set; }

    public decimal? MonBonificacion { get; set; }

    public decimal? MonDescuento { get; set; }

    public decimal? MonSubtotalAdeudo { get; set; }

    public decimal? PorIva { get; set; }

    public decimal? MonIvaAdeudo { get; set; }

    public decimal? MonTotalAdeudo { get; set; }

    public decimal? AFavorAplicado { get; set; }

    public decimal? CobradoAplicado { get; set; }

    public string? CodEstado { get; set; }
}
