using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaMovimientosEnca
{
    public string CodEmpresa { get; set; } = null!;

    public decimal CodMovimiento { get; set; }

    public string CodCliente { get; set; } = null!;

    public string CodTercero { get; set; } = null!;

    public DateTime FecMovimiento { get; set; }

    public string? CodTipoTransaccion { get; set; }

    public string? CodTransaccion { get; set; }

    public string CodEstado { get; set; } = null!;

    public string Extra01 { get; set; } = null!;

    public string Extra02 { get; set; } = null!;

    public string CodSucursal { get; set; } = null!;

    public string CodUsuario { get; set; } = null!;

    public DateTime? FecReal { get; set; }

    public string? CodComrobante { get; set; }

    public string? CodInstrumento { get; set; }

    public decimal? CodBanco { get; set; }

    public string? Referencia { get; set; }

    public string? SerieRecibo { get; set; }

    public decimal? CodRecibo { get; set; }

    public string? SerieFactura { get; set; }

    public decimal? CodFactura { get; set; }

    public string? CodTipoDocumento { get; set; }

    public string? CodSerie { get; set; }

    public decimal? CodDocumento { get; set; }

    public string? Observacion { get; set; }

    public string? UsuarioCancelacion { get; set; }

    public DateTime? FechaCancelacion { get; set; }

    public decimal? MonAdeudoAnterior { get; set; }

    public decimal? MonBonificacion { get; set; }

    public decimal? MonDescuento { get; set; }

    public decimal? MonSubtotalAdeudo { get; set; }

    public decimal? MonIvaAdeudo { get; set; }

    public decimal? MonTotalAdeudo { get; set; }

    public decimal? MonSaldoFavorAnterior { get; set; }

    public decimal? MonCobrar { get; set; }

    public decimal? MonDisponible { get; set; }

    public decimal? MonAplicar { get; set; }

    public decimal? MonSaldoFavor { get; set; }

    public decimal? MonSubtotalAplicado { get; set; }

    public decimal? MonIvaAplicado { get; set; }

    public decimal? MonTotalAplicado { get; set; }

    public decimal? TotalAbono { get; set; }

    public decimal? CodMenMembresia { get; set; }

    public decimal? CodMenMembresiaAnt { get; set; }

    public decimal? CodAnuMembresia { get; set; }

    public decimal? CodAnuMembresiaAnt { get; set; }

    public string? DesMenMembresia { get; set; }

    public string? DesAnuMembresia { get; set; }

    public DateTime? FecFacturacion { get; set; }

    public string? CobCargoTarjeta { get; set; }

    public virtual SaCodBanco? SaCodBanco { get; set; }

    public virtual SaCodTransaccion? SaCodTransaccion { get; set; }

    public virtual SaTercero SaTercero { get; set; } = null!;
}
