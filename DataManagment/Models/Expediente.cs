using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class Expediente
{
    public int CodArchivo { get; set; }

    public string CodEmpresa { get; set; } = null!;

    public string CodCliente { get; set; } = null!;

    public string CodTercero { get; set; } = null!;

    public decimal CodDependiente { get; set; }

    public int CodTipodocumento { get; set; }

    public string NomDocumento { get; set; } = null!;

    public byte[] Documento { get; set; } = null!;

    public string ExtDocumento { get; set; } = null!;

    public DateTime? Fecha { get; set; }

    public string CodEstusu { get; set; } = null!;

    public virtual Etipodocumento CodTipodocumentoNavigation { get; set; } = null!;

    public virtual SaCodEstusu SaCodEstusu { get; set; } = null!;

    public virtual SaDependiente SaDependiente { get; set; } = null!;
}
