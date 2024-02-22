using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaCodGrupoPar
{
    public string CodEmpresa { get; set; } = null!;

    public string CodGrupo { get; set; } = null!;

    public string DesGrupo { get; set; } = null!;

    public virtual SaCodEmpresa CodEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<SaParametro> SaParametros { get; set; } = new List<SaParametro>();
}
