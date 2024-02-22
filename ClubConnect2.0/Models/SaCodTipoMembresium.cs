using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaCodTipoMembresium
{
    public string CodEmpresa { get; set; } = null!;

    public string CodTipoMembresia { get; set; } = null!;

    public string? DesTipoMembresia { get; set; }

    public decimal? Monto { get; set; }

    public string? CodEstado { get; set; }

    public virtual SaCodEmpresa CodEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<SaTercero> SaTerceros { get; set; } = new List<SaTercero>();
}
