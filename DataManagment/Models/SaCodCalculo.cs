using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaCodCalculo
{
    public string CodEmpresa { get; set; } = null!;

    public string CodTipo { get; set; } = null!;

    public string CodSubtipo { get; set; } = null!;

    public string CodCalculo { get; set; } = null!;

    public string DesCalculo { get; set; } = null!;

    public string CodOrigen { get; set; } = null!;

    public string CodPeriodo { get; set; } = null!;

    public string CodEtiqueta { get; set; } = null!;

    public virtual SaCodEmpresa CodEmpresaNavigation { get; set; } = null!;
}
