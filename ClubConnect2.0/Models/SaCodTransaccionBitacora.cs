using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaCodTransaccionBitacora
{
    public string? CodEmpresa { get; set; }

    public decimal CodTransaccionMembresia { get; set; }

    public string? DesTransaccionMembresia { get; set; }

    public string? CodEstado { get; set; }
}
