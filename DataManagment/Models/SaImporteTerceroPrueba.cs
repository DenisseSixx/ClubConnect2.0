using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaImporteTerceroPrueba
{
    public string CodEmpresa { get; set; } = null!;

    public string CodCliente { get; set; } = null!;

    public string CodTercero { get; set; } = null!;

    public DateTime CodPeriodo { get; set; }

    public decimal CodImporte { get; set; }

    public decimal? MontoOriginal { get; set; }

    public decimal Monto { get; set; }

    public DateTime FecRegistro { get; set; }

    public string Extra01 { get; set; } = null!;

    public string Extra02 { get; set; } = null!;

    public string CodEstado { get; set; } = null!;

    public decimal? Cargo { get; set; }

    public decimal? Abono { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? Bonificacion { get; set; }

    public decimal? Saldo { get; set; }

    public decimal? NumPeriodo { get; set; }

    public decimal? TotPeriodos { get; set; }

    public string? CodUsuario { get; set; }
}
