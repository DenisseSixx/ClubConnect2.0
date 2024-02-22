using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaSeguridad
{
    public string CodEmpresa { get; set; } = null!;

    public string CodOpcion { get; set; } = null!;

    public string CodGrupo { get; set; } = null!;

    public string CodAcceso { get; set; } = null!;

    public virtual SaCodAcceso SaCodAcceso { get; set; } = null!;

    public virtual SaCodGrupoUsu SaCodGrupoUsu { get; set; } = null!;

    public virtual SaCodOpcion SaCodOpcion { get; set; } = null!;
}
