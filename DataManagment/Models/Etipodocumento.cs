using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class Etipodocumento
{
    public string CodEmpresa { get; set; } = null!;

    public int CodTipodocumento { get; set; }

    public string? NomTipodocumento { get; set; }

    public string? CodEstusu { get; set; }

    public virtual ICollection<Expediente> Expedientes { get; set; } = new List<Expediente>();

    public virtual ICollection<Expedientetercero> Expedienteterceros { get; set; } = new List<Expedientetercero>();

    public virtual SaCodEstusu? SaCodEstusu { get; set; }
}
