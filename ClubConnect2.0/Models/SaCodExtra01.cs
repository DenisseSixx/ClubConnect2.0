using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaCodExtra01
{
    public string CodEmpresa { get; set; } = null!;

    public string CodCliente { get; set; } = null!;

    public decimal CodImporte { get; set; }

    public string Extra01 { get; set; } = null!;

    public string? Extra02 { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual SaImporte SaImporte { get; set; } = null!;
}
