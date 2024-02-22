using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaCodGrupoUsu
{
    public string CodEmpresa { get; set; } = null!;

    public string CodGrupo { get; set; } = null!;

    public string DesGrupo { get; set; } = null!;

    public string? CodEstado { get; set; }

    public virtual SaCodEmpresa CodEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<SaSeguridad> SaSeguridads { get; set; } = new List<SaSeguridad>();

    public virtual ICollection<SaUsuario> SaUsuarios { get; set; } = new List<SaUsuario>();
}
