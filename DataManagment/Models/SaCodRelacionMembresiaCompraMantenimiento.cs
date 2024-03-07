using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaCodRelacionMembresiaCompraMantenimiento
{
    public int CodRelacion { get; set; }

    public string? CodTipoMembresia { get; set; }

    public string? CodTipoCompra { get; set; }

    public string? CodTipoMantenimiento { get; set; }

    public string? CodEstado { get; set; }
}
