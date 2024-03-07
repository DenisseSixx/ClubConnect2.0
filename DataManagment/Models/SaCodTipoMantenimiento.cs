using System;
using System.Collections.Generic;

namespace DataManagment.Models;
public partial class SaCodTipoMantenimiento
{
    public string CodEmpresa { get; set; } = null!;

    public string CodTipoMantenimiento { get; set; } = null!;

    public string? DesTipoMantenimiento { get; set; }

    public decimal? Monto { get; set; }

    public string? CodEstado { get; set; }

    public virtual SaCodEmpresa CodEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<SaTercero> SaTerceros { get; set; } = new List<SaTercero>();
}
