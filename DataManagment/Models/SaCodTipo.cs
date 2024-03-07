using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaCodTipo
{
    public string CodEmpresa { get; set; } = null!;

    public string CodTipo { get; set; } = null!;

    public string DesTipo { get; set; } = null!;

    public virtual SaCodEmpresa CodEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<SaCodSubtipo> SaCodSubtipos { get; set; } = new List<SaCodSubtipo>();
}
