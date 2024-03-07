using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaBiometrium
{
    public string CodEmpresa { get; set; } = null!;

    public string CodCliente { get; set; } = null!;

    public string CodTercero { get; set; } = null!;

    public decimal CodDependiente { get; set; }

    public string? Biometria { get; set; }

    public virtual SaTercero SaTercero { get; set; } = null!;
}
