using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaImporteBonificacion
{
    public string CodEmpresa { get; set; } = null!;

    public string CodCliente { get; set; } = null!;

    public string CodTercero { get; set; } = null!;

    public decimal CodImporte { get; set; }

    public decimal? Monto { get; set; }

    public virtual SaImporte SaImporte { get; set; } = null!;

    public virtual SaTercero SaTercero { get; set; } = null!;
}
