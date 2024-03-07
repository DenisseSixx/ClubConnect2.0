using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaCodAcceso
{
    public string CodEmpresa { get; set; } = null!;

    public string CodAcceso { get; set; } = null!;

    public string DesAcceso { get; set; } = null!;

    public virtual ICollection<SaSeguridad> SaSeguridads { get; set; } = new List<SaSeguridad>();
}
