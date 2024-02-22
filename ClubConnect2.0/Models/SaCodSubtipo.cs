using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaCodSubtipo
{
    public string CodEmpresa { get; set; } = null!;

    public string CodTipo { get; set; } = null!;

    public string CodSubtipo { get; set; } = null!;

    public string DesSubtipo { get; set; } = null!;

    public virtual SaCodTipo SaCodTipo { get; set; } = null!;

    public virtual ICollection<SaImporte> SaImportes { get; set; } = new List<SaImporte>();
}
