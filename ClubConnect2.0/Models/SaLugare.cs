using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaLugare
{
    public string CodEmpresa { get; set; } = null!;

    public string CodCliente { get; set; } = null!;

    public decimal CodImporte { get; set; }

    public string Extra01 { get; set; } = null!;

    public virtual SaImporte SaImporte { get; set; } = null!;
}
