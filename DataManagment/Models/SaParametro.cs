using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaParametro
{
    public string CodEmpresa { get; set; } = null!;

    public string CodGrupo { get; set; } = null!;

    public string CodSubgrupo { get; set; } = null!;

    public string CodParametro { get; set; } = null!;

    public string DesParametro { get; set; } = null!;

    public string ValParametro { get; set; } = null!;

    public virtual SaCodGrupoPar SaCodGrupoPar { get; set; } = null!;
}
