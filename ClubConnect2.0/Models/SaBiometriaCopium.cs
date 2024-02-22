using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaBiometriaCopium
{
    public string CodEmpresa { get; set; } = null!;

    public string CodCliente { get; set; } = null!;

    public string CodTercero { get; set; } = null!;

    public decimal CodDependiente { get; set; }

    public byte[] Biometria { get; set; } = null!;
}
