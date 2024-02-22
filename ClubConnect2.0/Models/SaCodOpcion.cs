using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaCodOpcion
{
    public string CodEmpresa { get; set; } = null!;

    public string CodOpcion { get; set; } = null!;

    public string DesOpcion { get; set; } = null!;

    public virtual SaCodEmpresa CodEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<SaSeguridad> SaSeguridads { get; set; } = new List<SaSeguridad>();
}
