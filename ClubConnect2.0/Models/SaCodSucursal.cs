using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaCodSucursal
{
    public string CodEmpresa { get; set; } = null!;

    public string CodSucursal { get; set; } = null!;

    public string DesSucursal { get; set; } = null!;

    public virtual SaCodEmpresa CodEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<SaUsuario> SaUsuarios { get; set; } = new List<SaUsuario>();
}
