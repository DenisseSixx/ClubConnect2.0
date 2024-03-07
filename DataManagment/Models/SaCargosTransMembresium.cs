using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaCargosTransMembresium
{
    public string? CodEmpresa { get; set; }

    public decimal CodPlaMem { get; set; }

    public string? CodTipoMembresia { get; set; }

    public string? TipoTransaccion { get; set; }

    public decimal? Monto { get; set; }

    public string? CodEstado { get; set; }
}
