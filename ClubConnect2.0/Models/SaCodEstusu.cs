using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaCodEstusu
{
    public string CodEmpresa { get; set; } = null!;

    public string CodEstusu { get; set; } = null!;

    public string DesEstusu { get; set; } = null!;

    public virtual SaCodEmpresa CodEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<Etipodocumento> Etipodocumentos { get; set; } = new List<Etipodocumento>();

    public virtual ICollection<Expediente> Expedientes { get; set; } = new List<Expediente>();

    public virtual ICollection<Expedientetercero> Expedienteterceros { get; set; } = new List<Expedientetercero>();

    public virtual ICollection<SaUsuario> SaUsuarios { get; set; } = new List<SaUsuario>();
}
