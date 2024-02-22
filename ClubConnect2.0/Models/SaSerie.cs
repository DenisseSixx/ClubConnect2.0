using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaSerie
{
    public string CodEmpresa { get; set; } = null!;

    public string CodGrupo { get; set; } = null!;

    public string CodSubgrupo { get; set; } = null!;

    public string CodSerie { get; set; } = null!;

    public string DesSerie { get; set; } = null!;

    public decimal NumSerie { get; set; }

    public virtual SaCodGrupoSer SaCodGrupoSer { get; set; } = null!;
}
