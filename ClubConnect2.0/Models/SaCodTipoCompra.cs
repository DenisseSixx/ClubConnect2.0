using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaCodTipoCompra
{
    public string CodEmpresa { get; set; } = null!;

    public string CodTipoCompra { get; set; } = null!;

    public string DesTipoCompra { get; set; } = null!;

    public virtual SaCodEmpresa CodEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<SaTercero> SaTerceros { get; set; } = new List<SaTercero>();
}
