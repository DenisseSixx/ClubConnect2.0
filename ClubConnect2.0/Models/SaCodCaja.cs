using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaCodCaja
{
    public string CodEmpresa { get; set; } = null!;

    public string CodCaja { get; set; } = null!;

    public string DesCaja { get; set; } = null!;

    public string? CodEstado { get; set; }
}
