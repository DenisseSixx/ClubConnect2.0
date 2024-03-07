using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaDocumento
{
    public string CodEmpresa { get; set; } = null!;

    public string CodTipoDocumento { get; set; } = null!;

    public string CodSerie { get; set; } = null!;

    public decimal CodDocumento { get; set; }

    public string? CodCliente { get; set; }

    public string? CodTercero { get; set; }

    public decimal? CodMovimiento { get; set; }

    public DateTime? FecDocumento { get; set; }

    public decimal? MonDocumento { get; set; }

    public string? Observacion { get; set; }

    public string? CodSistema { get; set; }

    public string? CodEstado { get; set; }

    public string? CodTipoMovimiento { get; set; }

    public virtual SaCodEmpresa CodEmpresaNavigation { get; set; } = null!;
}
