using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaUsuario
{
    public string CodEmpresa { get; set; } = null!;

    public string CodUsuario { get; set; } = null!;

    public string NomUsuario { get; set; } = null!;

    public string ClaUsuario { get; set; } = null!;

    public string DesUsuario { get; set; } = null!;

    public string CodGrupo { get; set; } = null!;

    public string CodEstusu { get; set; } = null!;

    public string CodSucursal { get; set; } = null!;

    public string? CodCaja { get; set; }

    public virtual SaCodEmpresa CodEmpresaNavigation { get; set; } = null!;

    public virtual SaCodEstusu SaCodEstusu { get; set; } = null!;

    public virtual SaCodGrupoUsu SaCodGrupoUsu { get; set; } = null!;

    public virtual SaCodSucursal SaCodSucursal { get; set; } = null!;
}
