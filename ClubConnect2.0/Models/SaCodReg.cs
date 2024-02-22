using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaCodReg
{
    public string CodEmpresa { get; set; } = null!;

    public string CodSucursal { get; set; } = null!;

    public string CodReg { get; set; } = null!;

    public string? DesReg { get; set; }
}
